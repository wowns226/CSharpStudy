using System;

namespace ArraySample2
{
    class MainApp
    {
        static void Main()
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[^2] = 90;
            scores[^1] = 34;

            foreach (int score in scroes)
            {
                Console.WriteLine(score);
            }

            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }

            int average = sum / scores.Length;

            Console.WriteLine($"Average Score : {average}");
        }
    }
}