﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LopPTUD2022_sang
{
    public partial class Frmmain : Form
    {

        public Frmmain()
        {
            InitializeComponent();
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status1.Text = "Hello World";
            Form1 f = new Form1();
            f.ShowDialog();
            Status1.Text = "Sẵn sàng nhận lệnh";
        }

        private void tínhTổngSốChẵnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmmain f = new Frmmain();
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Frmmain_Load(object sender, EventArgs e)
        {

        }

        private void kếtThúcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngNhậpLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Status2.Text = System.DateTime.Now.ToString(); 
        }

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMHH f = new frmDMHH();
            f.Show();
        }
    }
}
