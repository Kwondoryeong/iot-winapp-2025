
namespace sudoku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            BtnCheck = new System.Windows.Forms.Button();
            BtnRestart = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            BtnAnswer = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            BtnSave = new System.Windows.Forms.Button();
            BtnLoad = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnHintSec = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            lblTimer = new System.Windows.Forms.Label();
            lblClearedGames = new System.Windows.Forms.Label();
            lblNewGame = new System.Windows.Forms.Label();
            lblCheckCount = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new System.Drawing.Point(274, 60);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new System.Drawing.Size(85, 30);
            BtnCheck.TabIndex = 3;
            BtnCheck.Text = "정답 확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // BtnRestart
            // 
            BtnRestart.Location = new System.Drawing.Point(8, 22);
            BtnRestart.Name = "BtnRestart";
            BtnRestart.Size = new System.Drawing.Size(85, 30);
            BtnRestart.TabIndex = 1;
            BtnRestart.Text = "새 게임시작";
            BtnRestart.UseVisualStyleBackColor = true;
            BtnRestart.Click += BtnRestart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(410, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 15);
            label2.TabIndex = 12;
            label2.Text = "힌트";
            // 
            // BtnAnswer
            // 
            BtnAnswer.Location = new System.Drawing.Point(274, 24);
            BtnAnswer.Name = "BtnAnswer";
            BtnAnswer.Size = new System.Drawing.Size(85, 30);
            BtnAnswer.TabIndex = 2;
            BtnAnswer.Text = "힌트 확인";
            BtnAnswer.UseVisualStyleBackColor = true;
            BtnAnswer.Click += BtnAnswer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 15);
            label1.TabIndex = 12;
            label1.Text = "게임판";
            // 
            // BtnSave
            // 
            BtnSave.Location = new System.Drawing.Point(6, 60);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new System.Drawing.Size(85, 30);
            BtnSave.TabIndex = 4;
            BtnSave.Text = "저장";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new System.Drawing.Point(95, 60);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new System.Drawing.Size(85, 30);
            BtnLoad.TabIndex = 5;
            BtnLoad.Text = "불러오기";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnSave);
            groupBox1.Controls.Add(btnHintSec);
            groupBox1.Controls.Add(BtnAnswer);
            groupBox1.Controls.Add(BtnLoad);
            groupBox1.Controls.Add(BtnCheck);
            groupBox1.Controls.Add(BtnRestart);
            groupBox1.Location = new System.Drawing.Point(12, 447);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(367, 102);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "메뉴";
            // 
            // btnHintSec
            // 
            btnHintSec.Enabled = false;
            btnHintSec.Location = new System.Drawing.Point(184, 24);
            btnHintSec.Name = "btnHintSec";
            btnHintSec.Size = new System.Drawing.Size(85, 30);
            btnHintSec.TabIndex = 2;
            btnHintSec.Text = "3초 힌트";
            btnHintSec.UseVisualStyleBackColor = true;
            btnHintSec.Visible = false;
            btnHintSec.Click += btnHintSec_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTimer);
            groupBox2.Controls.Add(lblClearedGames);
            groupBox2.Controls.Add(lblNewGame);
            groupBox2.Controls.Add(lblCheckCount);
            groupBox2.Location = new System.Drawing.Point(410, 447);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(175, 100);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "점수판";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new System.Drawing.Point(27, 76);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new System.Drawing.Size(114, 15);
            lblTimer.TabIndex = 3;
            lblTimer.Text = "진행시간 : 00:00:00";
            // 
            // lblClearedGames
            // 
            lblClearedGames.AutoSize = true;
            lblClearedGames.Location = new System.Drawing.Point(11, 58);
            lblClearedGames.Name = "lblClearedGames";
            lblClearedGames.Size = new System.Drawing.Size(89, 15);
            lblClearedGames.TabIndex = 2;
            lblClearedGames.Text = "완료게임 수 : 0";
            // 
            // lblNewGame
            // 
            lblNewGame.AutoSize = true;
            lblNewGame.Location = new System.Drawing.Point(11, 19);
            lblNewGame.Name = "lblNewGame";
            lblNewGame.Size = new System.Drawing.Size(89, 15);
            lblNewGame.TabIndex = 1;
            lblNewGame.Text = "게임시작 수 : 0";
            // 
            // lblCheckCount
            // 
            lblCheckCount.AutoSize = true;
            lblCheckCount.Location = new System.Drawing.Point(11, 39);
            lblCheckCount.Name = "lblCheckCount";
            lblCheckCount.Size = new System.Drawing.Size(89, 15);
            lblCheckCount.TabIndex = 0;
            lblCheckCount.Text = "정답확인 수 : 0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new System.Drawing.Point(598, 447);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(175, 100);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "게임방법";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(18, 76);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(122, 15);
            label6.TabIndex = 0;
            label6.Text = "스페이스 바 : 값 증가";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 58);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(134, 15);
            label5.TabIndex = 0;
            label5.Text = "키보드 방향키 : 칸 이동";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 39);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(134, 15);
            label4.TabIndex = 0;
            label4.Text = "마우스 우클릭 : 값 감소";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(134, 15);
            label3.TabIndex = 0;
            label3.Text = "마우스 좌클릭 : 값 증가";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 561);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            Text = "스도쿠";
            Load += FrmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCheckCount;
        private System.Windows.Forms.Label lblNewGame;
        private System.Windows.Forms.Label lblClearedGames;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHintSec;
        private System.Windows.Forms.Label lblTimer;
    }
}

