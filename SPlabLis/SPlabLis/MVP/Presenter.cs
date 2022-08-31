using SPLib.Models;
using SPlabLis.MVP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SPlabLis.MVP
{
    class Presenter
    {
        private IView view;
        private Model model;

        public Presenter(IView view)
        {
            this.view = view;
            model = new Model();

            this.view.GetAnalyzeEvent += (AnalyzResult);

            this.view.GetFunctionEvent += (GetAddResult);
            this.view.ResetFunctionEvent += (ResetAdd);

            this.view.OpenFileEvent += (OpenFile);
            this.view.UdateRecordEvent += (UpdateRecord);
            this.view.CreateRecordEvent += (AddRecord);
            this.view.DeleteRecordEvent += (DeleteRecord);
            this.view.SaveFileEvent += (SaveFile);
        }

        private void GetAddResult(object sender, EventArgs e)
        {
            try
            {
                view.ConsoleLog = "Начало низкоуровневой функции";
                int result = model.GetResult(view.FirstOperand, view.SecondOperand);
                view.Result = result;
                view.ConsoleLog = "Низкоуровневая функция прошла успешно";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вы ввели строку, а ожидалось число", "Ошибка");
                view.ConsoleLog = ex.Message;
                view.Result = 0;
            }
        }

        private void ResetAdd(object sender, EventArgs e)
        {
            try
            {
                view.ConsoleLog = "Очистка полей функции";
                view.FirstOperand = 0;
                view.SecondOperand = 0;
                view.Result = 0;
                view.ConsoleLog = "Очистка полей функции прошла успешно";
            }
            catch (Exception ex)
            {
                view.ConsoleLog = ex.Message;
            }
        }
        private void AnalyzResult(object sender, EventArgs e)
        {
            try
            {
                view.ConsoleLog = "Начало анализа цикла.";
                var result = model.GetResulAnalyze(view.LoopText);
                view.ConsoleLog = result.returnValue.Equals(String.Empty) ? "Код скомпилирован без ошибок." : result.returnValue;
                view.ErrorMessage = result.returnValue.Equals(String.Empty) ? "Код скомпилирован без ошибок." : result.returnValue;
                view.AnalyzResultText = result.validStatus ? "Удачно" : "Неудачно";
                view.IterationCount = result.cycleCount.ToString();
            }
            catch (Exception ex)
            {
                view.AnalyzResultText = "Неудачно";
                view.ConsoleLog = ex.Message;

            }

        }

        private void OpenFile(object sender, EventArgs e)
        {
            try
            {
                view.ConsoleLog = "Вызов контекстного меню открытия файла";
                view.FileDb = model.OpenTextFile();
                view.ConsoleLog = "Файл открыт успешно";
            }
            catch (Exception ex)
            {
                view.ConsoleLog = ex.Message;
            }
        }

        private void UpdateRecord(object sender, EventArgs e)
        {
            try
            {
                view.ConsoleLog = "Открытие контексного меню изменения файла";
                ServerInfoForm f = new ServerInfoForm();
                f.SubmitBtn.Click += (s, ea) =>
                {
                    var db = view.FileDb;
                    db.RemoveAt(view.SelectedCellIndex);
                    db.Insert(view.SelectedCellIndex, new ServerInfo(f.AdressInput.Text, int.Parse(f.PortInput.Text), f.TcpRadio.Checked ? "TCP" : "UDP"));
                    view.FileDb = db;
                    f.Close();
                    view.ConsoleLog = "Изменение базы прошло успешно";
                };
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                view.ConsoleLog = ex.Message;
            }
        }

        private void AddRecord(object sender, EventArgs e)
        {
            try
            {
                view.ConsoleLog = "Вызов контекстного меню добавления записи";
                ServerInfoForm f = new ServerInfoForm();
                f.SubmitBtn.Click += (s, ea) =>
                {
                    var db = view.FileDb;
                    db.Insert(view.SelectedCellIndex, new ServerInfo(f.AdressInput.Text, int.Parse(f.PortInput.Text), f.TcpRadio.Checked ? "TCP" : "UDP"));
                    view.FileDb = db;
                    f.Close();
                    view.ConsoleLog = "Добавление записи прошло успешно";
                };
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                view.ConsoleLog = ex.Message;
            }
        }

        private void DeleteRecord(object sender, EventArgs e)
        {
            try
            {
                var db = view.FileDb;
                db.RemoveAt(view.SelectedCellIndex);
                view.FileDb = db;
                view.ConsoleLog = "Удаление записи прошло успешно";
            }
            catch (Exception ex)
            {
                view.ConsoleLog = ex.Message;
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            try
            {
                view.ConsoleLog = "Вызов контекстоного меню сохранения файла";
                model.SaveFile(view.FileDb);
                view.ConsoleLog = "Сохранение файла прошло успешно";
            }
            catch (Exception ex)
            {
                view.ConsoleLog = ex.Message;
            }
        }

    }
}
