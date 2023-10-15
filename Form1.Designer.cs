namespace DependAppInstaller
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
            this.logBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.idaCheck = new System.Windows.Forms.CheckBox();
            this.vs2022Check = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ceCheck = new System.Windows.Forms.CheckBox();
            this.hxdCheck = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aioCheck = new System.Windows.Forms.CheckBox();
            this.discCheck = new System.Windows.Forms.CheckBox();
            this.installBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.Enabled = false;
            this.logBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBox.Location = new System.Drawing.Point(296, 40);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ShortcutsEnabled = false;
            this.logBox.Size = new System.Drawing.Size(332, 491);
            this.logBox.TabIndex = 0;
            this.logBox.Text = "Select at least one package.";
            this.logBox.TextChanged += new System.EventHandler(this.logBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "About";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripItem_Click);
            // 
            // idaCheck
            // 
            this.idaCheck.AutoSize = true;
            this.idaCheck.Location = new System.Drawing.Point(6, 42);
            this.idaCheck.Name = "idaCheck";
            this.idaCheck.Size = new System.Drawing.Size(61, 18);
            this.idaCheck.TabIndex = 2;
            this.idaCheck.Text = "IDA Pro";
            this.idaCheck.UseVisualStyleBackColor = true;
            this.idaCheck.CheckedChanged += new System.EventHandler(this.selectionCheckBox);
            // 
            // vs2022Check
            // 
            this.vs2022Check.AutoSize = true;
            this.vs2022Check.Location = new System.Drawing.Point(6, 19);
            this.vs2022Check.Name = "vs2022Check";
            this.vs2022Check.Size = new System.Drawing.Size(116, 18);
            this.vs2022Check.TabIndex = 3;
            this.vs2022Check.Text = "Visual Studio 2022";
            this.vs2022Check.UseVisualStyleBackColor = true;
            this.vs2022Check.CheckedChanged += new System.EventHandler(this.selectionCheckBox);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.ceCheck);
            this.groupBox1.Controls.Add(this.hxdCheck);
            this.groupBox1.Controls.Add(this.idaCheck);
            this.groupBox1.Controls.Add(this.vs2022Check);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 265);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // ceCheck
            // 
            this.ceCheck.AutoSize = true;
            this.ceCheck.Location = new System.Drawing.Point(6, 88);
            this.ceCheck.Name = "ceCheck";
            this.ceCheck.Size = new System.Drawing.Size(89, 18);
            this.ceCheck.TabIndex = 5;
            this.ceCheck.Text = "Cheat Engine";
            this.ceCheck.UseVisualStyleBackColor = true;
            this.ceCheck.CheckedChanged += new System.EventHandler(this.selectionCheckBox);
            // 
            // hxdCheck
            // 
            this.hxdCheck.AutoSize = true;
            this.hxdCheck.Location = new System.Drawing.Point(6, 65);
            this.hxdCheck.Name = "hxdCheck";
            this.hxdCheck.Size = new System.Drawing.Size(46, 18);
            this.hxdCheck.TabIndex = 4;
            this.hxdCheck.Text = "HxD";
            this.hxdCheck.UseVisualStyleBackColor = true;
            this.hxdCheck.CheckedChanged += new System.EventHandler(this.selectionCheckBox);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aioCheck);
            this.groupBox2.Controls.Add(this.discCheck);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 265);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Others";
            // 
            // aioCheck
            // 
            this.aioCheck.AutoSize = true;
            this.aioCheck.Location = new System.Drawing.Point(6, 19);
            this.aioCheck.Name = "aioCheck";
            this.aioCheck.Size = new System.Drawing.Size(91, 18);
            this.aioCheck.TabIndex = 2;
            this.aioCheck.Text = "AIO Runtimes";
            this.aioCheck.UseVisualStyleBackColor = true;
            this.aioCheck.CheckedChanged += new System.EventHandler(this.selectionCheckBox);
            // 
            // discCheck
            // 
            this.discCheck.AutoSize = true;
            this.discCheck.Location = new System.Drawing.Point(6, 43);
            this.discCheck.Name = "discCheck";
            this.discCheck.Size = new System.Drawing.Size(63, 18);
            this.discCheck.TabIndex = 3;
            this.discCheck.Text = "Discord";
            this.discCheck.UseVisualStyleBackColor = true;
            this.discCheck.CheckedChanged += new System.EventHandler(this.selectionCheckBox);
            // 
            // installBtn
            // 
            this.installBtn.Enabled = false;
            this.installBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installBtn.Location = new System.Drawing.Point(296, 537);
            this.installBtn.Name = "installBtn";
            this.installBtn.Size = new System.Drawing.Size(332, 23);
            this.installBtn.TabIndex = 6;
            this.installBtn.Text = "Install";
            this.installBtn.UseVisualStyleBackColor = true;
            this.installBtn.Click += new System.EventHandler(this.installBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 112);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 18);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "GitHub Desktop";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.selectionCheckBox);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 583);
            this.Controls.Add(this.installBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.CheckBox idaCheck;
        private System.Windows.Forms.CheckBox vs2022Check;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox aioCheck;
        private System.Windows.Forms.CheckBox discCheck;
        private System.Windows.Forms.CheckBox hxdCheck;
        private System.Windows.Forms.CheckBox ceCheck;
        private System.Windows.Forms.Button installBtn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

