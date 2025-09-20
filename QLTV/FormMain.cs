namespace QLTV
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void QuanLySachToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dangxuatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void QLSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            QLSach uc = new QLSach();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);

            QLSach
        }

        private void qlSach1_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void docgiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            QLDocGia uc = new QLDocGia();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void muontraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            QLMuonTra uc = new QLMuonTra();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void baocaothongkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            BaoCaoThongKe uc = new BaoCaoThongKe();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void gioithieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            GioiThieu uc = new GioiThieu();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "B?n có ch?c ch?n mu?n thoát không?",
                "Thông Báo!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }
    }
}
