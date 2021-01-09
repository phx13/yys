using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace 阴阳师辅助.Forms
{
    public partial class HeroStrategy : Form
    {
        public HeroStrategy()
        {
            InitializeComponent();
        }

        static string str1 = System.Windows.Forms.Application.StartupPath;

        private void 式神名称button_Click(object sender, EventArgs e)
        {
            string heroName = 式神名称textBox.Text;
            string heroLevel = 稀有度comboBox.Text;
            if (heroName != "")
            {
                dataGridView1.DataSource = MySQLiteClass.Getsqliteset("select * from heroStrategy where 式神名称='" + heroName + "'", "heroStrategy").Tables[0];
            }
            else if (heroName == "" && heroLevel != "")
            {
                dataGridView1.DataSource = MySQLiteClass.Getsqliteset("select * from heroStrategy where 稀有度='" + heroLevel + "'", "heroStrategy").Tables[0];
            }
            else
            {
                dataGridView1.DataSource = MySQLiteClass.Getsqliteset("select * from heroStrategy", "heroStrategy").Tables[0];
            }
            MySQLiteClass.Getsqlitecon().Close();
            式神名称textBox.Text = "";
            稀有度comboBox.Text = null;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
        }

        Image img = null;
        private void 详细信息button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                姓名label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                式神传记richTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                御魂搭配richTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                阵容搭配richTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                if (img!=null)
                {
                    img.Dispose();
                }
                img = Image.FromFile(@"" + str1 + "\\Images\\" + 姓名label1.Text + ".png");//双引号里是图片的路径
                pictureBox1.Image = img;
            }  
        }

        private void HeroStrategy_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.BackgroundImage.Dispose();
            GC.Collect();
            this.Dispose();
        }
    }
}
