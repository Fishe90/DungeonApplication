using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Monster_Moves
    {
        private int _uses;

        public string Name { get; set; }
        public Monster_Race Type { get; set; }
        public int Damage { get; set; }
        public int MaxUses { get; set; }

        public int Uses
        {
            get { return _uses; }
            set
            {
                _uses = value <= MaxUses ? value : MaxUses;
            }
        }

        public Monster_Moves() { }

        public Monster_Moves(string name, Monster_Race type, int damage, int maxUses, int uses)
        {
            Name = name;
            Type = type;
            Damage = damage;
            MaxUses = maxUses;
            Uses = uses;
        }

        public static Monster_Moves Empty = new Monster_Moves("NAME", Monster_Race.NONE, 0, 0, 0);
        public static Monster_Moves fireEmber = new Monster_Moves("Ember", Monster_Race.Fire, 40, 15, 15);
        public static Monster_Moves waterWaterGun = new Monster_Moves("Watergun", Monster_Race.Water, 40, 15, 15);
        public static Monster_Moves electricThundershock = new Monster_Moves("Thundershock", Monster_Race.Electric, 40, 15, 15);
        public static Monster_Moves groundMudshot = new Monster_Moves("Mudshot", Monster_Race.Ground, 40, 15, 15);
        public static Monster_Moves psychicConfusion = new Monster_Moves("Confusion", Monster_Race.Psychic, 40, 15, 15);

        public static void ANIDefenderMoves(Monster_Moves move, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            //x = 5-75; y = 7-13  
            Console.BackgroundColor = gbBackground;
            if (move.Name == "Ember")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                #region Frames
                string[] FrameOne = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                string[] FrameTwo = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                                ▄▀ ▄▀           ",
                    "                               ▄▀               ",
                    "                                                "
                };
                string[] FrameThree = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                          ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "                        ▄▀  ▄▀ ▄▀               ",
                    "                       ▀ ▄▀                     "
                };
                string[] FrameFour = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                     ▄▀   ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "                  ▄▀ ▄▀ ▄▀  ▄▀ ▄▀               ",
                    "               ▀▄▀ ▄▀ ▄▀ ▄▀                     "
                };
                string[] FrameFive = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                     ▄▀   ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "             ▄▀   ▄▀ ▄▀ ▄▀  ▄▀ ▄▀               ",
                    "      ▄▀ ▄▀ ▄▀▄▀▄▀ ▄▀ ▄▀ ▄▀                     "
                };
                string[] FrameSix = new string[]
                {
                    "                                            ▄ ▄▀",
                    "                                      ▄ ▄ ▄▀ ▀  ",
                    "                               ▄  ▄  █ ▀ ▀      ",
                    "                     ▄    ▄  ▄▀ ▄▀ ▄▀           ",
                    "             ▄    ▄ ▀▄  ▄▀  █  █                ",
                    "      ▄  ▄  █ ▄ ▄▀ ▄▀ ▄▀ ▄ ▀  ▀                 "
                };
                string[] FrameSeven = new string[]
                {
                    "                                             ▄▀▄",
                    "                                          ▄▀▄▀  ",
                    "                                    ▄▀▄▀▄▀      ",
                    "                             ▄▀ ▄▀ ▄▀           ",
                    "                   ▄▀   ▄▀ ▄▀ ▄▀ ▄▀             ",
                    "           ▄▀   ▄▀ ▄▀ ▄▀  ▄▀ ▄▀                 "
                };
                string[] FrameEight = new string[]
                {
                    "                                              ▄▀",
                    "                                          ▄ ▄▀  ",
                    "                                    ▄ ▄ ▄▀ ▀    ",
                    "                             ▄  ▄  █ ▀ ▀        ",
                    "                   ▄    ▄  ▄▀ ▄▀ ▄▀             ",
                    "      ▄▀ ▄▀ ▄   ▄ ▀▄  ▄▀  █  █                  "
                };
                string[] FrameNine = new string[]
                {
                    "                                              ▄▀",
                    "                                          ▄▀▄▀  ",
                    "                                       ▄▀▄▀     ",
                    "                                 ▄▀▄▀▄▀         ",
                    "                          ▄▀ ▄▀ ▄▀              ",
                    "                ▄▀   ▄▀ ▄▀ ▄▀ ▄▀                "
                };
                string[] FrameTen = new string[]
                {
                    "                                            ▄ ▄▀",
                    "                                      ▄ ▄ ▄▀ ▀  ",
                    "                               ▄  ▄  █ ▀ ▀      ",
                    "                     ▄    ▄  ▄▀ ▄▀ ▄▀           ",
                    "             ▄    ▄ ▀▄  ▄▀  █  █                ",
                    "               ▄    ▄  ▄▀ ▄▀ ▄▀                 "
                };
                string[] FrameLast = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                #endregion

                int startX = 7;
                int startY = 10;
                List<string[]> frames = new List<string[]> { FrameOne, FrameTwo, FrameThree, FrameFour };
                List<string[]> frames2 = new List<string[]> { FrameFive, FrameSix, FrameSeven, FrameEight, FrameNine, FrameTen };
                foreach (string[] frame in frames)
                {
                    startX = 7;
                    foreach (string line in frame)
                    {
                        Console.SetCursorPosition(startY, startX);
                        Console.Write(line);
                        startX += 1;
                    }
                    System.Threading.Thread.Sleep(100);
                }
                startX = 7;
                string count = "     ";
                foreach (char item in count)
                {
                    foreach (string[] frame in frames2)
                    {
                        startX = 7;
                        foreach (string line in frame)
                        {
                            Console.SetCursorPosition(startY, startX);
                            Console.Write(line);
                            startX += 1;
                        }
                        System.Threading.Thread.Sleep(100);
                    }
                }
                startX = 7;
                foreach (string line in FrameLast)
                {
                    Console.SetCursorPosition(startY, startX);
                    Console.Write(line);
                    startX += 1;
                }
            }
            if (move.Name == "Watergun")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                #region Frames
                string[] FrameOne = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                string[] FrameTwo = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                                ▄▀ ▄▀           ",
                    "                               ▄▀               ",
                    "                                                "
                };
                string[] FrameThree = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                          ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "                        ▄▀  ▄▀ ▄▀               ",
                    "                       ▀ ▄▀                     "
                };
                string[] FrameFour = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                     ▄▀   ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "                  ▄▀ ▄▀ ▄▀  ▄▀ ▄▀               ",
                    "               ▀▄▀ ▄▀ ▄▀ ▄▀                     "
                };
                string[] FrameFive = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                     ▄▀   ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "             ▄▀   ▄▀ ▄▀ ▄▀  ▄▀ ▄▀               ",
                    "      ▄▀ ▄▀ ▄▀▄▀▄▀ ▄▀ ▄▀ ▄▀                     "
                };
                string[] FrameSix = new string[]
                {
                    "                                            ▄ ▄▀",
                    "                                      ▄ ▄ ▄▀ ▀  ",
                    "                               ▄  ▄  █ ▀ ▀      ",
                    "                     ▄    ▄  ▄▀ ▄▀ ▄▀           ",
                    "             ▄    ▄ ▀▄  ▄▀  █  █                ",
                    "      ▄  ▄  █ ▄ ▄▀ ▄▀ ▄▀ ▄ ▀  ▀                 "
                };
                string[] FrameSeven = new string[]
                {
                    "                                             ▄▀▄",
                    "                                          ▄▀▄▀  ",
                    "                                    ▄▀▄▀▄▀      ",
                    "                             ▄▀ ▄▀ ▄▀           ",
                    "                   ▄▀   ▄▀ ▄▀ ▄▀ ▄▀             ",
                    "           ▄▀   ▄▀ ▄▀ ▄▀  ▄▀ ▄▀                 "
                };
                string[] FrameEight = new string[]
                {
                    "                                              ▄▀",
                    "                                          ▄ ▄▀  ",
                    "                                    ▄ ▄ ▄▀ ▀    ",
                    "                             ▄  ▄  █ ▀ ▀        ",
                    "                   ▄    ▄  ▄▀ ▄▀ ▄▀             ",
                    "      ▄▀ ▄▀ ▄   ▄ ▀▄  ▄▀  █  █                  "
                };
                string[] FrameNine = new string[]
                {
                    "                                              ▄▀",
                    "                                          ▄▀▄▀  ",
                    "                                       ▄▀▄▀     ",
                    "                                 ▄▀▄▀▄▀         ",
                    "                          ▄▀ ▄▀ ▄▀              ",
                    "                ▄▀   ▄▀ ▄▀ ▄▀ ▄▀                "
                };
                string[] FrameTen = new string[]
                {
                    "                                            ▄ ▄▀",
                    "                                      ▄ ▄ ▄▀ ▀  ",
                    "                               ▄  ▄  █ ▀ ▀      ",
                    "                     ▄    ▄  ▄▀ ▄▀ ▄▀           ",
                    "             ▄    ▄ ▀▄  ▄▀  █  █                ",
                    "               ▄    ▄  ▄▀ ▄▀ ▄▀                 "
                };
                string[] FrameLast = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                #endregion

                int startX = 7;
                int startY = 10;
                List<string[]> frames = new List<string[]> { FrameOne, FrameTwo, FrameThree, FrameFour };
                List<string[]> frames2 = new List<string[]> { FrameFive, FrameSix, FrameSeven, FrameEight, FrameNine, FrameTen };
                foreach (string[] frame in frames)
                {
                    startX = 7;
                    foreach (string line in frame)
                    {
                        Console.SetCursorPosition(startY, startX);
                        Console.Write(line);
                        startX += 1;
                    }
                    System.Threading.Thread.Sleep(100);
                }
                startX = 7;
                string count = "     ";
                foreach (char item in count)
                {
                    foreach (string[] frame in frames2)
                    {
                        startX = 7;
                        foreach (string line in frame)
                        {
                            Console.SetCursorPosition(startY, startX);
                            Console.Write(line);
                            startX += 1;
                        }
                        System.Threading.Thread.Sleep(100);
                    }
                }
                startX = 7;
                foreach (string line in FrameLast)
                {
                    Console.SetCursorPosition(startY, startX);
                    Console.Write(line);
                    startX += 1;
                }
            }
            if (move.Name == "Thundershock")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                #region Frames
                string[] FrameOne = new string[]
                {
                    "                   ▄▀                           ",
                    "                  █                             ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                string[] FrameTwo = new string[]
                {
                    "                ▄▄ ▄▀                           ",
                    "              ▀▀  █                             ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                string[] FrameThree = new string[]
                {
                    "      ▀▄  ▄▄▄▄  ▄▄ ▄▀                           ",
                    "      ▄▄▀▀    ▀▀  █                             ",
                    "           ▄▄ ▄▄▀▀                              ",
                    "         ▀▀  █                                  ",
                    "                                                ",
                    "                                                "
                };
                string[] FrameFour = new string[]
                {
                    "      ▀▄  ▄▄▄▄  ▄▄ ▄▀                           ",
                    "      ▄▄▀▀    ▀▀  █                             ",
                    "     █     ▄▄ ▄▄▀▀▄                             ",
                    "        ▄▀▀  █    █                             ",
                    "            █    █                              ",
                    "                                                "
                };
                string[] FrameFive = new string[]
                {
                    "      ▀▄  ▄▄▄▄  ▄▄ ▄▀                           ",
                    "      ▄▄▀▀    ▀▀  █                             ",
                    "     █     ▄▄ ▄▄▀▀▄                             ",
                    "    ▀   ▄▀▀  █    █                             ",
                    "      ▄▀▄   █    █                              ",
                    "          ▄▀    █ ▀▄                            "
                };
                string[] FrameSix = new string[]
                {
                    "      ▀█▄▄████▄▄██▄▄█                           ",
                    "      ▄▄█▀    ▀▀  █▀                            ",
                    "    ▄█▀▀ ▄▄██ ▄▄██▄                             ",
                    "    ▀▀ ▄█▀▀  █▀▀  ██                            ",
                    "      █▀█  ▄█▀  ▄██                             ",
                    "          █▀   ▄█ █▄                            "
                };
                string[] FrameLast = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                #endregion

                int startX = 10;
                int startY = 7;
                List<string[]> frames = new List<string[]> { FrameOne, FrameTwo, FrameThree, FrameFour };
                List<string[]> frames2 = new List<string[]> { FrameFive, FrameSix };
                foreach (string[] frame in frames)
                {
                    startY = 7;
                    foreach (string line in frame)
                    {
                        Console.SetCursorPosition(startX, startY);
                        Console.Write(line);
                        startY += 1;
                    }
                    System.Threading.Thread.Sleep(100);
                }

                int count = 1;
                foreach (char item in "   ")
                {
                    foreach (string[] frame in frames2)
                    {
                        startY = 7;
                        if (count % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            foreach (string line in frame)
                            {
                                Console.SetCursorPosition(startX, startY);
                                Console.Write(line);
                                startY += 1;
                            }
                            System.Threading.Thread.Sleep(500);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            foreach (string line in frame)
                            {
                                Console.SetCursorPosition(startX, startY);
                                Console.Write(line);
                                startY += 1;
                            }
                            System.Threading.Thread.Sleep(100);
                        }
                        count += 1;
                    }
                }
                startY = 7;
                foreach (string line in FrameLast)
                {
                    Console.SetCursorPosition(startX, startY);
                    Console.Write(line);
                    startY += 1;
                }
            }
            if (move.Name == "Mudshot")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                #region Frames
                string[] FrameOne = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                string[] FrameTwo = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                                ▄▀ ▄▀           ",
                    "                               ▄▀               ",
                    "                                                "
                };
                string[] FrameThree = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                          ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "                        ▄▀  ▄▀ ▄▀               ",
                    "                       ▀ ▄▀                     "
                };
                string[] FrameFour = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                     ▄▀   ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "                  ▄▀ ▄▀ ▄▀  ▄▀ ▄▀               ",
                    "               ▀▄▀ ▄▀ ▄▀ ▄▀                     "
                };
                string[] FrameFive = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                     ▄▀   ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "             ▄▀   ▄▀ ▄▀ ▄▀  ▄▀ ▄▀               ",
                    "      ▄▀ ▄▀ ▄▀▄▀▄▀ ▄▀ ▄▀ ▄▀                     "
                };
                string[] FrameSix = new string[]
                {
                    "                                            ▄ ▄▀",
                    "                                      ▄ ▄ ▄▀ ▀  ",
                    "                               ▄  ▄  █ ▀ ▀      ",
                    "                     ▄    ▄  ▄▀ ▄▀ ▄▀           ",
                    "             ▄    ▄ ▀▄  ▄▀  █  █                ",
                    "      ▄  ▄  █ ▄ ▄▀ ▄▀ ▄▀ ▄ ▀  ▀                 "
                };
                string[] FrameSeven = new string[]
                {
                    "                                             ▄▀▄",
                    "                                          ▄▀▄▀  ",
                    "                                    ▄▀▄▀▄▀      ",
                    "                             ▄▀ ▄▀ ▄▀           ",
                    "                   ▄▀   ▄▀ ▄▀ ▄▀ ▄▀             ",
                    "           ▄▀   ▄▀ ▄▀ ▄▀  ▄▀ ▄▀                 "
                };
                string[] FrameEight = new string[]
                {
                    "                                              ▄▀",
                    "                                          ▄ ▄▀  ",
                    "                                    ▄ ▄ ▄▀ ▀    ",
                    "                             ▄  ▄  █ ▀ ▀        ",
                    "                   ▄    ▄  ▄▀ ▄▀ ▄▀             ",
                    "      ▄▀ ▄▀ ▄   ▄ ▀▄  ▄▀  █  █                  "
                };
                string[] FrameNine = new string[]
                {
                    "                                              ▄▀",
                    "                                          ▄▀▄▀  ",
                    "                                       ▄▀▄▀     ",
                    "                                 ▄▀▄▀▄▀         ",
                    "                          ▄▀ ▄▀ ▄▀              ",
                    "                ▄▀   ▄▀ ▄▀ ▄▀ ▄▀                "
                };
                string[] FrameTen = new string[]
                {
                    "                                            ▄ ▄▀",
                    "                                      ▄ ▄ ▄▀ ▀  ",
                    "                               ▄  ▄  █ ▀ ▀      ",
                    "                     ▄    ▄  ▄▀ ▄▀ ▄▀           ",
                    "             ▄    ▄ ▀▄  ▄▀  █  █                ",
                    "               ▄    ▄  ▄▀ ▄▀ ▄▀                 "
                };
                string[] FrameLast = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                #endregion

                int startX = 7;
                int startY = 10;
                List<string[]> frames = new List<string[]> { FrameOne, FrameTwo, FrameThree, FrameFour };
                List<string[]> frames2 = new List<string[]> { FrameFive, FrameSix, FrameSeven, FrameEight, FrameNine, FrameTen };
                foreach (string[] frame in frames)
                {
                    startX = 7;
                    foreach (string line in frame)
                    {
                        Console.SetCursorPosition(startY, startX);
                        Console.Write(line);
                        startX += 1;
                    }
                    System.Threading.Thread.Sleep(100);
                }
                startX = 7;
                string count = "     ";
                foreach (char item in count)
                {
                    foreach (string[] frame in frames2)
                    {
                        startX = 7;
                        foreach (string line in frame)
                        {
                            Console.SetCursorPosition(startY, startX);
                            Console.Write(line);
                            startX += 1;
                        }
                        System.Threading.Thread.Sleep(100);
                    }
                }
                startX = 7;
                foreach (string line in FrameLast)
                {
                    Console.SetCursorPosition(startY, startX);
                    Console.Write(line);
                    startX += 1;
                }
            }
            if (move.Name == "Confusion")
            {

            }
            Console.BackgroundColor = gbBackground;
            Console.ForegroundColor = gbText;
        }

        public static void ANIAttackerMoves(Monster_Moves move, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.BackgroundColor = gbBackground;
            if (move.Name == "Ember")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                #region Frames
                string[] FrameOne = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                string[] FrameTwo = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                                ▄▀ ▄▀           ",
                    "                               ▄▀               ",
                    "                                                "
                };
                string[] FrameThree = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                          ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "                        ▄▀  ▄▀ ▄▀               ",
                    "                       ▀ ▄▀                     "
                };
                string[] FrameFour = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                     ▄▀   ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "                  ▄▀ ▄▀ ▄▀  ▄▀ ▄▀               ",
                    "               ▀▄▀ ▄▀ ▄▀ ▄▀                     "
                };
                string[] FrameFive = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                     ▄▀   ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "             ▄▀   ▄▀ ▄▀ ▄▀  ▄▀ ▄▀               ",
                    "      ▄▀ ▄▀ ▄▀▄▀▄▀ ▄▀ ▄▀ ▄▀                     "
                };
                string[] FrameSix = new string[]
                {
                    "                                            ▄ ▄▀",
                    "                                      ▄ ▄ ▄▀ ▀  ",
                    "                               ▄  ▄  █ ▀ ▀      ",
                    "                     ▄    ▄  ▄▀ ▄▀ ▄▀           ",
                    "             ▄    ▄ ▀▄  ▄▀  █  █                ",
                    "      ▄  ▄  █ ▄ ▄▀ ▄▀ ▄▀ ▄ ▀  ▀                 "
                };
                string[] FrameSeven = new string[]
                {
                    "                                             ▄▀▄",
                    "                                          ▄▀▄▀  ",
                    "                                    ▄▀▄▀▄▀      ",
                    "                             ▄▀ ▄▀ ▄▀           ",
                    "                   ▄▀   ▄▀ ▄▀ ▄▀ ▄▀             ",
                    "           ▄▀   ▄▀ ▄▀ ▄▀  ▄▀ ▄▀                 "
                };
                string[] FrameEight = new string[]
                {
                    "                                              ▄▀",
                    "                                          ▄ ▄▀  ",
                    "                                    ▄ ▄ ▄▀ ▀    ",
                    "                             ▄  ▄  █ ▀ ▀        ",
                    "                   ▄    ▄  ▄▀ ▄▀ ▄▀             ",
                    "      ▄▀ ▄▀ ▄   ▄ ▀▄  ▄▀  █  █                  "
                };
                string[] FrameNine = new string[]
                {
                    "                                              ▄▀",
                    "                                          ▄▀▄▀  ",
                    "                                       ▄▀▄▀     ",
                    "                                 ▄▀▄▀▄▀         ",
                    "                          ▄▀ ▄▀ ▄▀              ",
                    "                ▄▀   ▄▀ ▄▀ ▄▀ ▄▀                "
                };
                string[] FrameTen = new string[]
                {
                    "                                            ▄ ▄▀",
                    "                                      ▄ ▄ ▄▀ ▀  ",
                    "                               ▄  ▄  █ ▀ ▀      ",
                    "                     ▄    ▄  ▄▀ ▄▀ ▄▀           ",
                    "             ▄    ▄ ▀▄  ▄▀  █  █                ",
                    "               ▄    ▄  ▄▀ ▄▀ ▄▀                 "
                };
                string[] FrameLast = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                #endregion

                int startX = 7;
                int startY = 10;
                List<string[]> frames = new List<string[]> { FrameOne, FrameTwo, FrameThree, FrameFour };
                List<string[]> frames2 = new List<string[]> { FrameFive, FrameSix, FrameSeven, FrameEight, FrameNine, FrameTen };
                foreach (string[] frame in frames)
                {
                    startX = 7;
                    foreach (string line in frame)
                    {
                        Console.SetCursorPosition(startY, startX);
                        Console.Write(line);
                        startX += 1;
                    }
                    System.Threading.Thread.Sleep(100);
                }
                startX = 7;
                string count = "     ";
                foreach (char item in count)
                {
                    foreach (string[] frame in frames2)
                    {
                        startX = 7;
                        foreach (string line in frame)
                        {
                            Console.SetCursorPosition(startY, startX);
                            Console.Write(line);
                            startX += 1;
                        }
                        System.Threading.Thread.Sleep(100);
                    }
                }
                startX = 7;
                foreach (string line in FrameLast)
                {
                    Console.SetCursorPosition(startY, startX);
                    Console.Write(line);
                    startX += 1;
                }
            }
            if (move.Name == "Watergun")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                #region Frames
                string[] FrameOne = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                string[] FrameTwo = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                                ▄▀ ▄▀           ",
                    "                               ▄▀               ",
                    "                                                "
                };
                string[] FrameThree = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                          ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "                        ▄▀  ▄▀ ▄▀               ",
                    "                       ▀ ▄▀                     "
                };
                string[] FrameFour = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                     ▄▀   ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "                  ▄▀ ▄▀ ▄▀  ▄▀ ▄▀               ",
                    "               ▀▄▀ ▄▀ ▄▀ ▄▀                     "
                };
                string[] FrameFive = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                     ▄▀   ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "             ▄▀   ▄▀ ▄▀ ▄▀  ▄▀ ▄▀               ",
                    "      ▄▀ ▄▀ ▄▀▄▀▄▀ ▄▀ ▄▀ ▄▀                     "
                };
                string[] FrameSix = new string[]
                {
                    "                                            ▄ ▄▀",
                    "                                      ▄ ▄ ▄▀ ▀  ",
                    "                               ▄  ▄  █ ▀ ▀      ",
                    "                     ▄    ▄  ▄▀ ▄▀ ▄▀           ",
                    "             ▄    ▄ ▀▄  ▄▀  █  █                ",
                    "      ▄  ▄  █ ▄ ▄▀ ▄▀ ▄▀ ▄ ▀  ▀                 "
                };
                string[] FrameSeven = new string[]
                {
                    "                                             ▄▀▄",
                    "                                          ▄▀▄▀  ",
                    "                                    ▄▀▄▀▄▀      ",
                    "                             ▄▀ ▄▀ ▄▀           ",
                    "                   ▄▀   ▄▀ ▄▀ ▄▀ ▄▀             ",
                    "           ▄▀   ▄▀ ▄▀ ▄▀  ▄▀ ▄▀                 "
                };
                string[] FrameEight = new string[]
                {
                    "                                              ▄▀",
                    "                                          ▄ ▄▀  ",
                    "                                    ▄ ▄ ▄▀ ▀    ",
                    "                             ▄  ▄  █ ▀ ▀        ",
                    "                   ▄    ▄  ▄▀ ▄▀ ▄▀             ",
                    "      ▄▀ ▄▀ ▄   ▄ ▀▄  ▄▀  █  █                  "
                };
                string[] FrameNine = new string[]
                {
                    "                                              ▄▀",
                    "                                          ▄▀▄▀  ",
                    "                                       ▄▀▄▀     ",
                    "                                 ▄▀▄▀▄▀         ",
                    "                          ▄▀ ▄▀ ▄▀              ",
                    "                ▄▀   ▄▀ ▄▀ ▄▀ ▄▀                "
                };
                string[] FrameTen = new string[]
                {
                    "                                            ▄ ▄▀",
                    "                                      ▄ ▄ ▄▀ ▀  ",
                    "                               ▄  ▄  █ ▀ ▀      ",
                    "                     ▄    ▄  ▄▀ ▄▀ ▄▀           ",
                    "             ▄    ▄ ▀▄  ▄▀  █  █                ",
                    "               ▄    ▄  ▄▀ ▄▀ ▄▀                 "
                };
                string[] FrameLast = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                #endregion

                int startX = 7;
                int startY = 10;
                List<string[]> frames = new List<string[]> { FrameOne, FrameTwo, FrameThree, FrameFour };
                List<string[]> frames2 = new List<string[]> { FrameFive, FrameSix, FrameSeven, FrameEight, FrameNine, FrameTen };
                foreach (string[] frame in frames)
                {
                    startX = 7;
                    foreach (string line in frame)
                    {
                        Console.SetCursorPosition(startY, startX);
                        Console.Write(line);
                        startX += 1;
                    }
                    System.Threading.Thread.Sleep(100);
                }
                startX = 7;
                string count = "     ";
                foreach (char item in count)
                {
                    foreach (string[] frame in frames2)
                    {
                        startX = 7;
                        foreach (string line in frame)
                        {
                            Console.SetCursorPosition(startY, startX);
                            Console.Write(line);
                            startX += 1;
                        }
                        System.Threading.Thread.Sleep(100);
                    }
                }
                startX = 7;
                foreach (string line in FrameLast)
                {
                    Console.SetCursorPosition(startY, startX);
                    Console.Write(line);
                    startX += 1;
                }
            }
            if (move.Name == "Thundershock")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                #region Frames
                string[] FrameOne = new string[]
                {
                    "                   ▄▀                           ",
                    "                  █                             ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                string[] FrameTwo = new string[]
                {
                    "                ▄▄ ▄▀                           ",
                    "              ▀▀  █                             ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                string[] FrameThree = new string[]
                {
                    "      ▀▄  ▄▄▄▄  ▄▄ ▄▀                           ",
                    "      ▄▄▀▀    ▀▀  █                             ",
                    "           ▄▄ ▄▄▀▀                              ",
                    "         ▀▀  █                                  ",
                    "                                                ",
                    "                                                "
                };
                string[] FrameFour = new string[]
                {
                    "      ▀▄  ▄▄▄▄  ▄▄ ▄▀                           ",
                    "      ▄▄▀▀    ▀▀  █                             ",
                    "     █     ▄▄ ▄▄▀▀▄                             ",
                    "        ▄▀▀  █    █                             ",
                    "            █    █                              ",
                    "                                                "
                };
                string[] FrameFive = new string[]
                {
                    "      ▀▄  ▄▄▄▄  ▄▄ ▄▀                           ",
                    "      ▄▄▀▀    ▀▀  █                             ",
                    "     █     ▄▄ ▄▄▀▀▄                             ",
                    "    ▀   ▄▀▀  █    █                             ",
                    "      ▄▀▄   █    █                              ",
                    "          ▄▀    █ ▀▄                            "
                };
                string[] FrameSix = new string[]
                {
                    "      ▀█▄▄████▄▄██▄▄█                           ",
                    "      ▄▄█▀    ▀▀  █▀                            ",
                    "    ▄█▀▀ ▄▄██ ▄▄██▄                             ",
                    "    ▀▀ ▄█▀▀  █▀▀  ██                            ",
                    "      █▀█  ▄█▀  ▄██                             ",
                    "          █▀   ▄█ █▄                            "
                };
                string[] FrameLast = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                #endregion

                int startX = 10;
                int startY = 7;
                List<string[]> frames = new List<string[]> { FrameOne, FrameTwo, FrameThree, FrameFour };
                List<string[]> frames2 = new List<string[]> { FrameFive, FrameSix };
                foreach (string[] frame in frames)
                {
                    startY = 7;
                    foreach (string line in frame)
                    {
                        Console.SetCursorPosition(startX, startY);
                        Console.Write(line);
                        startY += 1;
                    }
                    System.Threading.Thread.Sleep(100);
                }

                int count = 1;
                foreach (char item in "   ")
                {
                    foreach (string[] frame in frames2)
                    {
                        startY = 7;
                        if (count % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            foreach (string line in frame)
                            {
                                Console.SetCursorPosition(startX, startY);
                                Console.Write(line);
                                startY += 1;
                            }
                            System.Threading.Thread.Sleep(500);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            foreach (string line in frame)
                            {
                                Console.SetCursorPosition(startX, startY);
                                Console.Write(line);
                                startY += 1;
                            }
                            System.Threading.Thread.Sleep(100);
                        }
                        count += 1;
                    }
                }
                startY = 7;
                foreach (string line in FrameLast)
                {
                    Console.SetCursorPosition(startX, startY);
                    Console.Write(line);
                    startY += 1;
                }
            }
            if (move.Name == "Mudshot")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                #region Frames
                string[] FrameOne = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                string[] FrameTwo = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                                ▄▀ ▄▀           ",
                    "                               ▄▀               ",
                    "                                                "
                };
                string[] FrameThree = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                          ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "                        ▄▀  ▄▀ ▄▀               ",
                    "                       ▀ ▄▀                     "
                };
                string[] FrameFour = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                     ▄▀   ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "                  ▄▀ ▄▀ ▄▀  ▄▀ ▄▀               ",
                    "               ▀▄▀ ▄▀ ▄▀ ▄▀                     "
                };
                string[] FrameFive = new string[]
                {
                    "                                            ▄▀▄▀",
                    "                                      ▄▀▄▀▄▀    ",
                    "                               ▄▀ ▄▀ ▄▀         ",
                    "                     ▄▀   ▄▀ ▄▀ ▄▀ ▄▀           ",
                    "             ▄▀   ▄▀ ▄▀ ▄▀  ▄▀ ▄▀               ",
                    "      ▄▀ ▄▀ ▄▀▄▀▄▀ ▄▀ ▄▀ ▄▀                     "
                };
                string[] FrameSix = new string[]
                {
                    "                                            ▄ ▄▀",
                    "                                      ▄ ▄ ▄▀ ▀  ",
                    "                               ▄  ▄  █ ▀ ▀      ",
                    "                     ▄    ▄  ▄▀ ▄▀ ▄▀           ",
                    "             ▄    ▄ ▀▄  ▄▀  █  █                ",
                    "      ▄  ▄  █ ▄ ▄▀ ▄▀ ▄▀ ▄ ▀  ▀                 "
                };
                string[] FrameSeven = new string[]
                {
                    "                                             ▄▀▄",
                    "                                          ▄▀▄▀  ",
                    "                                    ▄▀▄▀▄▀      ",
                    "                             ▄▀ ▄▀ ▄▀           ",
                    "                   ▄▀   ▄▀ ▄▀ ▄▀ ▄▀             ",
                    "           ▄▀   ▄▀ ▄▀ ▄▀  ▄▀ ▄▀                 "
                };
                string[] FrameEight = new string[]
                {
                    "                                              ▄▀",
                    "                                          ▄ ▄▀  ",
                    "                                    ▄ ▄ ▄▀ ▀    ",
                    "                             ▄  ▄  █ ▀ ▀        ",
                    "                   ▄    ▄  ▄▀ ▄▀ ▄▀             ",
                    "      ▄▀ ▄▀ ▄   ▄ ▀▄  ▄▀  █  █                  "
                };
                string[] FrameNine = new string[]
                {
                    "                                              ▄▀",
                    "                                          ▄▀▄▀  ",
                    "                                       ▄▀▄▀     ",
                    "                                 ▄▀▄▀▄▀         ",
                    "                          ▄▀ ▄▀ ▄▀              ",
                    "                ▄▀   ▄▀ ▄▀ ▄▀ ▄▀                "
                };
                string[] FrameTen = new string[]
                {
                    "                                            ▄ ▄▀",
                    "                                      ▄ ▄ ▄▀ ▀  ",
                    "                               ▄  ▄  █ ▀ ▀      ",
                    "                     ▄    ▄  ▄▀ ▄▀ ▄▀           ",
                    "             ▄    ▄ ▀▄  ▄▀  █  █                ",
                    "               ▄    ▄  ▄▀ ▄▀ ▄▀                 "
                };
                string[] FrameLast = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                #endregion

                int startX = 7;
                int startY = 10;
                List<string[]> frames = new List<string[]> { FrameOne, FrameTwo, FrameThree, FrameFour };
                List<string[]> frames2 = new List<string[]> { FrameFive, FrameSix, FrameSeven, FrameEight, FrameNine, FrameTen };
                foreach (string[] frame in frames)
                {
                    startX = 7;
                    foreach (string line in frame)
                    {
                        Console.SetCursorPosition(startY, startX);
                        Console.Write(line);
                        startX += 1;
                    }
                    System.Threading.Thread.Sleep(100);
                }
                startX = 7;
                string count = "     ";
                foreach (char item in count)
                {
                    foreach (string[] frame in frames2)
                    {
                        startX = 7;
                        foreach (string line in frame)
                        {
                            Console.SetCursorPosition(startY, startX);
                            Console.Write(line);
                            startX += 1;
                        }
                        System.Threading.Thread.Sleep(100);
                    }
                }
                startX = 7;
                foreach (string line in FrameLast)
                {
                    Console.SetCursorPosition(startY, startX);
                    Console.Write(line);
                    startX += 1;
                }
            }
            if (move.Name == "Confusion")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                #region Frames
                string[] FrameOne = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "               ▀▄                               "
                };
                string[] FrameTwo = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                    ▀▄                          ",
                    "                      █                         "
                };
                string[] FrameThree = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                        ▄▄                      ",
                    "                          ▀▄                    ",
                    "                            █                   ",
                    "                                                "
                };
                string[] FrameFour = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                            ▄▄▄                 ",
                    "                               ▀▀▄              ",
                    "                                  █             ",
                    "                                 ▄▀             "
                };
                string[] FrameFive = new string[]
                {
                    "                                                ",
                    "                                      ▄▄▄       ",
                    "                                         ▀▀▄    ",
                    "                                            █   ",
                    "                                           ▄▀   ",
                    "                                         ▀      "
                };
                string[] FrameSix = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                         ▀▀▄    ",
                    "                                            █   ",
                    "                                      ▄    ▄▀   ",
                    "                                         ▀      "
                };
                string[] FrameSeven = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                     ▄      █   ",
                    "                                      ▄    ▄▀   ",
                    "                                        ▀▀▀     "
                };
                string[] FrameEight = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                      ▄         ",
                    "                                     █      █   ",
                    "                                     ▀▄    ▄▀   ",
                    "                                       ▀▀▀▀     "
                };
                string[] FrameNine = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                      ▄  ▀▀▄    ",
                    "                                     █      █   ",
                    "                                     ▀▄    ▄▀   ",
                    "                                       ▀▀▀▀     "
                };
                string[] FrameTen = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                      ▄▀▀▀▀▄    ",
                    "                                     █      █   ",
                    "                                     ▀▄    ▄▀   ",
                    "                                       ▀▀▀▀     "
                };
                string[] FrameEleven = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                      ▄▀  ▀▄    ",
                    "                                     ▀      ▀   ",
                    "                                     ▀▄    ▄▀   ",
                    "                                       ▀  ▀     "
                };
                string[] FrameTwelve = new string[]
                {
                    "                                                ",
                    "                                    ▄▀      ▀▄  ",
                    "                                   ▀          ▀ ",
                    "                                                ",
                    "                                   ▀▄        ▄▀ ",
                    "                                     ▀      ▀   "
                };
                string[] FrameThirteen = new string[]
                {
                    "                                                ",
                    "                                   ▀          ▀ ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                   ▀          ▀ "
                };
                string[] FrameLast = new string[]
                {
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                ",
                    "                                                "
                };
                #endregion

                int startX = 7;
                int startY = 10;
                List<string[]> frames = new List<string[]> { FrameOne, FrameTwo, FrameThree, FrameFour, FrameFive, FrameSix, FrameSeven, FrameEight, FrameNine };
                List<string[]> frames2 = new List<string[]> { FrameEleven, FrameTwelve, FrameThirteen };
                foreach (string[] frame in frames)
                {
                    startX = 7;
                    foreach (string line in frame)
                    {
                        Console.SetCursorPosition(startY, startX);
                        Console.Write(line);
                        startX += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                }
                startX = 7;
                Console.ForegroundColor = ConsoleColor.Yellow;
                foreach (string frame in FrameTen)
                {
                    Console.SetCursorPosition(startY, startX);
                    Console.Write(frame);
                    startX += 1;
                }
                System.Threading.Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.White;
                foreach (string[] frame in frames2)
                {
                    startX = 7;
                    foreach (string line in frame)
                    {
                        Console.SetCursorPosition(startY, startX);
                        Console.Write(line);
                        startX += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                }
                startX = 7;
                foreach (string line in FrameLast)
                {
                    Console.SetCursorPosition(startY, startX);
                    Console.Write(line);
                    startX += 1;
                }
            }
            Console.BackgroundColor = gbBackground;
            Console.ForegroundColor = gbText;
        }
    }
}
