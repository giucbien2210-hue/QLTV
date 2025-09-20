namespace QLTV
{
    partial class QLDocGia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDocGia = new TextBox();
            textnameDG = new TextBox();
            label10 = new Label();
            label9 = new Label();
            dataGridView2 = new DataGridView();
            btnReset = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDocGia
            // 
            txtDocGia.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            txtDocGia.Location = new Point(163, 103);
            txtDocGia.Multiline = true;
            txtDocGia.Name = "txtDocGia";
            txtDocGia.Size = new Size(244, 53);
            txtDocGia.TabIndex = 18;
            // 
            // textnameDG
            // 
            textnameDG.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            textnameDG.Location = new Point(163, 3);
            textnameDG.Multiline = true;
            textnameDG.Name = "textnameDG";
            textnameDG.Size = new Size(244, 51);
            textnameDG.TabIndex = 17;
            textnameDG.TextChanged += textnameDG_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            label10.Location = new Point(3, 103);
            label10.Name = "label10";
            label10.Size = new Size(87, 16);
            label10.TabIndex = 16;
            label10.Text = "Mã Độc Giả";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            label9.Location = new Point(3, 5);
            label9.Name = "label9";
            label9.Size = new Size(93, 16);
            label9.TabIndex = 15;
            label9.Text = "Tên Độc Giả";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(453, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(649, 773);
            dataGridView2.TabIndex = 14;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            btnReset.Location = new Point(42, 670);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(116, 70);
            btnReset.TabIndex = 13;
            btnReset.Text = "Làm Mới";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            label1.Location = new Point(3, 208);
            label1.Name = "label1";
            label1.Size = new Size(60, 16);
            label1.TabIndex = 20;
            label1.Text = "Ghi Chú";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            textBox1.Location = new Point(163, 205);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 154);
            textBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            button1.Location = new Point(292, 670);
            button1.Name = "button1";
            button1.Size = new Size(116, 70);
            button1.TabIndex = 22;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            button2.Location = new Point(292, 559);
            button2.Name = "button2";
            button2.Size = new Size(116, 70);
            button2.TabIndex = 23;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            button3.Location = new Point(42, 559);
            button3.Name = "button3";
            button3.Size = new Size(116, 70);
            button3.TabIndex = 24;
            button3.Text = "Thêm";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            groupBox1.Location = new Point(42, 455);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 69);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 21);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(298, 42);
            textBox2.TabIndex = 0;
            // 
            // QLDocGia
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtDocGia);
            Controls.Add(textnameDG);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dataGridView2);
            Controls.Add(btnReset);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "QLDocGia";
            Size = new Size(1105, 773);
            Load += QLDocGia_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDocGia;
        private TextBox textnameDG;
        private Label label10;
        private Label label9;
        private DataGridView dataGridView2;
        private Button btnReset;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private TextBox textBox2;
    }
}
