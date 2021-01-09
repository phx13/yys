using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 阴阳师辅助
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        int index = 0;
        static string str1 = System.Windows.Forms.Application.StartupPath;
        Image img1 = Image.FromFile(@"" + str1 + "\\Images\\封面图1.jpg");
        Image img2 = Image.FromFile(@"" + str1 + "\\Images\\封面图2.jpg");
        Image img3 = Image.FromFile(@"" + str1 + "\\Images\\封面图3.jpg");    

        private void 封面图timer_Tick(object sender, EventArgs e)
        {
            if ((index++)%3==0)
            {
                封面图pictureBox.Image = img1;
            }
            else if ((index++) % 3 == 1)
            {
                封面图pictureBox.Image = img2;
            }
            else
            {
                封面图pictureBox.Image = img3;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            封面图timer.Interval = 2000;
            封面图timer.Start();
        }
        private void 官网pictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://yys.163.com/index.html");
        }

        private void NGApictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.ngacn.cc/thread.php?fid=538&rand=876");
        }

        private void pictureBox18183_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.18183.com/yys");
        }

        public void 式神信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyClass.ShowForm("式神信息");
        }

        public void 式神攻略ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyClass.ShowForm("式神攻略");
        }

        private void 悬赏封印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyClass.ShowForm("悬赏封印");
        }

        private void 秘闻副本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyClass.ShowForm("秘闻副本");
        }
    }
}
