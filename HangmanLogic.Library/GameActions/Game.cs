using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanLogic.Library.GameActions
{
    public class Game : IGameLogic
    {


        public void Initialize(string word, int lifes)
        {


        }
        public void Play(string letter)
        {

        }

        public void Show()
        {

        }

        public bool CheckLossCondition() { return false; }

        public bool CheckVictoryCondition() { return false; }

        public bool CheckLetterChosen(string letter) { return false; }
    }
}
