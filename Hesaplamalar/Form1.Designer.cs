namespace Hesaplamalar
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.menuStrip_menu = new System.Windows.Forms.MenuStrip();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hızToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_menu
            // 
            this.menuStrip_menu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip_menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem,
            this.hızToolStripMenuItem,
            this.hakkımdaToolStripMenuItem});
            this.menuStrip_menu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_menu.Name = "menuStrip_menu";
            this.menuStrip_menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip_menu.Size = new System.Drawing.Size(1466, 24);
            this.menuStrip_menu.TabIndex = 0;
            this.menuStrip_menu.Text = "menuStrip1";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            // 
            // hızToolStripMenuItem
            // 
            this.hızToolStripMenuItem.Name = "hızToolStripMenuItem";
            this.hızToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.hızToolStripMenuItem.Text = "Hız-Yol-Zaman-Hesaplama";
            // 
            // hakkımdaToolStripMenuItem
            // 
            this.hakkımdaToolStripMenuItem.Name = "hakkımdaToolStripMenuItem";
            this.hakkımdaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hakkımdaToolStripMenuItem.Text = "Hakkımda";
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1466, 736);
            this.Controls.Add(this.menuStrip_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "anasayfa";
            this.Text = "Hesaplamar";
            this.menuStrip_menu.ResumeLayout(false);
            this.menuStrip_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip_menu;
        private ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private ToolStripMenuItem hızToolStripMenuItem;
        private ToolStripMenuItem hakkımdaToolStripMenuItem;
    }
}