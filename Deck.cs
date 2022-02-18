using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*********************  DECK CLASS  *****************************/


namespace Poker
{
    internal class Deck
    {
        Random rnd = new Random();

        string[] cardsArr = new string[52]
        {"ACE CLUB", "ACE DIAMOND", "ACE HEART", "ACE SPADE",
        "2 CLUB", "2 DIAMOND", "2 HEART", "2 SPADE",
        "3 CLUB", "3 DIAMOND", "3 HEART", "3 SPADE",
        "4 CLUB", "4 DIAMOND", "4 HEART", "4 SPADE",
        "5 CLUB", "5 DIAMOND", "5 HEART", "5 SPADE",
        "6 CLUB", "6 DIAMOND", "6 HEART", "6 SPADE",
        "7 CLUB", "7 DIAMOND", "7 HEART", "7 SPADE",
        "8 CLUB", "8 DIAMOND", "8 HEART", "8 SPADE",
        "9 CLUB", "9 DIAMOND", "9 HEART", "9 SPADE",
        "10 CLUB", "10 DIAMOND", "10 HEART", "10 SPADE",
        "JACK CLUB", "JACK DIAMOND", "JACK HEART", "JACK SPADE",
        "QUEEN CLUB", "QUEEN DIAMOND", "QUEEN HEART", "QUEEN SPADE",
        "KING CLUB", "KING DIAMOND", "KING HEART", "KING SPADE",
        };


        public void ShuffleCards()
        {
            string temp;
            int randomNum1, randomNum2;
            for (int i = 0; i < 100; i++)
            {
                randomNum1 = rnd.Next(cardsArr.Length);
                randomNum2 = rnd.Next(cardsArr.Length);
                temp = cardsArr[randomNum1];
                cardsArr[randomNum1] = cardsArr[randomNum2];
                cardsArr[randomNum2] = temp;
            }
        }

    }
}
