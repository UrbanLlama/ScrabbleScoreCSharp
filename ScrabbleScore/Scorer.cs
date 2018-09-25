namespace ScrabbleScore
{
    class Scorer
    {

        public int GetScore(string word)
        {
            int score = 0;
            int modifier = 1;

            for (int n = 0; n < word.Length; n++)
            {
                if (word[n] == 2 && n == word.Length)
                {
                    score *= 2;
                }
                else
                if (word[n] == 3 && n == word.Length)
                {
                    score *= 3;
                }
                else
                    if (word[n] == 2)
                {
                    modifier = 2;
                }
                else
                if (word[n] == 3)
                {
                    modifier = 3;
                }
                else
                {
                    score = modifier * GetLetterScore(word[n]);

                    modifier = 1;
                }
            }

            return score;
        }

        public int GetLetterScore(char letter)
        {
            //TODO добавить алфавиты и вычисление стоимости буквы
            return 0;
        }
    }
}
