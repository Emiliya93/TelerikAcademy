namespace CatConcert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FindTheMinimalNumberOfSongs
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int cats = GetNumberFromString(input);
            
            input = Console.ReadLine();
            int songs = GetNumberFromString(input);

            // Rows -> songs
            // Cols -> cats
            int[,] grafic = new int[songs, cats];

            while ((input = Console.ReadLine()) != "Mew!")
            {
                int[] indexes = GetTwoNumbersFromString(input);
                int catIndex = indexes[0];
                int songIndex = indexes[1];
                grafic[songIndex - 1, catIndex - 1] += 1;
            }

            // Get sumOfSongsCatKnow
            int[] songsCatKnow = new int[cats];
            
            // bool twoCatsOneSong = false;
            for (int col = 0; col < grafic.GetLength(1); col++)
            {
                // Cats
                for (int row = 0; row < grafic.GetLength(0); row++)
                {
                    // Songs
                    songsCatKnow[col] += grafic[row, col];
                }

                if (songsCatKnow[col] == 0)
                {
                    Console.WriteLine("No concert!");
                    return;
                }
            }

            // Get sumOfSongs some or all cats know
            int[] songsAllCats = new int[songs];
            bool oneSongFull = false;

            for (int row = 0; row < grafic.GetLength(0); row++)
            {
                // Songs
                for (int col = 0; col < grafic.GetLength(1); col++)
                {
                    // Cats
                    songsAllCats[row] += grafic[row, col];

                    if (grafic[row, col] == 0)
                    {
                        oneSongFull = false;
                    }
                    else
                    {
                        oneSongFull = true;
                    }
                }

                if (oneSongFull)
                {
                    Console.WriteLine(1);
                    return;
                }
            }

            int result = GetMinNumOfSongs(songsAllCats, cats);
            Console.WriteLine(result);
        }

        private static int GetMinNumOfSongs(int[] songsAllCats, int cats)
        {
            // sumOfAllSongsAllCatsKnow
            int sumOfAllSongs = SumOfArray(songsAllCats);

            if (sumOfAllSongs == cats)
            {
                if (songsAllCats.Any(x => x > 1))
                {
                    DecreaseSong(songsAllCats);
                    sumOfAllSongs = GetMinNumOfSongs(songsAllCats, cats);
                }
                else
                {
                    // Consider another else if before this else
                   return sumOfAllSongs;
                }
            }
            else if (sumOfAllSongs > cats)
            {
                DecreaseSong(songsAllCats);
                sumOfAllSongs = GetMinNumOfSongs(songsAllCats, cats);
            }

            return sumOfAllSongs;
        }

        private static void DecreaseSong(int[] songsAllCats)
        {
            for (int i = 0; i < songsAllCats.Length; i++)
            {
                if (songsAllCats[i] > 1)
                {
                    songsAllCats[i]--;
                }
            }
        }

        ////static void DecreaseCat(int col, )
        ////{

        ////    if (col == grafic.GetLength(1) - 1)
        ////    {
        ////        if (songsCatKnow.Count(x => x > 1) > 0)
        ////        {

        ////        }
        ////    }
        ////}

        private static int SumOfArray(int[] sumOfSongsAllCats)
        {
            int sumOfAllSongs = 0;

            for (int i = 0; i < sumOfSongsAllCats.Length; i++)
            {
                sumOfAllSongs += sumOfSongsAllCats[i];
            }

            return sumOfAllSongs;
        }

        private static int GetNumberFromString(string input)
        {
            int num = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    num *= 10;
                    num += input[i] - '0';
                }
                else
                {
                    break;
                }
            }

            return num;
        }

        private static int[] GetTwoNumbersFromString(string input)
        {
            int[] num = new int[2];
            int index = 0;
            bool isDigit = false;

            for (int i = index; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    isDigit = true;
                    num[0] *= 10;
                    num[0] += input[i] - '0';
                    index = i;
                }
                else if (isDigit)
                {
                    break;
                }
            }

            isDigit = false;

            for (int i = index + 1; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    isDigit = true;
                    num[1] *= 10;
                    num[1] += input[i] - '0';
                    index = i;
                }
                else if (isDigit)
                {
                    break;
                }
            }

            return num;
        }
    }
}
