
namespace SPlabLis
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.secondOperandTB = new System.Windows.Forms.TextBox();
            this.firstOperandTB = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SaveFileDbBtn = new System.Windows.Forms.Button();
            this.DeleteRecordBtn = new System.Windows.Forms.Button();
            this.UpdateRecordBtn = new System.Windows.Forms.Button();
            this.AddRecordBtn = new System.Windows.Forms.Button();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.fileDataGrd = new System.Windows.Forms.DataGridView();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 317);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.linkLabel3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.linkLabel2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Анализатор";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(454, 164);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(65, 17);
            this.linkLabel3.TabIndex = 6;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Ошибки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(454, 118);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(129, 17);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Цикл выполнится:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(454, 76);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 17);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Результат:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Пуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 52);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(272, 158);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "for(int i = 0; i<=10;i+=3){}";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.resetBtn);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.resultLbl);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.secondOperandTB);
            this.tabPage2.Controls.Add(this.firstOperandTB);
            this.tabPage2.Controls.Add(this.calculateBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Низкоуровневая функция";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(677, 250);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(85, 32);
            this.resetBtn.TabIndex = 16;
            this.resetBtn.Text = "Очистить";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Результат:";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.BackColor = System.Drawing.Color.Transparent;
            this.resultLbl.Location = new System.Drawing.Point(366, 196);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 17);
            this.resultLbl.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(375, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "ADD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Второй операнд:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Первый операнд:";
            // 
            // secondOperandTB
            // 
            this.secondOperandTB.Location = new System.Drawing.Point(446, 95);
            this.secondOperandTB.Name = "secondOperandTB";
            this.secondOperandTB.Size = new System.Drawing.Size(100, 22);
            this.secondOperandTB.TabIndex = 9;
            // 
            // firstOperandTB
            // 
            this.firstOperandTB.Location = new System.Drawing.Point(245, 95);
            this.firstOperandTB.Name = "firstOperandTB";
            this.firstOperandTB.Size = new System.Drawing.Size(100, 22);
            this.firstOperandTB.TabIndex = 8;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(349, 139);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(100, 27);
            this.calculateBtn.TabIndex = 10;
            this.calculateBtn.Text = "Высчитать";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SaveFileDbBtn);
            this.tabPage3.Controls.Add(this.DeleteRecordBtn);
            this.tabPage3.Controls.Add(this.UpdateRecordBtn);
            this.tabPage3.Controls.Add(this.AddRecordBtn);
            this.tabPage3.Controls.Add(this.OpenFileBtn);
            this.tabPage3.Controls.Add(this.fileDataGrd);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 288);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Работа с файлом";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SaveFileDbBtn
            // 
            this.SaveFileDbBtn.Location = new System.Drawing.Point(19, 217);
            this.SaveFileDbBtn.Name = "SaveFileDbBtn";
            this.SaveFileDbBtn.Size = new System.Drawing.Size(141, 33);
            this.SaveFileDbBtn.TabIndex = 11;
            this.SaveFileDbBtn.Text = "Сохранить в файл";
            this.SaveFileDbBtn.UseVisualStyleBackColor = true;
            this.SaveFileDbBtn.Click += new System.EventHandler(this.SaveFileDbBtn_Click);
            // 
            // DeleteRecordBtn
            // 
            this.DeleteRecordBtn.Location = new System.Drawing.Point(19, 178);
            this.DeleteRecordBtn.Name = "DeleteRecordBtn";
            this.DeleteRecordBtn.Size = new System.Drawing.Size(141, 33);
            this.DeleteRecordBtn.TabIndex = 10;
            this.DeleteRecordBtn.Text = "Удалить запись";
            this.DeleteRecordBtn.UseVisualStyleBackColor = true;
            this.DeleteRecordBtn.Click += new System.EventHandler(this.DeleteRecordBtn_Click_1);
            // 
            // UpdateRecordBtn
            // 
            this.UpdateRecordBtn.Location = new System.Drawing.Point(19, 139);
            this.UpdateRecordBtn.Name = "UpdateRecordBtn";
            this.UpdateRecordBtn.Size = new System.Drawing.Size(141, 33);
            this.UpdateRecordBtn.TabIndex = 9;
            this.UpdateRecordBtn.Text = "Изменить запись";
            this.UpdateRecordBtn.UseVisualStyleBackColor = true;
            this.UpdateRecordBtn.Click += new System.EventHandler(this.UpdateRecordBtn_Click_1);
            // 
            // AddRecordBtn
            // 
            this.AddRecordBtn.Location = new System.Drawing.Point(19, 61);
            this.AddRecordBtn.Name = "AddRecordBtn";
            this.AddRecordBtn.Size = new System.Drawing.Size(141, 33);
            this.AddRecordBtn.TabIndex = 8;
            this.AddRecordBtn.Text = "Создать запись";
            this.AddRecordBtn.UseVisualStyleBackColor = true;
            this.AddRecordBtn.Click += new System.EventHandler(this.AddRecordBtn_Click_1);
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(19, 100);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(141, 33);
            this.OpenFileBtn.TabIndex = 7;
            this.OpenFileBtn.Text = "Открыть файл";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click_1);
            // 
            // fileDataGrd
            // 
            this.fileDataGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fileDataGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileDataGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adress,
            this.Port,
            this.Protocol});
            this.fileDataGrd.Location = new System.Drawing.Point(166, 13);
            this.fileDataGrd.Name = "fileDataGrd";
            this.fileDataGrd.RowHeadersWidth = 51;
            this.fileDataGrd.RowTemplate.Height = 24;
            this.fileDataGrd.Size = new System.Drawing.Size(596, 269);
            this.fileDataGrd.TabIndex = 6;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Server Adress";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.MinimumWidth = 6;
            this.Port.Name = "Port";
            // 
            // Protocol
            // 
            this.Protocol.HeaderText = "Protocol";
            this.Protocol.MinimumWidth = 6;
            this.Protocol.Name = "Protocol";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 335);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(772, 175);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 522);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SaveFileDbBtn;
        private System.Windows.Forms.Button DeleteRecordBtn;
        private System.Windows.Forms.Button UpdateRecordBtn;
        private System.Windows.Forms.Button AddRecordBtn;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.DataGridView fileDataGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox secondOperandTB;
        private System.Windows.Forms.TextBox firstOperandTB;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}

