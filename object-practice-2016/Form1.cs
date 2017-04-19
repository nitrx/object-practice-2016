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
        private CTori[] toriObjects;
        private CSakana[] sakanaObjects;

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

            toriObjects = new CTori[TORI_NAMES.Length];
            for (int i = 0; i< TORI_NAMES.Length;i++)
            {
                toriObjects[i] = new CTori(TORI_NAMES[i]);
                textBox1.AppendText("" + i + ":" + TORI_NAMES[i] + "\r\n");
            }

            sakanaObjects = new CSakana[SAKANA_NAMES.Length];
            for (int i = 0; i <SAKANA_NAMES.Length; i++)
            {
                sakanaObjects[i] = new CSakana(SAKANA_NAMES[i]);
                textBox1.AppendText("" + i + ":" + SAKANA_NAMES[i] + "\r\n");
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
            textBox1.AppendText("人は" + CHito.getCount() + "人\r\n");
            textBox1.AppendText("鳥は" + CTori.getCount() + "羽\r\n");
            textBox1.AppendText("魚は" + CSakana.getCount() + "匹\r\n");
            textBox1.AppendText("生き物は" + CIkimono.getIkimonoCount() + "体\r\n");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
