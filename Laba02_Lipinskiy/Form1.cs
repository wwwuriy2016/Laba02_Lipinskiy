using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba02_Lipinskiy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_XOR_Click(object sender, EventArgs e)
        {
            string strP = textBox_P.Text;
            int intP = Convert.ToInt32(strP, 16);
            string strKey = textBox_Key.Text;
            int intKey = Convert.ToInt32(strKey, 16);

            int intC = intP ^ intKey;
            string strC = Convert.ToString(intC, 16);
            textBox_C.Text = strC;

            // 2-ге завдання
            // У 2-му форматі
            string strP2 = Convert.ToString(intP, 2);
            label_P_2.Text = strP2;
            string strKey2 = Convert.ToString(intKey, 2);
            label_Key_2.Text = strKey2;
            string strC2 = Convert.ToString(intC, 2);
            label_C_2.Text = strC2;

            // У 10-му форматі
            string strP10 = Convert.ToString(intP, 10);
            label_P_10.Text = strP10;
            string strKey10 = Convert.ToString(intKey, 10);
            label_Key_10.Text = strKey10;
            string strC10 = Convert.ToString(intC, 10);
            label_C_10.Text = strC10;

            // У 16-му форматі
            string strP16 = Convert.ToString(intP, 16);
            label_P_16.Text = strP16;
            string strKey16 = Convert.ToString(intKey, 16);
            label_Key_16.Text = strKey16;
            string strC16 = Convert.ToString(intC, 16);
            label_C_16.Text = strC16;

            // 3-тє завдання
            textBox_C2.Text = textBox_C.Text;
            textBox_Key2.Text = textBox_Key.Text;
            textBox_P2.Text = textBox_P.Text;           
        }      

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_Key.Text = "";
            textBox_C.Text = "";
            label_P_16.Text = "";
            label_Key_16.Text = "";
            label_C_16.Text = "";
            label_C_10.Text = "";
            label_Key_10.Text = "";
            label_P_10.Text = "";
            label_C_2.Text = "";
            label_Key_2.Text = "";
            label_P_2.Text = "";
            textBox_P2.Text = "";
            textBox_Key2.Text = "";
            textBox_C2.Text = "";
        }
    }
}
