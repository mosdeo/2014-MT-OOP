using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4___WinForm_Getting_start
{
    public partial class Form1 : Form
    {
        CardDeck Carddeck;

        public Form1()
        {
            InitializeComponent();
            Carddeck = new CardDeck(); //已經自動初始化, 跟新買的牌一樣
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 == comboBox1.SelectedIndex/*按花色排列*/)
                txt_Message.AppendText("comboBox 按花色排列 已被選定"+"\n");
            if (1 == comboBox1.SelectedIndex/*按大小排列*/)
                txt_Message.AppendText("comboBox 按大小排列 已被選定" + "\n");
            if (2 == comboBox1.SelectedIndex/*亂數洗牌*/  )
                txt_Message.AppendText("comboBox 亂數洗牌 已被選定" + "\n");
        }

        private void btn_ComboBox_Test_Click(object sender, EventArgs e)
        {
            String messageString = null;

            if (0 == comboBox1.SelectedIndex/*按花色排列*/)Carddeck.SortBySuit();
            if (1 == comboBox1.SelectedIndex/*按大小排列*/)Carddeck.SortByRank();
            if (2 == comboBox1.SelectedIndex/*亂數洗牌*/  )Carddeck.Shuffle();

            for (int i = 0; i < Carddeck.Cards.Length; i++)
            {//產生顯示用字串
                messageString +=
                    (Carddeck.Cards[i].Rank == (10 | 12) ? " " : "　") +
                    Carddeck.Cards[i].RankToStr() +
                    Carddeck.Cards[i].SuitToUnicode() +
                    (0 == (i + 1) % 13 ? "\n" : "");
            }

            MessageBox.Show(messageString);
        }

        

        

        private void chk_SortBy_Suit_CheckedChanged(object sender, EventArgs e)
        {//按花色排列
            Chk_CheckedChanged();
        }

        private void chk_SortBy_Rank_CheckedChanged(object sender, EventArgs e)
        {//按點數排列
            Chk_CheckedChanged();
        }

        private void chk_SortBy_Rand_CheckedChanged(object sender, EventArgs e)
        {
            Chk_CheckedChanged();
        }

        private void Chk_CheckedChanged()
        {
            if (true == chk_SortBy_Suit.Checked/*按花色排列*/)
                txt_Message.AppendText("comboBox 按花色排列 已被選定" + "\n");
            if (true == chk_SortBy_Rank.Checked/*按大小排列*/)
                txt_Message.AppendText("comboBox 按大小排列 已被選定" + "\n");
            if (true == chk_SortBy_Rand.Checked/*亂數洗牌*/  )
                txt_Message.AppendText("comboBox 亂數洗牌 已被選定" + "\n");
        }

        private void btn_CheckBox_Test_Click(object sender, EventArgs e)
        {
            if (0 == comboBox1.SelectedIndex/*按花色排列*/) Carddeck.SortBySuit();
            if (1 == comboBox1.SelectedIndex/*按大小排列*/) Carddeck.SortByRank();
            if (2 == comboBox1.SelectedIndex/*亂數洗牌*/  ) Carddeck.Shuffle();

            String messageString = null;

            for (int i = 0; i < Carddeck.Cards.Length; i++)
            {//產生顯示用字串
                messageString +=
                    (Carddeck.Cards[i].Rank == (10|12) ? " " : "　") +
                    Carddeck.Cards[i].RankToStr() +
                    Carddeck.Cards[i].SuitToUnicode() +
                    ( 0 == (i + 1) % 13 ? "\n" : "");
            }

            MessageBox.Show(messageString);
        }

    }
}
