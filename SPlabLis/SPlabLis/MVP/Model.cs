using SPLib;
using SPLib.Models;
using SPlabLis.MVP;
using System.Collections.Generic;
using System.Reflection;

namespace SPlabLis.MVP
{
    class Model : IModel
    {
        private LowLevelFunc.IAdd add;
        public Model()
        {
            LowLevelFunc.SaveDll();
            add = (LowLevelFunc.IAdd)Assembly.LoadFrom("lowLvlAdd.dll").CreateInstance("COperands");
        }

        public void ResetFunction(ref int first, ref int second, ref int result)
        {
            first = second = result = 0;
        }

        public int GetResult(int first, int second)
        {
            return add.add(first, second);
        }

        public void ResetAnalyzer(ref string[] text, ref string res, ref string count)
        {
            text = new string[1];
            count = res = "";
        }

        public AnalyzerResult GetResulAnalyze(string[] cycleLines)
        {
            return Analyzer.Research(cycleLines);
        }

        public List<ServerInfo> OpenTextFile()
        {
            FileHelper fh = new FileHelper();
            return fh.OpenFile();

        }

        public void UpdateRecord(int index, string Adrress, int Port, string Protocol)
        {
            ServerInfoForm f = new ServerInfoForm();
        }
        public void SaveFile(List<ServerInfo> list)
        {
            FileHelper fh = new FileHelper();
            fh.SaveFile(list);
        }
    }
}
