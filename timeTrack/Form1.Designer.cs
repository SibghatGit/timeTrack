namespace timeTrack
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startButton = new System.Windows.Forms.Button();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.ProjectTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextbox = new System.Windows.Forms.TextBox();
            this.timeNow = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.Label();
            this.projectLab = new System.Windows.Forms.Label();
            this.messageLab = new System.Windows.Forms.Label();
            this.endButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.newToolStripMenuItem.Text = "New";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(463, 81);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButtonClicked);
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(13, 56);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(73, 17);
            this.StartTimeLabel.TabIndex = 3;
            this.StartTimeLabel.Text = "Start Time";
            this.StartTimeLabel.Click += new System.EventHandler(this.startTimeLabel);
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Location = new System.Drawing.Point(209, 56);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(52, 17);
            this.ProjectLabel.TabIndex = 4;
            this.ProjectLabel.Text = "Project";
            this.ProjectLabel.Click += new System.EventHandler(this.ProjectLabel_Click);
            // 
            // ProjectTextBox
            // 
            this.ProjectTextBox.Location = new System.Drawing.Point(209, 81);
            this.ProjectTextBox.Name = "ProjectTextBox";
            this.ProjectTextBox.Size = new System.Drawing.Size(100, 22);
            this.ProjectTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Previous Time";
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(13, 193);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(525, 122);
            this.list.TabIndex = 7;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.SelectedIndexChanged += new System.EventHandler(this.listView);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(108, 81);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(36, 17);
            this.time.TabIndex = 9;
            this.time.Text = "       ";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(338, 56);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(65, 17);
            this.messageLabel.TabIndex = 11;
            this.messageLabel.Text = "Message";
            this.messageLabel.Click += new System.EventHandler(this.Form1_Click);
            // 
            // messageTextbox
            // 
            this.messageTextbox.Location = new System.Drawing.Point(338, 81);
            this.messageTextbox.Name = "messageTextbox";
            this.messageTextbox.Size = new System.Drawing.Size(100, 22);
            this.messageTextbox.TabIndex = 12;
            // 
            // timeNow
            // 
            this.timeNow.AutoSize = true;
            this.timeNow.Location = new System.Drawing.Point(108, 56);
            this.timeNow.Name = "timeNow";
            this.timeNow.Size = new System.Drawing.Size(70, 17);
            this.timeNow.TabIndex = 13;
            this.timeNow.Text = "Time Now";
            this.timeNow.Click += new System.EventHandler(this.label3_Click);
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Location = new System.Drawing.Point(13, 81);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(24, 17);
            this.startTime.TabIndex = 14;
            this.startTime.Text = "    ";
            // 
            // projectLab
            // 
            this.projectLab.AutoSize = true;
            this.projectLab.Location = new System.Drawing.Point(209, 81);
            this.projectLab.Name = "projectLab";
            this.projectLab.Size = new System.Drawing.Size(28, 17);
            this.projectLab.TabIndex = 16;
            this.projectLab.Text = "     ";
            // 
            // messageLab
            // 
            this.messageLab.AutoSize = true;
            this.messageLab.Location = new System.Drawing.Point(338, 81);
            this.messageLab.Name = "messageLab";
            this.messageLab.Size = new System.Drawing.Size(24, 17);
            this.messageLab.TabIndex = 17;
            this.messageLab.Text = "    ";
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(463, 81);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 23);
            this.endButton.TabIndex = 18;
            this.endButton.Text = "End";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Visible = false;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 427);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.messageLab);
            this.Controls.Add(this.projectLab);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.timeNow);
            this.Controls.Add(this.messageTextbox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.time);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectTextBox);
            this.Controls.Add(this.ProjectLabel);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Time Track By Muhammad Khan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.TextBox ProjectTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageTextbox;
        private System.Windows.Forms.Label timeNow;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label projectLab;
        private System.Windows.Forms.Label messageLab;
        private System.Windows.Forms.Button endButton;
    }
}

