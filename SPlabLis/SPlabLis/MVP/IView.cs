using SPLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPlabLis.MVP
{
    interface IView
    {
        event EventHandler GetFunctionEvent;
        event EventHandler ResetFunctionEvent;

        event EventHandler GetAnalyzeEvent;

        event EventHandler OpenFileEvent;
        event EventHandler UdateRecordEvent;
        event EventHandler CreateRecordEvent;
        event EventHandler DeleteRecordEvent;
        event EventHandler SaveFileEvent;

        int FirstOperand { get; set; }
        int SecondOperand { get; set; }
        int Result { get; set; }

        string[] LoopText { get; set; }
        string AnalyzResultText { get; set; }
        string IterationCount { get; set; }
        string ErrorMessage { get; set; }
        List<ServerInfo> FileDb { get; set; }
        int SelectedCellIndex { get; }
        
        string ConsoleLog { set; }
    }
   
}
