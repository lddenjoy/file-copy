namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.btnSelectDest = new System.Windows.Forms.Button();
            this.txtDestFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labCurrentCopy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "源文件夹：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(133, 47);
            this.txtSourceFolder.Multiline = true;
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(275, 33);
            this.txtSourceFolder.TabIndex = 1;
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Location = new System.Drawing.Point(442, 48);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(75, 30);
            this.btnSelectSource.TabIndex = 2;
            this.btnSelectSource.Text = "选取";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // btnSelectDest
            // 
            this.btnSelectDest.Location = new System.Drawing.Point(442, 112);
            this.btnSelectDest.Name = "btnSelectDest";
            this.btnSelectDest.Size = new System.Drawing.Size(75, 30);
            this.btnSelectDest.TabIndex = 5;
            this.btnSelectDest.Text = "选取";
            this.btnSelectDest.UseVisualStyleBackColor = true;
            this.btnSelectDest.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDestFolder
            // 
            this.txtDestFolder.Location = new System.Drawing.Point(133, 111);
            this.txtDestFolder.Multiline = true;
            this.txtDestFolder.Name = "txtDestFolder";
            this.txtDestFolder.Size = new System.Drawing.Size(275, 33);
            this.txtDestFolder.TabIndex = 4;
            this.txtDestFolder.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "目标文件夹：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(133, 260);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(275, 35);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "开始复制";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "正在复制：";
            // 
            // labCurrentCopy
            // 
            this.labCurrentCopy.Location = new System.Drawing.Point(130, 194);
            this.labCurrentCopy.Name = "labCurrentCopy";
            this.labCurrentCopy.Size = new System.Drawing.Size(384, 25);
            this.labCurrentCopy.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 337);
            this.Controls.Add(this.labCurrentCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSelectDest);
            this.Controls.Add(this.txtDestFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectSource);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Files Copy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.Button btnSelectDest;
        private System.Windows.Forms.TextBox txtDestFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labCurrentCopy;
    }
}

