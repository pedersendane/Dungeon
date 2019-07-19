using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;//added
using DungeonMonsters;

namespace Dungeon
{
    class BloodBorneDungeon
    {
        static void Main(string[] args)
        {
            #region Yahrnam


            Console.Title = "Dane's Dungeon";

            Console.WriteLine("---------------------------------------You awake in a place called Yharnam---------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("\nYharnam is an imposing and sprawling metropolis characterized by Gothic and Victorian architecture.\nYharnam's Victorian architecture is reminiscent of late 19th Century European cities including Paris, Edinburgh, \nCologne and London. \nThe town appears rather grim and decadent and has been ravaged by a mysterious plague, becoming infested with dangerous beasts and demented citizens. \nEverywhere you look, there is what seems to be a path. You follow one..");
            Console.WriteLine();
            int score = 0;
            #endregion

            #region Weapons


            Weapon axe = new Weapon(16, 1, "Hunter's Axe", 10, false);//Player has to have weapon so we have to make a weapon first.
            Weapon cleaver = new Weapon(20, 1, "Saw Cleaver", 10, false);
            Weapon bm = new Weapon(15, 3, "Blades of Mercy", 20, true);
            Weapon hm = new Weapon(23, 1, "Holy Moonlight Sword", 2, true);
            Weapon kirk = new Weapon(19, 2, "KirkHammer", 15, true);
            Weapon lhb = new Weapon(22, 1, "LudWigs Holy Blade", 10, true);
            Weapon[] Weapons = { axe, cleaver, bm, hm, kirk, lhb };
            Random rand = new Random();
            int randomNbr = rand.Next(Weapons.Length);
            Weapon radWeapon = Weapons[randomNbr];
            #endregion

            #region Hunters
            Player player = new Player("Night Hunter", 70, 5, 40, 40, Race.Beast, radWeapon);
            #endregion

            #region IDKWHYBUTDONTTOUCH


            //TODO 2. Create a do while
            bool exit = false;
            do
            {
                //room desc
                Console.WriteLine(RoomDesc());
                #endregion

                #region Beasts

                //Rabbit
                //Rabbit r1 = new Rabbit();//Uses the default constructor which sets some default values and creates a baby bunny
                //Rabbit r2 = new Rabbit("White Rabbit", 25, 25, 50, 20, 2, 8, "That's no ordinary rabbit. Look at the bones", true);                             
                //Since all of our child monsters are the same type, we can store them in an array of rabbits. 
                //Since all monsters are children of monster, we could store them in a monster[].
                Amygdala amg = new Amygdala();
                MoonPresence mp = new MoonPresence();
                BloodStarvedBeast bsb = new BloodStarvedBeast();
                TheOneReborn ob = new TheOneReborn();
                ClericBeast cb = new ClericBeast(); 

                Monster[] Monsters = { amg, mp, bsb, ob, cb };

                //Randomly selsct a monster
                Random rand1 = new Random();
                int randomNbr1 = rand1.Next(Monsters.Length);
                Monster monster = Monsters[randomNbr1];
                //show momster in the room
                Console.WriteLine("\nThe Beast in front of you: " + monster.Name);
                #endregion


                #region User Menu
                bool reload = false;
                do
                {
                    Console.WriteLine("\nPlease choose an action: \n" +
                        "A) Attack the beast\n" +
                        "R) Run\n" +
                        "H) Hunter Info\n" +
                        "B) Beast Info\n" +
                        "E) Exit\n");
                    ConsoleKey userChoice = Console.ReadKey().Key;
                    //The above line captures a single keystroke of user input
                    // as a character value and allows us to deal with that single 
                    // value instead of a string.
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //TODO Build out combat functionality
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {
                                //its dead, and player has won
                                //You could add some logic here for the player to get items, get life
                                //back, or something else
                                Console.WriteLine("\nYou defeated {0}!!\n", monster.Name);
                                score++; //increases the score
                                reload = true; //get a new room
                            }
                            break;

                        case ConsoleKey.R:
                            
                            Console.WriteLine("Smart move, but the beast isn't happy..");
                            Combat.DoAttack(monster, player);
                            Console.WriteLine();
                            reload = true;
                            break;

                        case ConsoleKey.H:
                            Console.WriteLine(player);
                            Console.WriteLine("Beasts slaughtered: " + score);
                            break;

                        case ConsoleKey.B:
                            
                            Console.WriteLine(monster);
                            break;

                        case ConsoleKey.E:
                        case ConsoleKey.X:
                            Console.WriteLine("You have chosen to exit the game. You weren't going to survive anyways.");
                            Console.WriteLine("You defeated {0} Beast{1}",score,
                                ((score ==1)? "." : "s."));
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid Response. Please try again");
                            break;

                    }//endswitch
                    if (player.Life <= 0)
                    {
                        
                        Console.WriteLine("You defeated {0} monster{1}", score,
                        ((score == 1) ? "." : "s."));
                        exit = true;
                    }
                } while (!exit && !reload);

            } while (!exit);
            Console.WriteLine("YOU DIED");
            #endregion

            // * ***DOWHILE inside DOWHILE***       
            //A. Attack the monster
            //**If they win, they go out of 1 do while**

            //B. Run away
            //*****Fall out of 1 do while, but not the other***
            //*****If you choose to run, they hit you in the back****

            //C. Charcater info 

            //D. Monster info

            //E. Exit 
            // *******Fall out of both do whiles******


            // * *******Extras*******
            //1. Collect gems
            //2. Leveling up
            //3. Healing
            //4. Collect weapons
            // */

        }//main
        #region Locations


        private static string RoomDesc()
        {
            string[] rooms =
            {
                /**/

    "The area you enter is known as the Cathedral Ward. It is almost nightfall. \nEvery night, the gates of the Ward close as hunters venture out to combat the Beasts. \nNavigating through the streets of Cathedral Ward are at time confusing, mostly because it is place that has many streetsand paths to other locations, constituting what is easily the largest part of Yharnam's city...",

    "You find yourself in front of Byrgenwerth. Beyond the Forbidden Woods, past the Forbidden Grave, stands \nByrgenwerth College, a research building of older times. Overlooking a lake, the building stands serenely, \nas if gazing the reflection of the moon.This is a place of higher learning, of teachings most obscure, \nthat delve into the mysterious secrets of the beasts that now that inhabit it...",

    "You find yourself in Yahar'gul, a seemingly abandoned village. Within the village, the entire population of \nYahar'gul appears to have been killed in the process of a ritual performed by the School of Mensis, with a staggering \namount of corpses melded into the walls or cowering in isolated corners.",

    "The area you enter is known by locals as the Nightmare Frontier. The area is strewn with graves and jagged rocks, \nand in the distance, only white mist and pillars can be seen. It seems as if the sinister location is floating...",

    "You stumble upon a vast castle that stretches vertically past your field of view. \nThe Cainhurst Castle. \nThe great, ruined castle is comprised of a large front patio filled with ice and dead trees that appears to have \ncatastrophically collapsed under its own weight. A great hall filled with dead servants that clean the floors and \npillars of the luxurious castle; a dining room, with the most luscious silverware decorating the tables can be seen, as well as a large amount of portraits of royalty are exposed on the walls. But the most important part of this decadent \nconstruction is the gigantic library that has an unimaginable size, truly colossal and likely an indication of the \nhistory and elitist and refined standards of those who used to live here."




            };

            return rooms[new Random().Next(rooms.Length)];

        }//endroomDesc
        #endregion


    }//class
}//namespace
