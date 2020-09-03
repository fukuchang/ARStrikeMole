
namespace CommonScript
{
    public static class ScoreManager
    {
        private static int score = 0;

        public static void SaveScore(int _score)
        {
            score = _score;
        }

        public static int GetScore()
        {
            return score;
        }

        public static void ResetScore()
        {
            score = 0;
        }
    }
}