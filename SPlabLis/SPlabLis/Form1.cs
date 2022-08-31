using System;
using System.Windows.Forms;
using System.Collections.Generic;
using SPlabLis.MVP;
using SPLib;
using SPLib.Models;

namespace SPlabLis
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int FirstOperand { get => int.Parse(firstOperandTB.Text); set => firstOperandTB.Text = value.ToString(); }
        public int SecondOperand { get => int.Parse(secondOperandTB.Text); set => secondOperandTB.Text = value.ToString(); }
        public int Result { get => int.Parse(resultLbl.Text); set => resultLbl.Text = value.ToString(); }

        public string[] LoopText { get => textBox2.Lines; set => textBox2.Lines = value; }
        public string AnalyzResultText { get => label1.Text; set => label1.Text = value; }
        public string IterationCount { get => label2.Text; set => label2.Text = value; }
        public string ErrorMessage { get => label3.Text; set => label3.Text = value; }

        private List<ServerInfo> _FileDb = new List<ServerInfo>();
        public List<ServerInfo> FileDb
        {
            get => _FileDb;
            set
            {
                fileDataGrd.Rows.Clear();
                _FileDb = value;
                value.ForEach((el) => fileDataGrd.Rows.Add(el.Adress, el.Port, el.Protocol));
            }
        }
        public int SelectedCellIndex { get => fileDataGrd.CurrentCell.RowIndex; }

        public event EventHandler GetFunctionEvent;
        public event EventHandler ResetFunctionEvent;

        public event EventHandler GetAnalyzeEvent;

        public event EventHandler OpenFileEvent;
        public event EventHandler UdateRecordEvent;
        public event EventHandler CreateRecordEvent;
        public event EventHandler DeleteRecordEvent;
        public event EventHandler SaveFileEvent;
        public string ConsoleLog
        {
            set
            {
                textBox1.AppendText($"[{DateTime.Now.ToLongTimeString()}]: {value}\r\n");
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAnalyzeEvent?.Invoke(null, null);
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            GetFunctionEvent?.Invoke(null, null);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetFunctionEvent?.Invoke(null, null);
        }
       
        private void AddRecordBtn_Click_1(object sender, EventArgs e)
        {
            CreateRecordEvent?.Invoke(null, null);
        }

        private void OpenFileBtn_Click_1(object sender, EventArgs e)
        {
            OpenFileEvent?.Invoke(null, null);
        }

        private void UpdateRecordBtn_Click_1(object sender, EventArgs e)
        {
            UdateRecordEvent?.Invoke(null, null);
        }

        private void DeleteRecordBtn_Click_1(object sender, EventArgs e)
        {
            DeleteRecordEvent?.Invoke(null, null);
        }

        private void SaveFileDbBtn_Click(object sender, EventArgs e)
        {
            SaveFileEvent?.Invoke(null, null);
        }
    }
}
