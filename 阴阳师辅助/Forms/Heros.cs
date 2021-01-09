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

namespace 阴阳师辅助.Forms
{
    public partial class Heros : Form
    {
        public Heros()
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
                dataGridView1.DataSource = MySQLiteClass.Getsqliteset("select * from Hero where 式神名称='" + heroName + "'", "Hero").Tables[0];
            }
            else if (heroName == "" && heroLevel != "")
            {
                dataGridView1.DataSource = MySQLiteClass.Getsqliteset("select * from Hero where 稀有度='" + heroLevel + "'", "Hero").Tables[0];
            }
            else
            {
                dataGridView1.DataSource = MySQLiteClass.Getsqliteset("select * from Hero", "Hero").Tables[0];
            }
            MySQLiteClass.Getsqlitecon().Close();
            式神名称textBox.Text = "";
            稀有度comboBox.Text = null;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
        }

        Image image = null;
        private void 详细信息button_Click(object sender, EventArgs e)
        {           
            if (dataGridView1.CurrentRow!=null)
            {
                //获取所有属性
                姓名label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                攻击textBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                生命textBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                防御textBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                速度textBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                暴击textBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString() + "%";
                暴击伤害textBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString() + "%";
                效果命中textBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString() + "%";
                效果抵抗textBox.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString() + "%";
                觉醒技能textBox.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                //获取头像

                if(null != image)
                {
                    image.Dispose();
                }
                image= Image.FromFile(@"" + str1 + "\\Images\\" + 姓名label1.Text + ".png");
                pictureBox1.Image = image;
 
                //获取技能说明
                技能一tabPage.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                技能一richTextBox.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                技能二tabPage.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                技能二richTextBox.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                技能三tabPage.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                技能三richTextBox.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();

                //计算攻击等级
                if ((int)dataGridView1.CurrentRow.Cells[2].Value >= 142)
                {
                    攻击label1.Text = "S";
                    攻击label1.ForeColor = Color.Gold;
                }
                else if (142 > (int)dataGridView1.CurrentRow.Cells[2].Value && (int)dataGridView1.CurrentRow.Cells[2].Value >= 125)
                {
                    攻击label1.Text = "A";
                    攻击label1.ForeColor = Color.Purple;
                }
                else if (125 > (int)dataGridView1.CurrentRow.Cells[2].Value && (int)dataGridView1.CurrentRow.Cells[2].Value >= 110)
                {
                    攻击label1.Text = "B";
                    攻击label1.ForeColor = Color.Blue;
                }
                else
                {
                    攻击label1.Text = "C";
                    攻击label1.ForeColor = Color.Green;
                }

                //计算生命等级
                if ((int)dataGridView1.CurrentRow.Cells[3].Value >= 1180)
                {
                    生命label1.Text = "S";
                    生命label1.ForeColor = Color.Gold;
                }
                else if (1180 > (int)dataGridView1.CurrentRow.Cells[3].Value && (int)dataGridView1.CurrentRow.Cells[3].Value >= 1050)
                {
                    生命label1.Text = "A";
                    生命label1.ForeColor = Color.Purple;
                }
                else if (1050 > (int)dataGridView1.CurrentRow.Cells[3].Value && (int)dataGridView1.CurrentRow.Cells[3].Value >= 951)
                {
                    生命label1.Text = "B";
                    生命label1.ForeColor = Color.Blue;
                }
                else
                {
                    生命label1.Text = "C";
                    生命label1.ForeColor = Color.Green;
                }

                //计算防御等级
                if ((int)dataGridView1.CurrentRow.Cells[4].Value >= 82)
                {
                    防御label1.Text = "S";
                    防御label1.ForeColor = Color.Gold;
                }
                else if (82 > (int)dataGridView1.CurrentRow.Cells[4].Value && (int)dataGridView1.CurrentRow.Cells[4].Value >= 75)
                {
                    防御label1.Text = "A";
                    防御label1.ForeColor = Color.Purple;
                }
                else if (75 > (int)dataGridView1.CurrentRow.Cells[4].Value && (int)dataGridView1.CurrentRow.Cells[4].Value >= 70)
                {
                    防御label1.Text = "B";
                    防御label1.ForeColor = Color.Blue;
                }
                else
                {
                    防御label1.Text = "C";
                    防御label1.ForeColor = Color.Green;
                }

                //计算速度等级
                if ((int)dataGridView1.CurrentRow.Cells[5].Value >= 110)
                {
                    速度label1.Text = "S";
                    速度label1.ForeColor = Color.Gold;
                }
                else if (110 > (int)dataGridView1.CurrentRow.Cells[5].Value && (int)dataGridView1.CurrentRow.Cells[5].Value >= 105)
                {
                    速度label1.Text = "A";
                    速度label1.ForeColor = Color.Purple;
                }
                else if (105 > (int)dataGridView1.CurrentRow.Cells[5].Value && (int)dataGridView1.CurrentRow.Cells[5].Value >= 100)
                {
                    速度label1.Text = "B";
                    速度label1.ForeColor = Color.Blue;
                }
                else
                {
                    速度label1.Text = "C";
                    速度label1.ForeColor = Color.Green;
                }

                //计算暴击等级
                if ((int)dataGridView1.CurrentRow.Cells[6].Value >= 10)
                {
                    暴击label1.Text = "S";
                    暴击label1.ForeColor = Color.Gold;
                }
                else if (10 > (int)dataGridView1.CurrentRow.Cells[6].Value && (int)dataGridView1.CurrentRow.Cells[6].Value >= 8)
                {
                    暴击label1.Text = "A";
                    暴击label1.ForeColor = Color.Purple;
                }
                else if (8 > (int)dataGridView1.CurrentRow.Cells[6].Value && (int)dataGridView1.CurrentRow.Cells[6].Value >= 5)
                {
                    暴击label1.Text = "B";
                    暴击label1.ForeColor = Color.Blue;
                }
                else
                {
                    暴击label1.Text = "C";
                    暴击label1.ForeColor = Color.Green;
                }
            }
            
        }

        private void Heros_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.BackgroundImage.Dispose();
            GC.Collect();
            this.Dispose();
        }
    }
}
