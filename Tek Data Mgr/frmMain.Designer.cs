
namespace Tek_Data_Mgr
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnFindPath = new System.Windows.Forms.Button();
            this.lbReplayCount = new System.Windows.Forms.Label();
            this.numUD_Repeat = new System.Windows.Forms.NumericUpDown();
            this.btnBackupThread = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.txtSetName = new System.Windows.Forms.TextBox();
            this.chkSetName = new System.Windows.Forms.CheckBox();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.txtPath3 = new System.Windows.Forms.TextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultFolderPath = new System.Windows.Forms.TextBox();
            this.btnFileBrowser_ResultPath = new System.Windows.Forms.Button();
            this.btnAutoFind = new System.Windows.Forms.Button();
            this.chkSetResultPath = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtxtbox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Repeat)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath1
            // 
            this.txtPath1.Location = new System.Drawing.Point(24, 13);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(648, 21);
            this.txtPath1.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTitle.Location = new System.Drawing.Point(32, 16);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(392, 40);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "TargetFilePath";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFindPath
            // 
            this.btnFindPath.Location = new System.Drawing.Point(592, 16);
            this.btnFindPath.Name = "btnFindPath";
            this.btnFindPath.Size = new System.Drawing.Size(131, 40);
            this.btnFindPath.TabIndex = 2;
            this.btnFindPath.Text = "Find Path";
            this.btnFindPath.UseVisualStyleBackColor = true;
            this.btnFindPath.Click += new System.EventHandler(this.btnFindPath_Click);
            // 
            // lbReplayCount
            // 
            this.lbReplayCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbReplayCount.Location = new System.Drawing.Point(32, 328);
            this.lbReplayCount.Name = "lbReplayCount";
            this.lbReplayCount.Size = new System.Drawing.Size(128, 40);
            this.lbReplayCount.TabIndex = 3;
            this.lbReplayCount.Text = "ReplayCount";
            this.lbReplayCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numUD_Repeat
            // 
            this.numUD_Repeat.Location = new System.Drawing.Point(200, 328);
            this.numUD_Repeat.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUD_Repeat.Name = "numUD_Repeat";
            this.numUD_Repeat.Size = new System.Drawing.Size(128, 21);
            this.numUD_Repeat.TabIndex = 4;
            // 
            // btnBackupThread
            // 
            this.btnBackupThread.Location = new System.Drawing.Point(760, 296);
            this.btnBackupThread.Name = "btnBackupThread";
            this.btnBackupThread.Size = new System.Drawing.Size(216, 72);
            this.btnBackupThread.TabIndex = 5;
            this.btnBackupThread.Text = "Start with Count";
            this.btnBackupThread.UseVisualStyleBackColor = true;
            this.btnBackupThread.Click += new System.EventHandler(this.btnBackupThread_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(760, 200);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(216, 72);
            this.btnBackup.TabIndex = 7;
            this.btnBackup.Tag = "";
            this.btnBackup.Text = "ManualBackup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtSetName
            // 
            this.txtSetName.Location = new System.Drawing.Point(584, 336);
            this.txtSetName.Name = "txtSetName";
            this.txtSetName.Size = new System.Drawing.Size(128, 21);
            this.txtSetName.TabIndex = 10;
            // 
            // chkSetName
            // 
            this.chkSetName.AutoSize = true;
            this.chkSetName.Location = new System.Drawing.Point(424, 336);
            this.chkSetName.Name = "chkSetName";
            this.chkSetName.Size = new System.Drawing.Size(76, 16);
            this.chkSetName.TabIndex = 12;
            this.chkSetName.Text = "SetName";
            this.chkSetName.UseVisualStyleBackColor = true;
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(24, 40);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(648, 21);
            this.txtPath2.TabIndex = 13;
            // 
            // txtPath3
            // 
            this.txtPath3.Location = new System.Drawing.Point(24, 67);
            this.txtPath3.Name = "txtPath3";
            this.txtPath3.Size = new System.Drawing.Size(648, 21);
            this.txtPath3.TabIndex = 14;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(4, 16);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(14, 13);
            this.rb1.TabIndex = 15;
            this.rb1.TabStop = true;
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(4, 43);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(14, 13);
            this.rb2.TabIndex = 16;
            this.rb2.TabStop = true;
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(4, 70);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(14, 13);
            this.rb3.TabIndex = 17;
            this.rb3.TabStop = true;
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(760, 112);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 72);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(760, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 72);
            this.button1.TabIndex = 20;
            this.button1.Text = "Load Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb1);
            this.panel1.Controls.Add(this.txtPath1);
            this.panel1.Controls.Add(this.txtPath2);
            this.panel1.Controls.Add(this.txtPath3);
            this.panel1.Controls.Add(this.rb3);
            this.panel1.Controls.Add(this.rb2);
            this.panel1.Location = new System.Drawing.Point(32, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 100);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(672, 40);
            this.label3.TabIndex = 22;
            this.label3.Text = "BackupPath";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResultFolderPath
            // 
            this.txtResultFolderPath.Location = new System.Drawing.Point(8, 96);
            this.txtResultFolderPath.Name = "txtResultFolderPath";
            this.txtResultFolderPath.Size = new System.Drawing.Size(672, 21);
            this.txtResultFolderPath.TabIndex = 23;
            // 
            // btnFileBrowser_ResultPath
            // 
            this.btnFileBrowser_ResultPath.Location = new System.Drawing.Point(520, 8);
            this.btnFileBrowser_ResultPath.Name = "btnFileBrowser_ResultPath";
            this.btnFileBrowser_ResultPath.Size = new System.Drawing.Size(163, 32);
            this.btnFileBrowser_ResultPath.TabIndex = 24;
            this.btnFileBrowser_ResultPath.Text = "File Browser";
            this.btnFileBrowser_ResultPath.UseVisualStyleBackColor = true;
            this.btnFileBrowser_ResultPath.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAutoFind
            // 
            this.btnAutoFind.Location = new System.Drawing.Point(440, 16);
            this.btnAutoFind.Name = "btnAutoFind";
            this.btnAutoFind.Size = new System.Drawing.Size(131, 40);
            this.btnAutoFind.TabIndex = 25;
            this.btnAutoFind.Text = "AutoFind";
            this.btnAutoFind.UseVisualStyleBackColor = true;
            this.btnAutoFind.Click += new System.EventHandler(this.button4_Click);
            // 
            // chkSetResultPath
            // 
            this.chkSetResultPath.AutoSize = true;
            this.chkSetResultPath.Location = new System.Drawing.Point(8, 16);
            this.chkSetResultPath.Name = "chkSetResultPath";
            this.chkSetResultPath.Size = new System.Drawing.Size(110, 16);
            this.chkSetResultPath.TabIndex = 26;
            this.chkSetResultPath.Text = "Set Result Path";
            this.chkSetResultPath.UseVisualStyleBackColor = true;
            this.chkSetResultPath.CheckedChanged += new System.EventHandler(this.chkSetResultPath_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkSetResultPath);
            this.panel2.Controls.Add(this.btnFileBrowser_ResultPath);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtResultFolderPath);
            this.panel2.Location = new System.Drawing.Point(32, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 128);
            this.panel2.TabIndex = 27;
            // 
            // rtxtbox
            // 
            this.rtxtbox.Location = new System.Drawing.Point(32, 424);
            this.rtxtbox.Name = "rtxtbox";
            this.rtxtbox.ReadOnly = true;
            this.rtxtbox.Size = new System.Drawing.Size(944, 256);
            this.rtxtbox.TabIndex = 28;
            this.rtxtbox.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 698);
            this.Controls.Add(this.rtxtbox);
            this.Controls.Add(this.btnAutoFind);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkSetName);
            this.Controls.Add(this.txtSetName);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnBackupThread);
            this.Controls.Add(this.numUD_Repeat);
            this.Controls.Add(this.lbReplayCount);
            this.Controls.Add(this.btnFindPath);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.panel2);
            this.Name = "frmMain";
            this.Text = "Tekken Data Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Repeat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnFindPath;
        private System.Windows.Forms.Label lbReplayCount;
        private System.Windows.Forms.NumericUpDown numUD_Repeat;
        private System.Windows.Forms.Button btnBackupThread;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox txtSetName;
        private System.Windows.Forms.CheckBox chkSetName;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.TextBox txtPath3;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultFolderPath;
        private System.Windows.Forms.Button btnFileBrowser_ResultPath;
        private System.Windows.Forms.Button btnAutoFind;
        private System.Windows.Forms.CheckBox chkSetResultPath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtxtbox;
    }
}

