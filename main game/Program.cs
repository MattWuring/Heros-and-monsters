using System;

namespace main_game
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region variables

            string Hero_class = "";
            string Hero_class_confirm;

            int hero_crit_chance = 4;
            int hero_damage = 13;

            string Hero_Name = "unnamed";
            string name_check = "";

            string Difficulty = "";
            string Difficulty_confirm;

            string setttings_check;

            float hero_hp = 100;
            float monster_hp = 100;
            string monster_name = "unnamed";

            bool Monster_Flee = false;

            bool Hero_Defending = false;
            bool Hero_Attack_Bonus = false;

            int game_ending = 0;

            string Hero_Choice;

            float Hero_attack;

            float d6_1;
            float d6_2;
            float Monster_Attack;

            int Attack_Bonus_Chance;
            int Monster_flee_chance;

            string gamemode = "";
            string gamemode_confirm;

            string menu;

            int monsters_killed = 0;

            #endregion

            #region intro

            #region Opening menu

            Console.WriteLine("Welcome to Hero's and Monsters!");
            Console.WriteLine();
            Console.WriteLine("The rules are simple,");
            Console.WriteLine("you have to defeat a monster by choosing to attack or defend!");
            Console.WriteLine("For attack you have a chance to do 1 to 12 damage");
            Console.WriteLine("and you only take half damage if you defend!");
            Console.WriteLine();
            Console.WriteLine("Press [Enter] to start the game!");
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region main menu

            menu = "";

            switch (menu)
            {
                case "Gamemode":

                    Gamemode();

                    menu = "";

                    if (gamemode == "Story")
                    {
                        goto case "Difficulty";
                    }
                    else
                    {
                        goto case "Settings";
                    }

                    break;

                case "Name":

                    Name();

                    menu = "";

                    goto case "Settings";

                    break;

                case "Class":

                    Class();

                    menu = "";

                    goto case "Settings";

                    break;

                case "Difficulty":

                    Diff();

                    menu = "";

                    goto case "Settings";

                    break;

                case "Settings":

                    Settings();

                    #region Settings_check
                    if (setttings_check == "n")
                    {
                        Console.WriteLine("here are the setting that you can change!");
                        Console.WriteLine();
                        Console.WriteLine("Gamemode");
                        Console.WriteLine("Name");
                        Console.WriteLine("class");
                        if (gamemode == "Story")
                        {
                            Console.WriteLine("Difficulty");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Which one do you want to change?");

                        menu = Console.ReadLine();

                        if (menu == "Gamemode")
                        {
                            Continue();

                            goto case "Gamemode";
                        }
                        else if (menu == "Name")
                        {
                            Continue();

                            goto case "Name";
                        }
                        else if (menu == "Class")
                        {
                            Continue();

                            goto case "Class";
                        }
                        else if (menu == "Difficulty")
                        {
                            Continue();

                            goto case "Difficulty";
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("You have used an invalid answer, Please try again!");

                            Continue();

                            goto case "Settings";
                        }
                    } else
                    {
                        Continue();
                    }
                    #endregion

                    break;

                default:

                    Gamemode();
                    Name();
                    Class();
                    Diff();
                    Settings();

                    #region Settings_check
                    if (setttings_check == "n")
                    {
                        Console.WriteLine("here are the setting that you can change!");
                        Console.WriteLine();
                        Console.WriteLine("Gamemode");
                        Console.WriteLine("Name");
                        Console.WriteLine("class");
                        if (gamemode == "Story")
                        {
                            Console.WriteLine("Difficulty");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Which one do you want to change?");

                        menu = Console.ReadLine();

                        if (menu == "Gamemode")
                        {
                            Continue();

                            goto case "Gamemode";
                        }
                        else if (menu == "Name")
                        {
                            Continue();

                            goto case "Name";
                        }
                        else if (menu == "Class")
                        {
                            Continue();

                            goto case "Class";
                        }
                        else if (menu == "Difficulty")
                        {
                            Continue();

                            goto case "Difficulty";
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("You have used an invalid answer, Please try again!");

                            Continue();

                            goto case "Settings";
                        }
                    } else
                    {
                        Continue();
                    }
                    #endregion


                    break;
            }

            
            #endregion

            #endregion

            #region game

            #region hero setup 

            switch (Hero_class)
            {
                case "Tank":
                    hero_hp = 125;
                    hero_damage = 11;
                    break;

                case "Attacker":
                    hero_damage = 16;
                    hero_crit_chance = 5;
                    break;

                case "Assasin":
                    hero_crit_chance = 2;
                    hero_hp = 75;
                    break;

                default:
                    break;
            }

            Hero hero = new Hero(Hero_Name, hero_hp);

            #endregion

            #region monster setup

            switch (Difficulty)
            {
                case "Easy":
                    monster_hp = 50;
                    monster_name = "Slime";
                    break;

                case "Standard":
                    monster_hp = 100;
                    monster_name = "Zombie";
                    break;

                case "Expert":
                    monster_hp = 150;
                    monster_name = "Dragon";
                    break;
            }

            Monsters monster = new Monsters(monster_name, monster_hp);

            #endregion

            #region story mode

            if (gamemode == "Story")
            { 

                #region game start

                switch (monster.name)
                {
                    case "Slime":

                        Console.WriteLine($"{hero.name} has just started his adventure as a hero and has {hero.hp}hp,");

                        Console.WriteLine();
                        Console.WriteLine($"It seems that {hero.name} has just encountered his first monster, a {monster.name}!");
                        Console.WriteLine($"It looks like it only has {monster.hp}hp, {hero.name} should be able to win this battle!");

                        Console.WriteLine();
                        Console.WriteLine($"*{hero.name} begins to fight the slime*");

                        break;

                    case "Zombie":

                        Console.WriteLine($"{hero.name} has been on an adventure to become a hero for almost 2 months now,");
                        Console.WriteLine($"{hero.name} has only encountered slimes since the begining of his adventure and doesn't want to fight any more of them,");
                        Console.WriteLine($"but today is his lucky day since {hero.name} just encountered his first {monster.name}!");

                        Console.WriteLine();
                        Console.WriteLine($"{monster.name} are a bit stronger then your average slime though, so it has {monster.hp}hp!");

                        Console.WriteLine();
                        Console.WriteLine($"*{hero.name} rushes into the battle*");

                        break;

                    case "Dragon":

                        Console.WriteLine($"{hero.name} has been on an adventure for a long time know and gained a lot of experience,");
                        Console.WriteLine($"today {hero.name} is going to take on the final boss... A dragon!");

                        Console.WriteLine();
                        Console.WriteLine($"{hero.name} doubts a bit a first, but rushes into battle!");

                        break;
                }

                Continue();

                #endregion

                #region Game Combat

                do
                {
                    #region Randoms

                    Random rnd = new Random();

                    Hero_attack = rnd.Next(1, hero_damage);

                    d6_1 = rnd.Next(1, 7);
                    d6_2 = rnd.Next(1, 7);
                    Monster_Attack = d6_1 + d6_2;

                    Attack_Bonus_Chance = rnd.Next(0, hero_crit_chance);
                    Monster_flee_chance = rnd.Next(0, 4);

                    #endregion

                    #region chances

                    if (Attack_Bonus_Chance == 0)
                    {
                        Hero_Attack_Bonus = true;
                    }

                    if (monster.hp == monster.hp / 2)
                    {
                        if (Monster_flee_chance == 0)
                        {
                            Monster_Flee = true;
                        }
                    }

                    #endregion

                    #region hero turn

                    Hero_turn();

                    if (monster.hp <= 0)
                    {
                        game_ending = 1;
                        continue;
                    }

                    #endregion

                    #region monster turn

                    if (Monster_Flee == true)
                    {
                        Console.WriteLine($"The {monster.name} has run away!");
                        Console.WriteLine($"{hero.name} has won the battle!");
                        game_ending = 2;
                        continue;
                    }

                    monster_turn();

                    if (hero.hp <= 0)
                    {
                        game_ending = 3;
                        continue;
                    }

                    #endregion

                } while (hero.hp <= 0 | monster.hp <= 0);

                Continue();

                #endregion

                #region Game ending

                switch (game_ending)
                {
                    case 1:
                        Console.WriteLine($"Congratulations on beating the {monster.name},");
                        Console.WriteLine("I hope that you enjoyed the game and thanks for playing it!");
                        break;

                    case 2:
                        Console.WriteLine($"I suppose that scaring the {monster.name} away also counts as a victory,");
                        Console.WriteLine("I hope that you enjoyed the game and thanks for playing it!");
                        break;

                    case 3:
                        Console.WriteLine($"It seems that {hero.name} didnt survive his adventure,");
                        Console.WriteLine("Better luck next time!");
                        break;

                    default:
                        Console.WriteLine("How did you get here without a proper ending,");
                        Console.WriteLine("you must be some kind of wizard!");
                        Console.WriteLine();
                        Console.WriteLine("Wizard or not, thanks for playing the game!");
                        break;
                }

                #endregion
            }
            #endregion

            #region infinity

            if(gamemode == "Infinity")
            {
                #region Game start

                Console.WriteLine("In this gamemode you'll fight zombies untill you die,");
                Console.WriteLine("Have fun and good luck!");

                Continue();

                #endregion

                #region Game Combat

                do
                {

                    #region Randoms

                    Random rnd = new Random();

                    Hero_attack = rnd.Next(1, hero_damage);

                    d6_1 = rnd.Next(1, 7);
                    d6_2 = rnd.Next(1, 7);
                    Monster_Attack = d6_1 + d6_2;

                    Attack_Bonus_Chance = rnd.Next(0, hero_crit_chance);
                    Monster_flee_chance = rnd.Next(0, 4);

                    #endregion

                    #region chances

                    if (Attack_Bonus_Chance == 0)
                    {
                        Hero_Attack_Bonus = true;
                    }

                    if (monster.hp == monster.hp / 2)
                    {
                        if (Monster_flee_chance == 0)
                        {
                            Monster_Flee = true;
                        }
                    }

                    #endregion

                    #region hero turn

                    Hero_turn();

                    if (monster.hp <= 0)
                    {
                        Console.WriteLine("You have defeated a monster, on to the next one!");

                        monsters_killed++;
                        monster.hp = 100;

                        Continue();
                        continue;
                    }

                    #endregion

                    #region monster turn

                    if (Monster_Flee == true)
                    {
                        Console.WriteLine($"The {monster.name} has run away!");
                        Console.WriteLine($"{hero.name} has won the battle!");
                        monsters_killed++;
                        continue;
                    }

                    monster_turn();

                    #endregion

                } while (hero_hp >= 0);

                #endregion

                #region Game Ending

                Console.WriteLine($"you have defeated {monsters_killed} monsters");
                Console.WriteLine("Thanks For playing the game!");

                #endregion
            }

            #endregion

            #endregion

            #region voids

            void Continue()
            {

                Console.WriteLine();
                Console.WriteLine("Press [Enter] to Continue!");
                Console.ReadLine();
                Console.Clear();
            }

            void Gamemode()
            {
                #region gamemode selection

                gamemode = "";
                gamemode_confirm = "";


                switch (gamemode_confirm)
                {
                    case "y":
                        Console.WriteLine();
                        Console.WriteLine("You have chosen the gamemode that you want to play!");

                        break;

                    case "n":
                        Console.WriteLine();
                        Console.WriteLine("It seems like you accidentaly chose the wrong gamemode, please try again!");
                        Console.WriteLine();

                        gamemode = "";
                        goto default;

                        break;

                    default:
                        switch (gamemode)
                        {
                            case "Story":
                                Console.WriteLine();
                                Console.WriteLine("You have chosen the story mode, are you happy with this choice? [y/n]");

                                break;

                            case "Infinity":
                                Console.WriteLine();
                                Console.WriteLine("You have chosen the infinity mode, are you happy with this choice? [y/n]");

                                break;

                            default:
                                Console.WriteLine("What gamemode do you want to play?");
                                Console.WriteLine();
                                Console.WriteLine("Story - you'll fight a single monster with some lore");
                                Console.WriteLine("Infinity - you'll fight monsters untill you die");
                                Console.WriteLine();
                                Console.WriteLine("So wich one will it be?");

                                gamemode = Console.ReadLine();

                                if (gamemode == "Story")
                                {
                                    goto case "Story";
                                }
                                else if (gamemode == "Infinity")
                                {
                                    goto case "Infinity";
                                }
                                else
                                {
                                    Console.WriteLine("It looks like you entered an invalid answer, please try again!");
                                    Console.WriteLine();

                                    goto default;
                                }

                                break;
                        }

                        gamemode_confirm = Console.ReadLine();

                        if (gamemode_confirm == "y")
                        {
                            goto case "y";
                        }
                        else if (gamemode_confirm == "n")
                        {
                            goto case "n";
                        }
                        else
                        {
                            goto default;
                        }

                        break;
                }

                Continue();

                #endregion
            }

            void Name()
            {
                #region Hero Name

                Hero_Name = "";
                name_check = "";

                Console.WriteLine("Now, lets chose a name for your hero!");
                Console.WriteLine();

                switch (name_check)
                {
                    case "y":
                        Console.WriteLine();
                        Console.WriteLine($"Good job, you named your hero {Hero_Name}!");

                        break;

                    case "n":
                        Console.WriteLine();
                        Console.WriteLine($"Whoops, seems that you named your hero {Hero_Name} on accident!");
                        Console.WriteLine("i'll let you try again!");
                        Console.WriteLine();

                        goto default;

                        break;

                    default:
                        Console.WriteLine("What name do you want to give to your hero:");

                        Hero_Name = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine($"You named your hero {Hero_Name}, is this correct? [y/n]");

                        name_check = Console.ReadLine();

                        if (name_check == "n")
                        {
                            goto case "n";
                        }
                        else if (name_check == "y")
                        {
                            goto case "y";
                        }
                        else
                        {
                            Console.WriteLine("Seems that you entered an invalid answer, please try again!");
                            Console.WriteLine();

                            goto default;
                        }

                        break;
                }

                Continue();

                #endregion
            }

            void Class()
            {
                #region Hero Class

                Hero_class = "";
                Hero_class_confirm = "";

                switch (Hero_class_confirm)
                {
                    case "y":
                        Console.WriteLine();
                        Console.WriteLine("You have now picked a hero class!");
                        break;

                    case "n":
                        Console.WriteLine();
                        Console.WriteLine("It seems that you have chosen the wrong class on accident,");
                        Console.WriteLine("please try again!");
                        Console.WriteLine();

                        Hero_class = "";

                        goto default;

                        break;

                    default:
                        switch (Hero_class)
                        {
                            case "Tank":
                                Console.WriteLine($"So you have chosen the {Hero_class} class,");
                                Console.WriteLine($"is this correct? [y/n]");
                                break;

                            case "Attacker":
                                Console.WriteLine($"So you have chosen the {Hero_class} class,");
                                Console.WriteLine($"is this correct? [y/n]");
                                break;

                            case "Assasin":
                                Console.WriteLine($"So you have chosen the {Hero_class} class,");
                                Console.WriteLine($"is this correct? [y/n]");
                                break;

                            default:
                                Console.WriteLine("What class do you want your hero to have?");
                                Console.WriteLine();
                                Console.WriteLine("Tank - Your hero has more hp, but you'll do less damage!");
                                Console.WriteLine("Attacker - Your hero does more damage, but you have a lower crit chance!");
                                Console.WriteLine("Assasin - Your hero has a higher crit chance, but has less hp!");
                                Console.WriteLine();
                                Console.WriteLine("Which one will you pick?");

                                Hero_class = Console.ReadLine();

                                Console.WriteLine();

                                if (Hero_class == "Tank")
                                {
                                    goto case "Tank";
                                }
                                else if (Hero_class == "Attacker")
                                {
                                    goto case "Attacker";
                                }
                                else if (Hero_class == "Assasin")
                                {
                                    goto case "Assasin";
                                }
                                else
                                {
                                    Console.WriteLine("It seems that you have used an invalid answer, please try again!");
                                    Console.WriteLine();

                                    goto default;
                                }

                                break;
                        }

                        Hero_class_confirm = Console.ReadLine();

                        if (Hero_class_confirm == "y")
                        {
                            goto case "y";
                        }
                        else if (Hero_class_confirm == "n")
                        {
                            goto case "n";
                        }
                        else
                        {
                            Console.WriteLine("It seems that you have used an invalid answer, please try again!");
                            Console.WriteLine();

                            goto default;
                        }

                        break;
                }

                Continue();

                #endregion
            }

            void Diff()
            {
                #region difficulty

                Difficulty = "";
                Difficulty_confirm = "";

                if (gamemode == "Story")
                {

                    switch (Difficulty_confirm)
                    {
                        case "y":
                            Console.WriteLine();
                            Console.WriteLine("You have picked a Difficulty!");
                            break;

                        case "n":
                            Console.WriteLine();
                            Console.WriteLine("It seems that you have picked the wrong difficulty, please try again!");
                            Console.WriteLine();

                            Difficulty = "";

                            goto default;
                            break;

                        default:

                            switch (Difficulty)
                            {
                                case "Easy":
                                    Console.WriteLine();
                                    Console.WriteLine("Seems that you aren't very optimistic about your skill level,");
                                    Console.WriteLine("Are you happy with your answer? [y/n]");
                                    break;

                                case "Standard":
                                    Console.WriteLine();
                                    Console.WriteLine("There is nothing wrong with picking standerd, it's always a good option! ");
                                    Console.WriteLine("Are you happy with your answer? [y/n]");
                                    break;

                                case "Expert":
                                    Console.WriteLine();
                                    Console.WriteLine("Someone has high hopes for them selves, I wish you good luck!");
                                    Console.WriteLine("Are you happy with your answer? [y/n]");
                                    break;

                                default:
                                    Console.WriteLine("Please select a difficulty that you want to play on!");
                                    Console.WriteLine();
                                    Console.WriteLine("Easy - The monsters have less hp then on the standard difficulty");
                                    Console.WriteLine("Standard - You have about 100 hp and the monsters have around 100 hp");
                                    Console.WriteLine("Expert - The monsters have more hp then the standerd version");
                                    Console.WriteLine();
                                    Console.WriteLine("What will you pick?");

                                    Difficulty = Console.ReadLine();

                                    if (Difficulty == "Easy")
                                    {
                                        goto case "Easy";
                                    }
                                    else if (Difficulty == "Standard")
                                    {
                                        goto case "Standard";
                                    }
                                    else if (Difficulty == "Expert")
                                    {
                                        goto case "Expert";
                                    }
                                    else
                                    {
                                        Console.WriteLine("It seems that you have used an invalid answer, please try again!");
                                        Console.WriteLine();

                                        goto default;
                                    }

                                    break;

                            }

                            Difficulty_confirm = Console.ReadLine();

                            if (Difficulty_confirm == "y")
                            {
                                goto case "y";
                            }
                            else if (Difficulty_confirm == "n")
                            {
                                goto case "n";
                            }
                            else
                            {
                                Console.WriteLine("It seems that you have used an invalid answer, please try again!");
                                Console.WriteLine();

                                goto default;
                            }

                            break;
                    }

                    Continue();
                }

                #endregion
            }

            void Settings()
            {
                #region Confirm Settings

                Console.WriteLine("here are the setting that you have chosen:");
                Console.WriteLine();
                Console.WriteLine($"Gamemode = {gamemode}");
                Console.WriteLine($"Hero name = {Hero_Name}");
                Console.WriteLine($"Hero class = {Hero_class}");
                if (gamemode == "Story")
                {
                    Console.WriteLine($"Difficulty = {Difficulty}");
                }
                Console.WriteLine();
                Console.WriteLine("Are you happy with the chosen settings? [y/n]");

                setttings_check = Console.ReadLine();

                switch (setttings_check)
                {
                    case "y":
                        Console.WriteLine();
                        Console.WriteLine($"Good job on setting up everything correctly,");
                        Console.WriteLine("Have fun playing!");
                        break;

                    case "n":
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Doesnt look like you picked a valid answer, guess that the setting are correct then,");
                        Console.WriteLine("Have fun playing!");
                        break;
                }



                #endregion
            }

            void Hero_turn()
            {
                #region hero turn

                Console.WriteLine("What do you want to do, Attack or Defend?");
                Hero_Choice = Console.ReadLine();

                Console.WriteLine();

                switch (Hero_Choice)
                {
                    case "Attack":

                        Console.WriteLine($"You have chosen to {Hero_Choice} this turn,");

                        if (Hero_Attack_Bonus == true)
                        {

                            Console.WriteLine($"you have hit a critical hit, so your attack damage is doubled from {Hero_attack} to {Hero_attack * 2}!");
                            Hero_attack = Hero_attack * 2;
                            Hero_Attack_Bonus = false;

                        }
                        else
                        {

                            Console.WriteLine($"you have done {Hero_attack} damage to the {monster.name} this turn");

                        }

                        monster.hp = monster.hp - Hero_attack;

                        Console.WriteLine();
                        Console.WriteLine($"The {monster.name} has {monster.hp} hp left!");

                        break;

                    case "Defend":

                        Console.WriteLine($"You have chosen to {Hero_Choice} this turn,");
                        Console.WriteLine($"you will not do any damage to the {monster.name} this turn!");

                        Hero_Defending = true;

                        break;

                    default:

                        Console.WriteLine("You haven't picked a valid answer, so you will not do anything this turn!");

                        break;

                }

                Continue();

                #endregion
            }

            void monster_turn()
            {
                #region monster turn

                if (Monster_Flee == false) ;
                {
                    Console.WriteLine($"The {monster.name} has attacked {hero.name},");
                    Console.WriteLine($"{hero.name} lost {Monster_Attack}hp");

                    if (Hero_Defending == true)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"But {hero.name} only got hit with half the damage,");
                        Console.WriteLine($"because {hero.name} was defending!");

                        hero.hp = hero.hp - (Monster_Attack / 2);

                        Hero_Defending = false;
                    }
                    else
                    {
                        hero.hp = hero.hp - Monster_Attack;
                    }

                    Console.WriteLine();
                    Console.WriteLine($"{hero.name} has {hero.hp} hp left!");
                }

                Continue();

                #endregion
            }

            #endregion
        }
    }
}
