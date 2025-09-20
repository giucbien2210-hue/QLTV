using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class BaoCaoThongKe : UserControl
    {
        public BaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;   // Hiển thị ảnh gốc, nếu to quá thì bị tràn
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; // Ép vừa khít khung nhưng có thể bị méo
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;     // Vừa khít khung, giữ nguyên tỉ lệ, không bị méo, không mất ảnh
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage; // Ảnh nằm giữa, không co dãn
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize; // Tự giãn kích thước PictureBox = kích thước ảnh

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;   // Hiển thị ảnh gốc, nếu to quá thì bị tràn
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; // Ép vừa khít khung nhưng có thể bị méo
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;     // Vừa khít khung, giữ nguyên tỉ lệ, không bị méo, không mất ảnh
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage; // Ảnh nằm giữa, không co dãn
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize; // Tự gi
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;   // Hiển thị ảnh gốc, nếu to quá thì bị tràn
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; // Ép vừa khít khung nhưng có thể bị méo
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;     // Vừa khít khung, giữ nguyên tỉ lệ, không bị méo, không mất ảnh
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage; // Ảnh nằm giữa, không co dãn
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize; // Tự gi
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
