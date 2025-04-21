namespace SyntaxWinApp04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblName = new Label();
            TxtName = new TextBox();
            Lblage = new Label();
            TxtAge = new TextBox();
            LblGender = new Label();
            RdoMale = new RadioButton();
            RdoFemale = new RadioButton();
            BtnMsg = new Button();
            LblResult = new Label();
            TxtResult = new TextBox();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(12, 9);
            LblName.Name = "LblName";
            LblName.Size = new Size(62, 15);
            LblName.TabIndex = 0;
            LblName.Text = "이름입력 :";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(90, 5);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(121, 23);
            TxtName.TabIndex = 0;
            // 
            // Lblage
            // 
            Lblage.AutoSize = true;
            Lblage.Location = new Point(12, 40);
            Lblage.Name = "Lblage";
            Lblage.Size = new Size(62, 15);
            Lblage.TabIndex = 0;
            Lblage.Text = "나이입력 :";
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(90, 36);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(121, 23);
            TxtAge.TabIndex = 1;
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Location = new Point(12, 69);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(62, 15);
            LblGender.TabIndex = 0;
            LblGender.Text = "성별입력 :";
            // 
            // RdoMale
            // 
            RdoMale.AutoSize = true;
            RdoMale.Checked = true;
            RdoMale.Location = new Point(90, 67);
            RdoMale.Name = "RdoMale";
            RdoMale.Size = new Size(49, 19);
            RdoMale.TabIndex = 2;
            RdoMale.TabStop = true;
            RdoMale.Text = "남성";
            RdoMale.UseVisualStyleBackColor = true;
            // 
            // RdoFemale
            // 
            RdoFemale.AutoSize = true;
            RdoFemale.Location = new Point(145, 67);
            RdoFemale.Name = "RdoFemale";
            RdoFemale.Size = new Size(49, 19);
            RdoFemale.TabIndex = 3;
            RdoFemale.Text = "여성";
            RdoFemale.UseVisualStyleBackColor = true;
            // 
            // BtnMsg
            // 
            BtnMsg.Location = new Point(472, 259);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(100, 40);
            BtnMsg.TabIndex = 5;
            BtnMsg.Text = "확인";
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(12, 130);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(62, 15);
            LblResult.TabIndex = 0;
            LblResult.Text = "결      과 :";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(90, 127);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(482, 23);
            TxtResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(BtnMsg);
            Controls.Add(RdoFemale);
            Controls.Add(RdoMale);
            Controls.Add(LblGender);
            Controls.Add(TxtResult);
            Controls.Add(LblResult);
            Controls.Add(TxtAge);
            Controls.Add(Lblage);
            Controls.Add(TxtName);
            Controls.Add(LblName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법연습 윈앱 04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private TextBox TxtName;
        private Label Lblage;
        private TextBox TxtAge;
        private Label LblGender;
        private RadioButton RdoMale;
        private RadioButton RdoFemale;
        private Button BtnMsg;
        private Label LblResult;
        private TextBox TxtResult;
    }
}
