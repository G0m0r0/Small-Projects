namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.somethinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.something2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gsdgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gddsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gsdgToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "but";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(193, 124);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "titleeee";
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Red;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somethinToolStripMenuItem,
            this.something2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(366, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // somethinToolStripMenuItem
            // 
            this.somethinToolStripMenuItem.Name = "somethinToolStripMenuItem";
            this.somethinToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.somethinToolStripMenuItem.Text = "somethin";
            // 
            // something2ToolStripMenuItem
            // 
            this.something2ToolStripMenuItem.Name = "something2ToolStripMenuItem";
            this.something2ToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.something2ToolStripMenuItem.Text = "something 2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gsdgToolStripMenuItem,
            this.gddsToolStripMenuItem,
            this.gsdgToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // gsdgToolStripMenuItem
            // 
            this.gsdgToolStripMenuItem.Name = "gsdgToolStripMenuItem";
            this.gsdgToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.gsdgToolStripMenuItem.Text = "gsdg";
            // 
            // gddsToolStripMenuItem
            // 
            this.gddsToolStripMenuItem.Name = "gddsToolStripMenuItem";
            this.gddsToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.gddsToolStripMenuItem.Text = "gdds";
            // 
            // gsdgToolStripMenuItem1
            // 
            this.gsdgToolStripMenuItem1.Name = "gsdgToolStripMenuItem1";
            this.gsdgToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.gsdgToolStripMenuItem1.Text = "gsdg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 322);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem somethinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem something2ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gsdgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gddsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gsdgToolStripMenuItem1;
    }
}

