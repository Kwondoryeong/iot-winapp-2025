namespace SyntaxWinApp03
{
    partial class FrmMain
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
            BtnStart = new Button();
            label1 = new Label();
            TxtLog = new TextBox();
            statusStrip1 = new StatusStrip();
            LblCurrState = new ToolStripStatusLabel();
            PrgProcess = new ToolStripProgressBar();
            PrgProcess2 = new ProgressBar();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(472, 255);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(100, 30);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "시작";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "로그";
            // 
            // TxtLog
            // 
            TxtLog.Location = new Point(12, 27);
            TxtLog.Multiline = true;
            TxtLog.Name = "TxtLog";
            TxtLog.Size = new Size(560, 222);
            TxtLog.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblCurrState, PrgProcess });
            statusStrip1.Location = new Point(0, 289);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(584, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblCurrState
            // 
            LblCurrState.Name = "LblCurrState";
            LblCurrState.Size = new Size(90, 17);
            LblCurrState.Text = "현재상태 : 중지";
            // 
            // PrgProcess
            // 
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(380, 16);
            // 
            // PrgProcess2
            // 
            PrgProcess2.Location = new Point(12, 255);
            PrgProcess2.Name = "PrgProcess2";
            PrgProcess2.Size = new Size(454, 30);
            PrgProcess2.TabIndex = 4;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(PrgProcess2);
            Controls.Add(statusStrip1);
            Controls.Add(TxtLog);
            Controls.Add(label1);
            Controls.Add(BtnStart);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "스레드연습 앱";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnStart;
        private Label label1;
        private TextBox TxtLog;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LblCurrState;
        private ToolStripProgressBar PrgProcess;
        private ProgressBar PrgProcess2;
    }
}
