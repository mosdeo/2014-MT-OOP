using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
{
    class PokerCard
    {
        public int Rank;  //點數
        public int Suit;  //花色
        
        private static string[] strRank = new string[13] {"A","2","3","4","5","6","7","8","9","10","J","Q","K"};

        public string RankToStr()  //將點數轉為字串
        {
            return strRank[Rank];
        }

        public char SuitToAscii()  //將花色轉為 Ascii 字元碼
        {
            return (char)Suit;
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
                Cards[i].Rank = i%13;
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("60132057A 林高遠");
            CardDeck Carddeck = new CardDeck(); //已經自動初始化, 跟新買的牌一樣

            Console.WriteLine("============ 整副撲克牌 ============");
            ShowPoker(ref Carddeck);
            
            while(true)
            {
                Console.WriteLine("============ 洗牌 ============");
                Carddeck.Shuffle();
                ShowPoker(ref Carddeck);

                Console.Write("再洗一次? (Y/N=other):");
                if ("Y" != Console.ReadLine().ToUpper(/*Anti-stupid*/)) break;
            }

            Console.WriteLine("============ 整副撲克牌 ============");
            Carddeck.ResetDeck();
            ShowPoker(ref Carddeck);
            Console.ReadKey();
        }

        static void ShowPoker(ref CardDeck pCarddeck)
        {// Why the function need be static ?
            for (int i = 0; i < 52; i++)
            {
                Console.Write("{0,3}{1} ", pCarddeck.Cards[i].RankToStr(), pCarddeck.Cards[i].SuitToAscii());
                if (0 == (i + 1) % 13) Console.WriteLine("");
            }
        }
    }
}
