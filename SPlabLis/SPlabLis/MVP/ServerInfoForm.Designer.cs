
namespace SPlabLis.MVP
{
    partial class ServerInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TcpRadio = new System.Windows.Forms.RadioButton();
            this.UdpRadio = new System.Windows.Forms.RadioButton();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adressLbl = new System.Windows.Forms.Label();
            this.PortInput = new System.Windows.Forms.TextBox();
            this.AdressInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TcpRadio
            // 
            this.TcpRadio.AutoSize = true;
            this.TcpRadio.Location = new System.Drawing.Point(241, 175);
            this.TcpRadio.Name = "TcpRadio";
            this.TcpRadio.Size = new System.Drawing.Size(56, 21);
            this.TcpRadio.TabIndex = 16;
            this.TcpRadio.TabStop = true;
            this.TcpRadio.Text = "TCP";
            this.TcpRadio.UseVisualStyleBackColor = true;
            // 
            // UdpRadio
            // 
            this.UdpRadio.AutoSize = true;
            this.UdpRadio.Checked = true;
            this.UdpRadio.Location = new System.Drawing.Point(47, 175);
            this.UdpRadio.Name = "UdpRadio";
            this.UdpRadio.Size = new System.Drawing.Size(58, 21);
            this.UdpRadio.TabIndex = 15;
            this.UdpRadio.TabStop = true;
            this.UdpRadio.Text = "UDP";
            this.UdpRadio.UseVisualStyleBackColor = true;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(108, 209);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(120, 33);
            this.SubmitBtn.TabIndex = 14;
            this.SubmitBtn.Text = "Подтвердить";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Протокол сервера:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Порт сервера:";
            // 
            // adressLbl
            // 
            this.adressLbl.AutoSize = true;
            this.adressLbl.Location = new System.Drawing.Point(44, 23);
            this.adressLbl.Name = "adressLbl";
            this.adressLbl.Size = new System.Drawing.Size(110, 17);
            this.adressLbl.TabIndex = 11;
            this.adressLbl.Text = "Адрес сервера:";
            // 
            // PortInput
            // 
            this.PortInput.Location = new System.Drawing.Point(44, 105);
            this.PortInput.Name = "PortInput";
            this.PortInput.Size = new System.Drawing.Size(276, 22);
            this.PortInput.TabIndex = 10;
            // 
            // AdressInput
            // 
            this.AdressInput.Location = new System.Drawing.Point(44, 46);
            this.AdressInput.Name = "AdressInput";
            this.AdressInput.Size = new System.Drawing.Size(276, 22);
            this.AdressInput.TabIndex = 9;
            // 
            // ServerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 278);
            this.Controls.Add(this.TcpRadio);
            this.Controls.Add(this.UdpRadio);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adressLbl);
            this.Controls.Add(this.PortInput);
            this.Controls.Add(this.AdressInput);
            this.Name = "ServerInfoForm";
            this.Text = "ServerInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton TcpRadio;
        public System.Windows.Forms.RadioButton UdpRadio;
        public System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label adressLbl;
        public System.Windows.Forms.TextBox PortInput;
        public System.Windows.Forms.TextBox AdressInput;
    }
}