namespace QLTV
{
    partial class FormMain
    {
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Tùy bạn muốn làm gì khi click menu
            MessageBox.Show($"Bạn vừa click: {e.ClickedItem.Text}");
        }
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
            menuStrip2 = new MenuStrip();
            QLSachToolStripMenuItem = new ToolStripMenuItem();
            docgiaToolStripMenuItem = new ToolStripMenuItem();
            muontraToolStripMenuItem = new ToolStripMenuItem();
            baocaothongkeToolStripMenuItem = new ToolStripMenuItem();
            gioithieuToolStripMenuItem = new ToolStripMenuItem();
            dangxuatToolStripMenuItem = new ToolStripMenuItem();
            panelMain = new Panel();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.White;
            menuStrip2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { QLSachToolStripMenuItem, docgiaToolStripMenuItem, muontraToolStripMenuItem, baocaothongkeToolStripMenuItem, gioithieuToolStripMenuItem, dangxuatToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(982, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // QLSachToolStripMenuItem
            // 
            QLSachToolStripMenuItem.Name = "QLSachToolStripMenuItem";
            QLSachToolStripMenuItem.Size = new Size(115, 24);
            QLSachToolStripMenuItem.Text = "Quản Lý Sách";
            QLSachToolStripMenuItem.Click += QLSachToolStripMenuItem_Click;
            // 
            // docgiaToolStripMenuItem
            // 
            docgiaToolStripMenuItem.Name = "docgiaToolStripMenuItem";
            docgiaToolStripMenuItem.Size = new Size(80, 24);
            docgiaToolStripMenuItem.Text = "Độc Giả ";
            docgiaToolStripMenuItem.Click += docgiaToolStripMenuItem_Click;
            // 
            // muontraToolStripMenuItem
            // 
            muontraToolStripMenuItem.Name = "muontraToolStripMenuItem";
            muontraToolStripMenuItem.Size = new Size(93, 24);
            muontraToolStripMenuItem.Text = "Mượn Trả ";
            muontraToolStripMenuItem.Click += muontraToolStripMenuItem_Click;
            // 
            // baocaothongkeToolStripMenuItem
            // 
            baocaothongkeToolStripMenuItem.Name = "baocaothongkeToolStripMenuItem";
            baocaothongkeToolStripMenuItem.Size = new Size(148, 24);
            baocaothongkeToolStripMenuItem.Text = "Báo Cáo Thống Kê";
            baocaothongkeToolStripMenuItem.Click += baocaothongkeToolStripMenuItem_Click;
            // 
            // gioithieuToolStripMenuItem
            // 
            gioithieuToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gioithieuToolStripMenuItem.Name = "gioithieuToolStripMenuItem";
            gioithieuToolStripMenuItem.Size = new Size(92, 24);
            gioithieuToolStripMenuItem.Text = "Giới Thiệu";
            gioithieuToolStripMenuItem.TextImageRelation = TextImageRelation.TextBeforeImage;
            gioithieuToolStripMenuItem.Click += gioithieuToolStripMenuItem_Click;
            // 
            // dangxuatToolStripMenuItem
            // 
            dangxuatToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dangxuatToolStripMenuItem.Name = "dangxuatToolStripMenuItem";
            dangxuatToolStripMenuItem.Size = new Size(95, 24);
            dangxuatToolStripMenuItem.Text = "Đăng Xuất";
            dangxuatToolStripMenuItem.Click += dangxuatToolStripMenuItem_Click_1;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            panelMain.Location = new Point(0, 31);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(982, 773);
            panelMain.TabIndex = 2;
            panelMain.Paint += panel1_Paint;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(982, 802);
            Controls.Add(panelMain);
            Controls.Add(menuStrip2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Thư Viện";
            FormClosing += FormMain_FormClosing;
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem QLSachToolStripMenuItem;
        private ToolStripMenuItem docgiaToolStripMenuItem;
        private ToolStripMenuItem muontraToolStripMenuItem;
        private ToolStripMenuItem baocaothongkeToolStripMenuItem;
        private ToolStripMenuItem gioithieuToolStripMenuItem;
        private ToolStripMenuItem dangxuatToolStripMenuItem;
        private Panel panelMain;
    }
}
