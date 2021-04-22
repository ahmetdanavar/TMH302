
namespace görüntü_işleme_TMH306
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
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pikselAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parlaklıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thersholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ikiGörüntüIşlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pikselAlToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.parlaklıkToolStripMenuItem,
            this.griToolStripMenuItem,
            this.thersholdToolStripMenuItem,
            this.ikiGörüntüIşlemToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "işlemler";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pikselAlToolStripMenuItem
            // 
            this.pikselAlToolStripMenuItem.Name = "pikselAlToolStripMenuItem";
            this.pikselAlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pikselAlToolStripMenuItem.Text = "piksel al";
            this.pikselAlToolStripMenuItem.Click += new System.EventHandler(this.pikselAlToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.invertToolStripMenuItem.Text = "invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // parlaklıkToolStripMenuItem
            // 
            this.parlaklıkToolStripMenuItem.Name = "parlaklıkToolStripMenuItem";
            this.parlaklıkToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.parlaklıkToolStripMenuItem.Text = "parlaklık";
            this.parlaklıkToolStripMenuItem.Click += new System.EventHandler(this.parlaklıkToolStripMenuItem_Click);
            // 
            // griToolStripMenuItem
            // 
            this.griToolStripMenuItem.Name = "griToolStripMenuItem";
            this.griToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.griToolStripMenuItem.Text = "gri";
            this.griToolStripMenuItem.Click += new System.EventHandler(this.griToolStripMenuItem_Click);
            // 
            // thersholdToolStripMenuItem
            // 
            this.thersholdToolStripMenuItem.Name = "thersholdToolStripMenuItem";
            this.thersholdToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thersholdToolStripMenuItem.Text = "threhold";
            this.thersholdToolStripMenuItem.Click += new System.EventHandler(this.thersholdToolStripMenuItem_Click);
            // 
            // ikiGörüntüIşlemToolStripMenuItem
            // 
            this.ikiGörüntüIşlemToolStripMenuItem.Name = "ikiGörüntüIşlemToolStripMenuItem";
            this.ikiGörüntüIşlemToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ikiGörüntüIşlemToolStripMenuItem.Text = "iki görüntü işlem";
            this.ikiGörüntüIşlemToolStripMenuItem.Click += new System.EventHandler(this.ikiGörüntüIşlemToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 590);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pikselAlToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parlaklıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thersholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ikiGörüntüIşlemToolStripMenuItem;
    }
}

