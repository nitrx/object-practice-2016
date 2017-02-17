using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace object_practice_2016
{
    public partial class Form1 : Form
    {
        /** 人の名前*/
        private string[] HITO_NAMES = { "佐藤", "鈴木", "高橋" };
        /** 鳥の名前*/
        private string[] TORI_NAMES = { "スズメ", "カラス", "ハト", "トビ"};
        /** 魚の名前*/
        private string[] SAKANA_NAMES = { "グッピー", "メダカ"};

        private CHito[] hitoObjects;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hitoObjects = new CHito[HITO_NAMES.Length];
            for (int i = 0; i< HITO_NAMES.Length;i++)
            {
                hitoObjects[i] = new CHito(HITO_NAMES[i]);
                //名前リストを表示
                textBox1.AppendText("" + i + ":" + HITO_NAMES[i] + "\r\n");
            }
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            int index = int.Parse(txtIndex.Text);
            textBox1.AppendText(hitoObjects[index].hello() + "\r\n");
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            int index = int.Parse(txtIndex.Text);
            textBox1.AppendText(hitoObjects[index].action() + "\r\n");
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            int index = int.Parse(txtIndex.Text);
            textBox1.AppendText("人は" + hitoObjects[index].getCount() + "人\r\n");
        }
    }
}
