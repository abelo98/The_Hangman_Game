namespace HangmanLogic.Library.GameActions
{
    public interface IGameLogic
    {
        bool CheckLetterChosen(string letter);
        bool CheckLossCondition();
        bool CheckVictoryCondition();
        void Initialize(string word, int lifes);
        void Play(string letter);
        void Show();
    }
}