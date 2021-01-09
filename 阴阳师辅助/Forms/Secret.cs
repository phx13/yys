using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 阴阳师辅助.Forms
{
    public partial class Secret : Form
    {
        public Secret()
        {
            InitializeComponent();
        }

        static string str1 = System.Windows.Forms.Application.StartupPath;

        Size size = new Size(270, 150);

        private void 山兔大暴走pictureBox_Click(object sender, EventArgs e)
        {
            Point point = new Point(19, 31);
            if (山兔大暴走pictureBox.Size == size && 山兔大暴走pictureBox.Location == point)
            {
                pictureBox1.Visible = true;
                pictureBox1.BackgroundImage = new Bitmap(@"" + str1 + "\\Images\\山兔大暴走2.png");
                pictureBox1.BringToFront();
            }
        }

        private void 红叶的羁绊pictureBox_Click(object sender, EventArgs e)
        {
            Point point = new Point(306, 31);
            if (红叶的羁绊pictureBox.Size == size && 红叶的羁绊pictureBox.Location == point)
            {
                pictureBox1.Visible = true;
                pictureBox1.BackgroundImage = new Bitmap(@"" + str1 + "\\Images\\红叶的羁绊2.png");
                pictureBox1.BringToFront();
            }
        }

        private void 妖刀之秘籍pictureBox_Click(object sender, EventArgs e)
        {
            Point point = new Point(594, 31);
            if (妖刀之秘籍pictureBox.Size == size && 妖刀之秘籍pictureBox.Location == point)
            {
                pictureBox1.Visible = true;
                pictureBox1.BackgroundImage = new Bitmap(@"" + str1 + "\\Images\\妖刀之秘籍2.png");
                pictureBox1.BringToFront();
            }
        }

        private void 河畔童谣pictureBox_Click(object sender, EventArgs e)
        {
            Point point = new Point(19, 216);
            if (河畔童谣pictureBox.Size == size && 河畔童谣pictureBox.Location == point)
            {
                pictureBox1.Visible = true;
                pictureBox1.BackgroundImage = new Bitmap(@"" + str1 + "\\Images\\河畔童谣2.png");
                pictureBox1.BringToFront();
            }
        }

        private void 雨女的等候pictureBox_Click(object sender, EventArgs e)
        {
            Point point = new Point(306, 216);
            if (雨女的等候pictureBox.Size == size && 雨女的等候pictureBox.Location == point)
            {
                pictureBox1.Visible = true;
                pictureBox1.BackgroundImage = new Bitmap(@"" + str1 + "\\Images\\雨女的等候2.png");
                pictureBox1.BringToFront();
            }
        }

        private void 荒川之怒pictureBox_Click(object sender, EventArgs e)
        {
            Point point = new Point(594, 216);
            if (荒川之怒pictureBox.Size == size && 荒川之怒pictureBox.Location == point)
            {
                pictureBox1.Visible = true;
                pictureBox1.BackgroundImage = new Bitmap(@"" + str1 + "\\Images\\荒川之怒2.png");
                pictureBox1.BringToFront();
            }
        }

        private void 暴风之巅pictureBox_Click(object sender, EventArgs e)
        {
            Point point = new Point(19, 399);
            if (暴风之巅pictureBox.Size == size && 暴风之巅pictureBox.Location == point)
            {
                pictureBox1.Visible = true;
                pictureBox1.BackgroundImage = new Bitmap(@"" + str1 + "\\Images\\暴风之巅2.png");
                pictureBox1.BringToFront();
            }
        }

        private void 伞剑的守护pictureBox_Click(object sender, EventArgs e)
        {
            Point point = new Point(306, 399);
            if (伞剑的守护pictureBox.Size == size && 伞剑的守护pictureBox.Location == point)
            {
                pictureBox1.Visible = true;
                pictureBox1.BackgroundImage = new Bitmap(@"" + str1 + "\\Images\\伞剑的守护2.png");
                pictureBox1.BringToFront();
            }
        }

        private void 夏之风物诗pictureBox_Click(object sender, EventArgs e)
        {            
            Point point = new Point(594, 399);
            if (夏之风物诗pictureBox.Size == size && 夏之风物诗pictureBox.Location == point)
            {
                pictureBox1.Visible = true;
                pictureBox1.BackgroundImage = new Bitmap(@"" + str1 + "\\Images\\夏之风物诗2.png");
                pictureBox1.BringToFront();
            }           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage.Dispose();
            pictureBox1.Visible = false;
        }

        private void Secret_FormClosing(object sender, FormClosingEventArgs e)
        {
            山兔大暴走pictureBox.BackgroundImage.Dispose();
            红叶的羁绊pictureBox.BackgroundImage.Dispose();
            妖刀之秘籍pictureBox.BackgroundImage.Dispose();
            河畔童谣pictureBox.BackgroundImage.Dispose();
            雨女的等候pictureBox.BackgroundImage.Dispose();
            荒川之怒pictureBox.BackgroundImage.Dispose();
            暴风之巅pictureBox.BackgroundImage.Dispose();
            伞剑的守护pictureBox.BackgroundImage.Dispose();
            夏之风物诗pictureBox.BackgroundImage.Dispose();
            this.BackgroundImage.Dispose();
            GC.Collect();
            this.Dispose();
        }
    }
}
