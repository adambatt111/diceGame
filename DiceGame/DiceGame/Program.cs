using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Game
    {
        
        static void Main(string[] args)
        {
            // the first player to reach a score of 50 wins


            /*
            Player playerOne = new Player("Adam");
            playerOne.printName();
            do
            {
                diceOne.throwDice(ran);
                playerOne.Score += diceOne.Die;
                playerOne.ThrowCount++;
                playerOne.printScore();
                playerOne.checkScore();

            } while (playerOne.Won == false);

            playerOne.printThrow();
            */
            ConsoleKeyInfo info = new ConsoleKeyInfo();
            Random ran = new Random();

            Dice diceOne = new Dice();
            Dice diceTwo = new Dice();
            Dice diceThree = new Dice();
            Dice diceFour = new Dice();
            Dice diceFive = new Dice();


            GameInstruction();
            EnterNameInstruction("first");
            Player playerOne = new Player(Console.ReadLine());
            EnterNameInstruction("second");
            Player playerTwo = new Player(Console.ReadLine());
            Console.WriteLine();

            // get the playerOne to roll dice
            IsPressed(playerOne, info, ran, diceOne, diceTwo, diceThree, diceFour, diceFive);
            // Check to see if player has rolled two of the same die, if they have they can roll the two dice again
            TwoOfSame(info, ran, diceOne, diceTwo, diceThree, diceFour, diceFive); // need to assign a score to the player but will come back to this
            // Check to see if player has rolled three of the same die, if they do then assign the player 3 points


        }
        public static void GameInstruction()
        {
            Console.WriteLine("Instructions for playing the two player dice game: ");
            Console.WriteLine();
            Console.WriteLine("Players take turns rolling five dice and score for three-of-a-kind or better.\nIf a player only has two-ofa-kind, " +
            "they may re-throw the remaining dice in\nan attempt to improve the remaining dice values. If " +
            "no matching numbers are\nrolled after two rolls, the player scores 0. ");
            Console.WriteLine();
            Console.WriteLine("Scoring: ");
            Console.WriteLine();
            Console.WriteLine("3-of-a-kind: 3 points");
            Console.WriteLine("4-of-a-kind: 6 points");
            Console.WriteLine("5-of-a-kind: 12 points");
            Console.WriteLine();
            Console.WriteLine("The first player who reaches a value of 50 is the winner.");
            Console.WriteLine();
        }
        public static void EnterNameInstruction(string _playerNum)
        {
            Console.WriteLine("Please enter " + _playerNum + " player's name and press Enter.");
        }

        public static void IsPressed(Player _player, ConsoleKeyInfo _info, Random _ran, Dice _diceOne, Dice _diceTwo, Dice _diceThree, Dice _diceFour, Dice _diceFive)
        {
            Console.WriteLine(_player.Name + " please press Enter to throw ...");
            _info = Console.ReadKey();
            if(_info.Key.Equals(ConsoleKey.Enter))
            {
                _diceOne.ThrowDice(_ran);
                _diceTwo.ThrowDice(_ran);
                _diceThree.ThrowDice(_ran);
                _diceFour.ThrowDice(_ran);
                _diceFive.ThrowDice(_ran);

                _diceOne.PrintDice();
                _diceTwo.PrintDice();
                _diceThree.PrintDice();
                _diceFour.PrintDice();
                _diceFive.PrintDice();
            }
        }
        // Compares Two Dice against each one

        public static void TwoOfSame(ConsoleKeyInfo _info, Random _ran, Dice _diceOne, Dice _diceTwo, Dice _diceThree, Dice _diceFour, Dice _diceFive) 
        {
            
            if ((_diceOne.Die == _diceTwo.Die) && (_diceOne.Die != _diceThree.Die && _diceOne.Die != _diceFour.Die && _diceOne.Die != _diceFive.Die)) 
            {
                Console.WriteLine("Please roll again by pressing Enter as the first dice number, " + _diceOne.Die + " equals the second dice number " + _diceTwo.Die + " ...");
                _info = Console.ReadKey();
                if (_info.Key.Equals(ConsoleKey.Enter))
                {
                    _diceOne.ThrowDice(_ran);
                    _diceTwo.ThrowDice(_ran);

                    _diceOne.PrintDice();
                    _diceTwo.PrintDice();

                    return;
                }
            } // done
            
            if ((_diceOne.Die == _diceFour.Die) && (_diceOne.Die != _diceTwo.Die && _diceOne.Die != _diceThree.Die && _diceOne.Die != _diceFive.Die)) 
            {
                Console.WriteLine("Please roll again by pressing Enter as the first dice number, " + _diceOne.Die + " equals the fourth dice number " + _diceFour.Die + " ...");
                _info = Console.ReadKey();
                if (_info.Key.Equals(ConsoleKey.Enter))
                {
                    _diceOne.ThrowDice(_ran);
                    _diceFour.ThrowDice(_ran);

                    _diceOne.PrintDice();
                    _diceFour.PrintDice();

                    return;
                }
            } // done

           
            
            if((_diceOne.Die == _diceFive.Die) && (_diceOne.Die != _diceTwo.Die && _diceOne.Die != _diceThree.Die && _diceOne.Die != _diceFour.Die)) 
            {
                Console.WriteLine("Please roll again by pressing Enter as the first dice number, " + _diceOne.Die + " equals the fifth dice number " + _diceFive.Die + " ...");
                _info = Console.ReadKey();
                if (_info.Key.Equals(ConsoleKey.Enter))
                {
                    _diceOne.ThrowDice(_ran);
                    _diceFive.ThrowDice(_ran);

                    _diceOne.PrintDice();
                    _diceFive.PrintDice();

                    return;
                }
            } // done

            if ((_diceTwo.Die == _diceThree.Die) && (_diceTwo.Die != _diceOne.Die && _diceTwo.Die != _diceFour.Die && _diceTwo.Die != _diceFive.Die)) 
            {
                Console.WriteLine("Please roll again by pressing Enter as the second dice number, " + _diceTwo.Die + " equals the third dice number " + _diceThree.Die + " ...");
                _info = Console.ReadKey();
                if (_info.Key.Equals(ConsoleKey.Enter))
                {
                    _diceTwo.ThrowDice(_ran);
                    _diceThree.ThrowDice(_ran);

                    _diceTwo.PrintDice();
                    _diceThree.PrintDice();

                    return;
                }
            } // done

            if ((_diceTwo.Die == _diceFour.Die) && (_diceTwo.Die != _diceOne.Die && _diceTwo.Die != _diceThree.Die && _diceTwo.Die != _diceFive.Die)) 
            {
                Console.WriteLine("Please roll again by pressing Enter as the second dice number, " + _diceTwo.Die + " equals the fourth dice number " + _diceFour.Die + " ...");
                _info = Console.ReadKey();
                if (_info.Key.Equals(ConsoleKey.Enter))
                {
                    _diceTwo.ThrowDice(_ran);
                    _diceFour.ThrowDice(_ran);

                    _diceTwo.PrintDice();
                    _diceFour.PrintDice();

                    return;
                }
            } // done
            
            if ((_diceTwo.Die == _diceFive.Die) && (_diceTwo.Die != _diceOne.Die && _diceTwo.Die != _diceThree.Die && _diceTwo.Die != _diceFour.Die)) 
            {
                Console.WriteLine("Please roll again by pressing Enter as the second dice number, " + _diceTwo.Die + " equals the fifth dice number " + _diceFive.Die + " ...");
                _info = Console.ReadKey();
                if (_info.Key.Equals(ConsoleKey.Enter))
                {
                    _diceTwo.ThrowDice(_ran);
                    _diceFive.ThrowDice(_ran);

                    _diceTwo.PrintDice();
                    _diceFive.PrintDice();

                    return;
                }
            } // done
           
            if ((_diceThree.Die == _diceOne.Die) && (_diceThree.Die != _diceTwo.Die && _diceThree.Die != _diceFour.Die && _diceThree.Die != _diceFive.Die)) 
            {
                Console.WriteLine("Please roll again by pressing Enter as the third dice number, " + _diceThree.Die + " equals the first dice number " + _diceOne.Die + " ...");
                _info = Console.ReadKey();
                if (_info.Key.Equals(ConsoleKey.Enter))
                {
                    _diceThree.ThrowDice(_ran);
                    _diceOne.ThrowDice(_ran);

                    _diceThree.PrintDice();
                    _diceOne.PrintDice();

                    return;
                }
            } // done

            if((_diceThree.Die == _diceFour.Die) && (_diceThree.Die != _diceOne.Die && _diceThree.Die != _diceTwo.Die && _diceThree.Die != _diceFive.Die)) 
            {
                Console.WriteLine("Please roll again by pressing Enter as the third dice number, " + _diceThree.Die + " equals the Fourth dice number " + _diceFour.Die + " ...");
                _info = Console.ReadKey();
                if (_info.Key.Equals(ConsoleKey.Enter))
                {
                    _diceThree.ThrowDice(_ran);
                    _diceFour.ThrowDice(_ran);

                    _diceThree.PrintDice();
                    _diceFour.PrintDice();

                    return;
                }
            } // done
            
            if ((_diceThree.Die == _diceFive.Die) && (_diceThree.Die != _diceOne.Die && _diceThree.Die != _diceTwo.Die && _diceThree.Die != _diceFour.Die))
            {
                Console.WriteLine("Please roll again by pressing Enter as the third dice number, " + _diceThree.Die + " equals the fifth dice number " + _diceFive.Die + " ...");
                _info = Console.ReadKey();
                if (_info.Key.Equals(ConsoleKey.Enter))
                {
                    _diceThree.ThrowDice(_ran);
                    _diceFive.ThrowDice(_ran);

                    _diceThree.PrintDice();
                    _diceFive.PrintDice();

                    return;
                } 
            } // done
            
            if ((_diceFour.Die == _diceFive.Die) && (_diceFour.Die != _diceOne.Die && _diceFour.Die != _diceTwo.Die && _diceFour.Die != _diceThree.Die)) 
            {
                Console.WriteLine("Please roll again by pressing Enter as the fourth dice number, " + _diceFour.Die + " equals the fifth dice number " + _diceFive.Die + " ...");
                _info = Console.ReadKey();
                if (_info.Key.Equals(ConsoleKey.Enter))
                {
                    _diceFour.ThrowDice(_ran);
                    _diceFive.ThrowDice(_ran);

                    _diceFour.PrintDice();
                    _diceFive.PrintDice();

                    return;
                }
            } // done
        } // done

        // // Compares three dice against each one
        public static void ThreeOfSame(Player _player, Dice _diceOne, Dice _diceTwo, Dice _diceThree, Dice _diceFour, Dice _diceFive)
        {
            
            if ((_diceOne.Die == _diceTwo.Die && _diceOne.Die == _diceThree.Die) && (_diceOne != _diceFour && _diceOne != _diceFive)) // done
            {
                _player.Score += 3;
                Console.WriteLine(_player.Name + " earned 3 points.");

                return;
            }

            if ((_diceTwo.Die == _diceThree.Die && _diceTwo.Die == _diceFour.Die) && (_diceTwo != _diceFive && _diceTwo != _diceOne)) // done
            {
                _player.Score += 3;
                Console.WriteLine(_player.Name + " earned 3 points.");

                return;
            }

            if ((_diceThree.Die == _diceFour.Die && _diceThree.Die == _diceFive.Die) && (_diceThree != _diceOne && _diceThree != _diceTwo)) // done
            {
                _player.Score += 3;
                Console.WriteLine(_player.Name + " earned 3 points.");

                return;
            }

            if ((_diceFour.Die == _diceFive.Die && _diceFour.Die == _diceOne.Die) && (_diceFour != _diceTwo && _diceFour != _diceThree)) // done
            {
                _player.Score += 3;
                Console.WriteLine(_player.Name + " earned 3 points.");

                return;
            }


            if ((_diceFive.Die == _diceOne.Die && _diceFive.Die == _diceTwo.Die) && (_diceFive != _diceThree && _diceFive != _diceFour)) // done
            {
                _player.Score += 3;
                Console.WriteLine(_player.Name + " earned 3 points.");

                return;
            }
        }

        // Compares four dice against each one
        public static void FourOfSame(Player _player, Dice _diceOne, Dice _diceTwo, Dice _diceThree, Dice _diceFour, Dice _diceFive)
        {
            if ((_diceOne.Die == _diceTwo.Die && _diceOne.Die == _diceThree.Die && _diceOne.Die == _diceFour.Die) && (_diceOne != _diceFive)) // done
            {
                _player.Score += 6;
                Console.WriteLine(_player.Name + " earned 6 points.");

                return;
            }

            if ((_diceTwo.Die == _diceThree.Die && _diceTwo.Die == _diceFour.Die && _diceTwo.Die == _diceFive.Die) && (_diceTwo != _diceOne)) // done
            {
                _player.Score += 6;
                Console.WriteLine(_player.Name + " earned 6 points.");

                return;
            }

            if ((_diceThree.Die == _diceFour.Die && _diceThree.Die == _diceFive.Die && _diceThree.Die == _diceOne.Die) && (_diceThree != _diceTwo)) // done
            {
                _player.Score += 6;
                Console.WriteLine(_player.Name + " earned 6 points.");

                return;
            }

            if ((_diceFour.Die == _diceFive.Die && _diceFour.Die == _diceOne.Die && _diceFour.Die == _diceTwo.Die) && (_diceFour != _diceThree)) // done
            {
                _player.Score += 6;
                Console.WriteLine(_player.Name + " earned 6 points.");

                return;
            }

            if ((_diceFive.Die == _diceOne.Die && _diceFive.Die == _diceTwo.Die && _diceFive.Die == _diceThree.Die) && (_diceFive != _diceFour)) // done
            {
                _player.Score += 6;
                Console.WriteLine(_player.Name + " earned 6 points.");

                return;
            }
        }

        // if person gets five of the same die then assign 12 points to the player and print the points earned
        public static void FiveOfSame(Player _player, Dice _diceOne, Dice _diceTwo, Dice _diceThree, Dice _diceFour, Dice _diceFive)
        {
            if ((_diceOne.Die == _diceTwo.Die && _diceOne.Die == _diceThree.Die && _diceOne.Die == _diceFour.Die && _diceOne == _diceFive)) // done
            {
                _player.Score += 12;
                Console.WriteLine(_player.Name + " earned 12 points.");

                return;
            }

            if ((_diceTwo.Die == _diceThree.Die && _diceTwo.Die == _diceFour.Die && _diceTwo.Die == _diceFive.Die && _diceTwo == _diceOne)) // done
            {
                _player.Score += 12;
                Console.WriteLine(_player.Name + " earned 12 points.");

                return;
            }

            if ((_diceThree.Die == _diceFour.Die && _diceThree.Die == _diceFive.Die && _diceThree.Die == _diceOne.Die && _diceThree == _diceTwo)) // done
            {
                _player.Score += 12;
                Console.WriteLine(_player.Name + " earned 12 points.");

                return;
            }

            if ((_diceFour.Die == _diceFive.Die && _diceFour.Die == _diceOne.Die && _diceFour.Die == _diceTwo.Die && _diceFour == _diceThree)) // done
            {
                _player.Score += 12;
                Console.WriteLine(_player.Name + " earned 12 points.");

                return;
            }

            if ((_diceFive.Die == _diceOne.Die && _diceFive.Die == _diceTwo.Die && _diceFive.Die == _diceThree.Die && _diceFive == _diceFour)) // done
            {
                _player.Score += 12;
                Console.WriteLine(_player.Name + " earned 12 points.");

                return;
            }

        }
    }

    public class Player
    {
        private string name;
        private int score;
        private bool won;
        private int throwCount;

        public Player(string _name)
        {
            Name = _name;
            Score = 0;
            Won = false;
            ThrowCount = 0;
        }

        public string Name
        {
            get { return name; }
            set
            {
                this.name = value;
            }
        }

        public int Score
        {
            get { return score; }
            set
            {
                this.score = value;
            }
        }

        public bool Won
        {
            get { return won; }
            set
            {
                this.won = value;
            }
        }

        public int ThrowCount
        {
            get { return throwCount; }
            set
            {
                this.throwCount = value;
            }
        }

        public void CheckScore()
        {
            if (Score >= 50)
            {
                Won = true;
                Console.WriteLine(Name + ", you have won with a score of " + Score + ".");
            }
        }

        public void PrintScore()
        {
            Console.WriteLine(Name + "'s" + " score is " + Score);
        }

        public void PrintName()
        {
            Console.WriteLine(Name);
        }

        public void PrintThrow()
        {
            Console.WriteLine(Name + " has thrown " + ThrowCount + " times.");
        }
        
    }

    public class Dice
    {
        private int die;


        public Dice()
        {
            Die = -1;
        }

        public int Die
        {
            get { return die; }
            set
            {
                this.die = value;
            }
        }
        public void ThrowDice(Random _rand) // always pass random from main
        {
            Die = _rand.Next(1, 7);
        }
        public void PrintDice()
        {
            Console.WriteLine("You threw an " + Die);
        }
    }
}
    

