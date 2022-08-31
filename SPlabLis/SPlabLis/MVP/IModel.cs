
using SPLib;
using SPLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPlabLis.MVP
{
    interface IModel
    {
        void ResetFunction(ref int first, ref int second, ref int result);

        int GetResult(int first, int second);

        void ResetAnalyzer(ref string[] text, ref string res, ref string count);

        AnalyzerResult GetResulAnalyze(string[] cycleLines);

        List<ServerInfo> OpenTextFile();

        void UpdateRecord(int index, string Adrress, int Port, string Protocol);

        void SaveFile(List<ServerInfo> list);
    }
}
