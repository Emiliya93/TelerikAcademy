namespace Mines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Mines
    {
        public class Player
        {
            private string name;
            private int points;

            public Player()
            {
            }

            public Player(string name, int points)
            {
                this.Name = name;
                this.Points = points;
            }

            public string Name
            {
                get 
                { 
                    return this.name; 
                }

                private set 
                {
                    this.name = value; 
                }
            }

            public int Points
            {
                get 
                {
                    return this.points; 
                }
                
                private set
                { 
                    this.points = value; 
                }
            }
        }

        // TODO: Refactor Main method
        public static void Main()
        {
            string command = string.Empty;
            char[,] board = InitializeGameBoard();
            char[,] bombs = LoadBombs();
            int pointsCount = 0;
            bool isPlayerOnBomb = false;
            List<Player> champions = new List<Player>(6);
            int row = 0;
            int col = 0;
            bool flag = true;
            const int maks = 35;
            bool flag2 = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    PrintBoard(board);
                    flag = false;
                }
                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= board.GetLength(0) &&
                        col <= board.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        Rating(champions);
                        break;
                    case "restart":
                        board = InitializeGameBoard();
                        bombs = LoadBombs();
                        PrintBoard(board);
                        isPlayerOnBomb = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                PlayerTurn(board, bombs, row, col);
                                pointsCount++;
                            }
                            if (maks == pointsCount)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                PrintBoard(board);
                            }
                        }
                        else
                        {
                            isPlayerOnBomb = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }
                if (isPlayerOnBomb)
                {
                    PrintBoard(bombs);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", pointsCount);
                    string niknejm = Console.ReadLine();
                    Player t = new Player(niknejm, pointsCount);
                    if (champions.Count < 5)
                    {
                        champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < t.Points)
                            {
                                champions.Insert(i, t);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }
                    champions.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
                    Rating(champions);

                    board = InitializeGameBoard();
                    bombs = LoadBombs();
                    pointsCount = 0;
                    isPlayerOnBomb = false;
                    flag = true;
                }
                if (flag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    PrintBoard(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine();
                    Player to4kii = new Player(imeee, pointsCount);
                    champions.Add(to4kii);
                    Rating(champions);
                    board = InitializeGameBoard();
                    bombs = LoadBombs();
                    pointsCount = 0;
                    flag2 = false;
                    flag = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void Rating(List<Player> player)
        {
            Console.WriteLine("\nResults: ");
            if (player.Count > 0)
            {
                for (int i = 0; i < player.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points",
                        i + 1, player[i].Name, player[i].Points);
                }

                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("Empty rating!\n");
            }
        }

        private static void PlayerTurn(char[,] field, char[,] bombs, int row, int col)
        {
            char bombsCount = CountPoints(bombs, row, col);
            bombs[row, col] = bombsCount;
            field[row, col] = bombsCount;
        }

        private static void PrintBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0} ", board[row, col]);
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] InitializeGameBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int row = 0; row < boardRows; row++)
            {
                for (int col = 0; col < boardColumns; col++)
                {
                    board[row, col] = '?';
                }
            }

            return board;
        }

        private static char[,] LoadBombs()
        {
            int boardRows = 5;
            int boardCols = 10;
            char[,] board = new char[boardRows, boardCols];

            for (int row = 0; row < boardRows; row++)
            {
                for (int col = 0; col < boardCols; col++)
                {
                    board[row, col] = '-';
                }
            }

            List<int> randNums = new List<int>();

            while (randNums.Count < 15)
            {
                Random random = new Random();
                int rand = random.Next(50);
                if (!randNums.Contains(rand))
                {
                    randNums.Add(rand);
                }
            }

            foreach (int randNum in randNums)
            {
                int col = (randNum / boardCols);
                int row = (randNum % boardCols);

                if (row == 0 && randNum != 0)
                {
                    col--;
                    row = boardCols;
                }

                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            return board;
        }

        private static void GetPoints(char[,] board)
        {
            int cols = board.GetLength(0);
            int rows = board.GetLength(1);

            for (int row = 0; row < cols; row++)
            {
                for (int col = 0; col < rows; col++)
                {
                    if (board[row, col] != '*')
                    {
                        char pointsCount = CountPoints(board, row, col);
                        board[row, col] = pointsCount;
                    }
                }
            }
        }

        private static char CountPoints(char[,] board, int currentRow, int currentCol)
        {
            int count = 0;
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (board[currentRow - 1, currentCol] == '*')
                {
                    count++;
                }
            }

            if (currentRow + 1 < rows)
            {
                if (board[currentRow + 1, currentCol] == '*')
                {
                    count++;
                }
            }

            if (currentCol - 1 >= 0)
            {
                if (board[currentRow, currentCol - 1] == '*')
                {
                    count++;
                }
            }

            if (currentCol + 1 < cols)
            {
                if (board[currentRow, currentCol + 1] == '*')
                {
                    count++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentCol - 1 >= 0))
            {
                if (board[currentRow - 1, currentCol - 1] == '*')
                {
                    count++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentCol + 1 < cols))
            {
                if (board[currentRow - 1, currentCol + 1] == '*')
                {
                    count++;
                }
            }

            if ((currentRow + 1 < rows) && (currentCol - 1 >= 0))
            {
                if (board[currentRow + 1, currentCol - 1] == '*')
                {
                    count++;
                }
            }

            if ((currentRow + 1 < rows) && (currentCol + 1 < cols))
            {
                if (board[currentRow + 1, currentCol + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}