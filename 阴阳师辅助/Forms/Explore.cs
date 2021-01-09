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
    public partial class Explore : Form
    {
        public Explore()
        {
            InitializeComponent();
        }

        static string str1 = System.Windows.Forms.Application.StartupPath;

        Image img = null;
        private void 式神名称button_Click(object sender, EventArgs e)
        {
            if (式神名称comboBox.Text!=""||线索名称comboBox.Text!="")
            {
                SQLiteDataReader sdr6 = MySQLiteClass.Getmysqlread("select 妖怪 from Explore where 线索 ='" + 线索名称comboBox.Text + "'");
                sdr6.Read();
                string heroName = "";
                if (式神名称comboBox.Text =="" && 线索名称comboBox.Text != "")
                {
                    heroName = sdr6["妖怪"].ToString();
                }
                else
                {
                    heroName = 式神名称comboBox.Text.Substring(2, 式神名称comboBox.Text.Length - 2);
                }
                探索副本richTextBox.Text = "";
                御魂副本richTextBox.Text = "";
                秘闻副本richTextBox.Text = "";
                妖气封印richTextBox.Text = "";
                线索label1.Text = "";
                SQLiteDataReader sdr1 = MySQLiteClass.Getmysqlread("select 探索副本,探索妖怪 from Explore where 探索妖怪 like '%"+heroName+"*%'");
                while (sdr1.Read())
                {
                    探索副本richTextBox.Text += sdr1["探索副本"].ToString()+":"+sdr1["探索妖怪"].ToString()+"\n";
                }
                SQLiteDataReader sdr2 = MySQLiteClass.Getmysqlread("select 御魂副本,御魂妖怪 from Explore where 御魂妖怪 like '%" + heroName + "*%'");
                while (sdr2.Read())
                {
                    御魂副本richTextBox.Text += sdr2["御魂副本"].ToString() + ":" + sdr2["御魂妖怪"].ToString() + "\n";
                }
                SQLiteDataReader sdr3 = MySQLiteClass.Getmysqlread("select 秘闻副本,秘闻妖怪 from Explore where 秘闻妖怪 like '%" + heroName + "*%'");
                while (sdr3.Read())
                {
                    秘闻副本richTextBox.Text += sdr3["秘闻副本"].ToString() + ":" + sdr3["秘闻妖怪"].ToString() + "\n";
                }
                SQLiteDataReader sdr4 = MySQLiteClass.Getmysqlread("select 妖气封印,妖气妖怪 from Explore where 妖气妖怪 like '%" + heroName + "*%'");
                while (sdr4.Read())
                {
                    妖气封印richTextBox.Text += sdr4["妖气封印"].ToString() + ":" + sdr4["妖气妖怪"].ToString() + "\n";
                }
                SQLiteDataReader sdr5 = MySQLiteClass.Getmysqlread("select 线索 from Explore where 妖怪 ='" + heroName + "'");
                while (sdr5.Read())
                {
                    线索label1.Text = sdr5["线索"].ToString();
                }
                MySQLiteClass.Getsqlitecon().Close();

                if (img!=null)
                {
                    img.Dispose();
                }
                img = Image.FromFile(@""+str1+"\\Images\\" + heroName + ".png");//双引号里是图片的路径
                pictureBox1.Image = img;
                姓名label1.Text = heroName;
                式神名称comboBox.Text = null;
                线索名称comboBox.Text = null;
            }           
        }

        private void Explore_FormClosing(object sender, FormClosingEventArgs e)
        {
            查询信息groupBox.BackgroundImage.Dispose();
            this.BackgroundImage.Dispose();
            GC.Collect();
            this.Dispose();
        }
    }
}
