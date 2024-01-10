using System;
using System.IO.Pipes;
using System.Linq;
using System.Media;
namespace TestGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayMusic("Ebi-Harighe-Sabz.wav");
            Console.WriteLine("Playing music");
            Console.ReadLine();

            Random rand = new Random();
            int computerGuess = rand.Next();
            int life = 10;

            Console.WriteLine("Plz Enter Your Guess");
            int uSer = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Plz Enter Your Guess");
            }
            while (uSer is string);

            while (true)
            {
                for (int i = 0; i <= life; i++)
                {
                   if(life - i < 3)
                    {
                        Console.ResetColor();
                        if (uSer == computerGuess)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Nice Job You guessed it in {i} times");
                        }
                        else if (uSer > computerGuess)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Your Guess is higher");
                            Console.WriteLine($"You have {life - i} chances left!!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Your Guess is lower");
                            Console.WriteLine($"You have {life - i} chances left!!");
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Do you nedd any Help? yes/no");
                        Console.WriteLine("Choose between A,B,C");
                        string answer = Console.ReadLine();
                        if (answer == "A")
                        {
                            int life_mini = 3;
                            Random random = new Random();
                            string userMove = "";
                            string a = "Paper";
                            string b = "Scissors";
                            string c = "Rock";
                            string[] moves = { "Rock", "Paper", "Scissors" };
                            Console.WriteLine("Rock , Paper, Scissor Game!! , Plz Pick one");
                            userMove = Console.ReadLine();
                            int cGG = random.Next(moves.Length);
                            string cG = moves[cGG];
                            for (int j = 0; j < life_mini; j++)
                            {
                                if (cG == "Rock" && userMove == "Paper")
                                {
                                    Console.WriteLine("You Won");
                                    Console.WriteLine("Your move was Paper and Computer was Rock!");
                                }
                                else if (cG == "Rock" && userMove == "Scissors")
                                {
                                    Console.WriteLine("Computer Won");
                                    Console.WriteLine("Your move was Scissors and Computer was Rock!");
                                    Console.WriteLine($"You have {life_mini - 1} lives left" );
                                }
                                else if (cG == "Paper" && userMove == "Rock")
                                {
                                    Console.WriteLine("Computer Won");
                                    Console.WriteLine("Your move was Rock and Computer was Paper!");
                                    Console.WriteLine($"You have {life_mini - 1} lives left");
                                }
                                else if (cG == "Paper" && userMove == "Scissors")
                                {
                                    Console.WriteLine("You Won");
                                    Console.WriteLine("Your move was Sissors and Computer was Paper!");
                                    Console.WriteLine($"You have {life_mini - 1} lives left");
                                }
                                else if (cG == "Scissors" && userMove == "Rock")
                                {
                                    Console.WriteLine("You Won");
                                    Console.WriteLine("Your move was Rock and Computer was Scissors!");
                                    Console.WriteLine($"You have {life_mini - 1} lives left");
                                }
                                else if (cG == "Scissors" && userMove == "Paper")
                                {
                                    Console.WriteLine("Computer Won");
                                    Console.WriteLine("Your move was Paper and Computer was Scissors!");
                                    Console.WriteLine($"You have {life_mini - 1} lives left");
                                }
                                else
                                {
                                    Console.WriteLine("Picked Equal");
                                    Console.WriteLine($"You have {life_mini - 1} lives left");
                                }
                            }
                            // inja migim az beyne abc yeki ro entekhab kon harkodumesh ye noe bazi hast
                            // horuf aval hazf
                            // adade zojo fard
                            // behesh mixe adad ro midim ba 2 ta jun
                            // migim kodumash dorost bud va kodumash nabud
                            // bayad inja ye method dige dorost kard
                        }else if(answer == "B")
                        {
                            int life2 = 3;
                            Console.WriteLine("Welcome You choosed Guess the Number!");
                            Random random = new Random();
                            string guessNum = random.Next(1000, 5000).ToString();
                            int length = guessNum.Length;
                            Console.WriteLine($"The number we choosed has {length} digits");
                            //-----------------------------------------
                            //string strNum = guessNum.ToString();

                            //var charList = strNum.ToCharArray().ToList();

                            //int intGuessNum = int.Parse(guessNum);
                            //----------------------------------------
                            string puzzleNum = guessNum.Replace(guessNum[2], '#').Replace(guessNum[guessNum.Length - 1], '#');
                            for(int k = 0; k < life2; k++)
                            {

                            }
                        }
                        else
                        {

                        }

                    }
                }
                Console.ReadKey();
            }
        }


       
        


        // Ebi-Harighe-Sabz
        /// <summary>
        /// Music player Method
        /// </summary>
        /// <param name="filepath"> behesh migim ke music kojast
        /// mesle gharar dadane cd tuye cd player -- bin/debug</param>
        public static void PlayMusic(string filepath)
        {
            SoundPlayer musicPlayer = new SoundPlayer(); //Creating sound Player object
            musicPlayer.SoundLocation = filepath;
            musicPlayer.Play();
        }

        public static object HardMode()
        {
            int life = 10;
            Random rand = new Random();
            int ComputerGuess = rand.Next(500, 9999);
            Console.WriteLine("You choose th HARD MODE!\nThere will be Help BUT\n There are CONSEQUENCES!!!");
        }

        public static MiniGame_A()
        {
            int life = 10;
            Random rand = new Random();
            int ComputerGuess = rand.Next(500, 9999);
            Console.WriteLine("You choose th HARD MODE!\nThere will be Help BUT\n There are CONSEQUENCES!!!");

        }
        public static void MiniGame_B()
        {


        }
        public static void MiniGame_C()
        {
            
        }

        public static object NormalMode()
        {
            int life = 15;
            Random rand = new Random();
            int ComputerGuess = rand.Next(100, 1000);
        }

        public static object EasyMode()
        {
            int life = 20;
            Random rand = new Random();
            int ComputerGuess = rand.Next(100, 500);
        }

        
    }

    

    
}
