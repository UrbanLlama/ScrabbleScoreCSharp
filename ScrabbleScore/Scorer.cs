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
                if ((word[n] == '2') && (n == word.Length -1))
                {
                    score *= 2;
                }
                else
                if ((word[n] == '3') && (n == word.Length - 1))
                {
                    score *= 3;
                }
                else
                    if (word[n] == '2')
                {
                    modifier = 2;
                }
                else
                if (word[n] == '3')
                {
                    modifier = 3;
                }
                else
                {
                    score += modifier * GetLetterScore(word[n]);

                    modifier = 1;
                }
            }

            return score;
        }

        public int GetLetterScore(char letter)
        {
            char[] letters = {'E', 'A', 'I', 'O', 'N', 'R', 'T', 'L', 'S', 'U',
                                    'D', 'G', 'B', 'C', 'M', 'P', 'F', 'H', 'V', 'W', 'Y',
                                    'K', 'J', 'X', 'Q', 'Z'};

            int[] scores = {1,1,1,1,1,1,1,1,1,1, 2,2, 3,3,3,3, 4,4,4,4,4, 5, 8,8, 10,10};

            int index = 0;

            while (letters[index] != letter)
            {
                index += 1;
            };

            return scores[index];
        }
    }
}
