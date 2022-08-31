using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPLib
{
    public static class Analyzer
    {
        private static string getCodeString(string[] whileConstruction)
        {
            StringBuilder str = new StringBuilder(string.Empty);
            foreach (var el in whileConstruction) str.Append(el);

            string cycle = str.ToString();
            if (cycle.Contains("}"))
                cycle = cycle.Insert(cycle.LastIndexOf('}'), "Console.WriteLine(\"iter\");");

            if (!cycle.Contains("for"))
            {
                throw new Exception("Ошибка построения конструкции");
            }
            var s = string.Format("using System;" +
                "namespace Check{{" +
                "class Analyz{{" +
                "static void Main(string[] args){{" +
                "{0} }}}}}}",
                cycle);
            return s;
        }

        public static AnalyzerResult Research(string[] cycle)
        {
            // Задаём язык
            CodeDomProvider codeProvider = CodeDomProvider.CreateProvider("CSharp");
            // Имя файла
            string Output = "Out.exe";
            CompilerParameters parameters = new CompilerParameters
            {
                GenerateExecutable = true,
                OutputAssembly = Output
            };

            // создаём exeFile
            CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, getCodeString(cycle));
            if (results.Errors.Count > 0)
            {
                // Возвразаем ошибку
                return new AnalyzerResult { returnValue = results.Errors[0].ErrorText, validStatus = false, cycleCount = 0 };
            }
            else
            {
                Process process = new Process();

                // Задаём стартовые параметры 
                process.StartInfo.FileName = Output;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = false;
                process.StartInfo.UseShellExecute = false;

                // В StringBuilder будем добавлять полученные данные
                var sb = new StringBuilder(string.Empty);
                int count = 0;
                // Запускаем процесс
                process.Start();
                while (!process.StandardOutput.EndOfStream)
                {
                    if (!process.StandardOutput.ReadLine().Equals("iter"))
                    {
                        sb.Append(process.StandardOutput.ReadLine());
                    }
                    else
                    {
                        count++;
                    }
                }
                process.Close();

                return new AnalyzerResult { returnValue = sb.ToString(), validStatus = true, cycleCount = count };
            }

        }
    }
}
