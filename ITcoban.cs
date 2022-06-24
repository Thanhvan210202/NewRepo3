using System;
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
    public partial class ITcoban : Form
    {
        int i, n, T; 
        public ITcoban()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = Convert.ToUInt16(txtn.Text);
            T = 0;
            i = 1;
            while (i <= n)
            {
                if (i % 2 == 0)
                {
                    T = T + i;
                }
                i++;
            }
            txtlKQ.Text = " Kết quả tính theo While là: " + Convert.ToString(T);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtn.Text);
            T = 0;
            do
            {
                if (i % 2 == 0)
                {
                    T = T + i;
                }
                i++;
            }
            while (i <= n);
            txtlKQ.Text = " Kết quả tính theo Do while là: " + Convert.ToString(T);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); //this.Close(0
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtn.Text);// chuyển đổi sang dạng số.
            T = 0;
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    T = T + i; // hoặc viết T += i
                }
            }
            txtlKQ.Text = " Kết quả tính theo for là: " + Convert.ToString(T);
            // biến số thành chữ bằng câu lệnh convert.Totring(T). 
        }
    }
}
