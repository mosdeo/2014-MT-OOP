using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4___WinForm_Getting_start
{
    class PokerCard
    {
        public int Rank;  //點數
        public int Suit;  //花色

        private static string[] strRank = new string[13] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        public string RankToStr()  //將點數轉為字串
        {
            return strRank[Rank];
        }

        public char SuitToAscii()  //將花色轉為 Ascii 字元碼
        {
            return (char)Suit;
        }

        public String SuitToUnicode()  //將花色轉為 Ascii 字元碼
        {
            switch(Suit)
            {
                case 3: return "\u2660"; break;
                case 4: return "\u2663"; break;
                case 5: return "\u2666"; break;
                case 6: return "\u2665"; break;
            }

            return "ERROR";
        }
    }

    class CardDeck
    {
        public PokerCard[] Cards;

        public CardDeck()
        {
            Cards = new PokerCard[52];
            CreateDeck();
            ResetDeck();
        }

        public void CreateDeck() //產生出52個PokerCard的物件
        {
            for (int i = 0; i < 52; i++)
            {
                Cards[i] = new PokerCard();
            }
        }

        public void ResetDeck() //牌堆回復原始狀態
        {
            for (int i = 0; i < 52; i++)
            {
                Cards[i].Rank = i % 13;
                Cards[i].Suit = (i / 13) + 3;
            }
        }

        public void Shuffle() //洗牌
        {
            PokerCard TempCard;
            Random rand = new Random();

            for (int i = 0; i < 52; i++)
            {
                int A = rand.Next(52);
                TempCard = Cards[A];
                Cards[A] = Cards[i];
                Cards[i] = TempCard;
            }
        }

        public void SortByRank()
        {
            for (int i = 0; i < Cards.Length - 1; i++)
            {
                for (int j = 0; i + j < Cards.Length; j++)
                {
                    if (Cards[i].Rank > Cards[i + j].Rank)
                        Swap(ref Cards[i], ref Cards[i + j]);
                }
            }
        }

        public void SortBySuit()
        {
            for (int i = 0; i < Cards.Length - 1; i++)
            {
                for (int j = 0; i + j < Cards.Length; j++)
                {
                    if (Cards[i].Suit > Cards[i + j].Suit)
                        Swap(ref Cards[i], ref Cards[i + j]);
                }
            }
        }

        private static void Swap(ref PokerCard Card_A, ref PokerCard Card_B)
        {
            PokerCard TempCard;

            TempCard = Card_A;
            Card_A = Card_B;
            Card_B = TempCard;
        }
    }

    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]

        

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }
}
