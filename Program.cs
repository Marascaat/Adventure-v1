//Original program just in case. Other file should be a unix executable tested on mac
string charac = ""; 
string broke = "";
int esteem = (0);
int confidance = (0);
int stealth = (0);
int reaction = (0);
int fight = (0);

while(true){
Console.Clear();
Console.WriteLine("Would you like to play a game?");
Console.WriteLine("1 yes");
Console.WriteLine("2 no");
string question1 = Console.ReadLine();
if (question1 == "1") {
while(true){
Console.Clear();
Console.WriteLine("Wonderful! Choose your character:");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("1. THE LOWLIFE");
Console.WriteLine("A thug who grew up having to fend for himself in the criminal underworld. His rough upbringing has taught him to do anything to survive, and he is skilled in theft and evasion.");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("2. THE RUNAWAY");
Console.WriteLine("A runaway of noble descent, she is looking to make her own way in life. Due to her noble upbringing, she is very good at persuading people to do her bidding.");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("3. THE STRANGER");
Console.WriteLine("A newcomer to the town, their identity is shrouded in mystery. Though their leather belt and dark silk cape hint at a noble lineage, the worker's boots and the hunting knife strapped to their belt hint that they have not spent their life safe inside a mansion.");
Console.ForegroundColor = ConsoleColor.White;
string guyselect = Console.ReadLine();
if (guyselect == "1") {
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("You have chosen the Lowlife! Press any key to continue");
charac = "lowlife";
esteem = (4);
confidance = (3);
stealth = (6);
reaction = (3);
fight = (4);
Console.ReadKey();
break;
}
else if (guyselect == "2") {
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("You have chosen the Runaway! Press any key to continue");
charac = "runaway";
esteem = (2);
confidance = (7);
stealth = (4);
reaction = (3);
fight = (4);
Console.ReadKey();
break;
}
else if (guyselect == "3") {
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("You have chosen the Stranger! Press any key to continue");
charac = "stranger";
esteem = (1);
confidance = (5);
stealth = (2);
reaction = (6);
fight = (6);
Console.ReadKey();
break;
}
}
while(true) { //the begining of the story
    Console.Clear();
    Console.WriteLine("The time is midday. You enter a bar and walk up to the counter. What do you order?");
    Console.WriteLine("");
    Console.WriteLine("1. Hard Liquer");
    Console.WriteLine("2. Light Cocktail");
    Console.WriteLine("3. Strong Coffee");
    string drinkchoice = Console.ReadLine(); ////choose your drink
    if (drinkchoice == "1") {
        while (true) {
            if (charac == "runaway") {
                Console.Clear();
                Console.WriteLine("You are not used to such a stiff drink. You feel a bit tipsy");
                Console.WriteLine("Press any key to continue");
                esteem = (esteem + 1);
                confidance = (confidance - 1);
                stealth = (stealth - 1);
                reaction = (reaction - 1);
                fight = (fight - 1);
                Console.ReadKey();
                break;
                }
            else if (charac == "lowlife") {
                Console.Clear();
                Console.WriteLine("You feel refreshed, and more confidant");
                Console.WriteLine("Press any key to continue");
                confidance = (confidance + 1);
                reaction = (reaction - 1);
                Console.ReadKey();
                break;
                }
            else if (charac == "stranger") {
                Console.Clear();
                Console.WriteLine("You feel refreshed, and more confidant");
                Console.WriteLine("Press any key to continue");
                confidance = (confidance + 1);
                reaction = (reaction - 1);
                esteem = (esteem + 2);
                Console.ReadKey();
                break;
                }
            break;
        }
        break;
    } 

    else if (drinkchoice == "3") {
        Console.Clear();
        Console.WriteLine("You feel energized, but your hands are shaking slightly from the caffeine.");
        confidance = (confidance +1);
        fight = (fight + 1);
        reaction = (reaction + 1);
        stealth = (stealth - 1);
        Console.ReadKey();
        break;
        }

    else if (drinkchoice == "2") {
        while (true) {
            if (charac == "lowlife") {
                while (true) { 
                Console.Clear();
                Console.WriteLine("You hear a derisive laugh. A man by the bar says 'what are you, a bloody girl?'");
                Console.WriteLine("The crowd goes silent. do you:");
                Console.WriteLine("1. Hold your tounge");
                Console.WriteLine("2. Insult the thug");
                Console.WriteLine("3. Attack the thug");
                esteem = (esteem - 1);
                string attack = Console.ReadLine(); 
                    if (attack == "1") {
                        Console.Clear();
                        Console.WriteLine("You stay silent, and the crowd laughs at you");
                        esteem = (esteem - 1);
                        confidance = (confidance - 1);
                        Console.ReadKey();
                        break;
                    }
                    
                    else if (attack == "2") {
                        Console.Clear();
                        esteem = (esteem + 2);
                        confidance = (confidance + 2);
                        Console.WriteLine("The thug turns red from anger and his fists clench, but he thinks better of it and backs off");
                        Console.ReadKey();
                        break;
                    }
                
            
                    else if (attack == "3") {
                        
                        while (true) {
                        Console.Clear();
                        Console.WriteLine("You lunge at the thug, but he was ready for it and punches you in the jaw.");
                        Console.WriteLine("Fortunately, your life of crime has allowed you to make many friends, and a brawl quickly ensues.");
                        Console.WriteLine("Soon police are called");
                        Console.WriteLine("Do you:");
                        Console.WriteLine("1. Try to run");
                        Console.WriteLine("2. Try to hide");
                        Console.WriteLine("3. Try to convince the police of your innocence");
                        string fightorflight = Console.ReadLine();
                               
                            if (fightorflight == "1") {
                                Console.Clear();
                                Console.WriteLine("You have a lot of experience with running from police, so the you escape successfully.");
                                Console.WriteLine("After a few hours, you return to the bar.");
                                Console.ReadKey();
                                break;
                            }
                            else if (fightorflight == "2") {
                                Console.Clear();
                                Console.WriteLine("you are just stealthy enough to hide from the police.");
                                Console.ReadKey();
                                Console.WriteLine("After a few hours, you return to the bar.");
                                Console.ReadKey();
                                break;
                            }
                            else if (fightorflight == "3") {
                                
                                while (true) {
                                    Console.Clear();
                                    Console.WriteLine("Oh no! The police don't believe you, and they place you under arrest!.");
                                    Console.WriteLine("");
                                    Console.WriteLine("You are taken to the station. Do you:");
                                    Console.WriteLine("");
                                    Console.WriteLine("1. Use the last of your money to bribe the guard");
                                    Console.WriteLine("2. Try to excape");
                                    Console.WriteLine("3. Wait for the trial");
                                    string prison = Console.ReadLine();
                                    if (prison == "1") {
                                        Console.Clear();
                                        Console.WriteLine("The guard takes all of your money, and sets you free.");
                                        Console.ReadKey();
                                        Console.WriteLine("Now penniless, you return to the bar.");
                                        broke = "1";
                                        Console.ReadKey();
                                        
                                        break;
                                    }
                                    else if (prison == "2") {
                                        Console.Clear();
                                        Console.WriteLine("You manage to escape right under the guard's nose!");
                                        Console.ReadKey();
                                        Console.WriteLine("You return to the bar");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else if (prison == "3") {
                                        Console.Clear();
                                        Console.WriteLine("As you have had multiple run-ins with the law, the jury quickly assumes that you're guilty, and you are sentance for 10 years in prison");
                                        Console.WriteLine("");
                                        Console.WriteLine("Press any key to retry");
                                        Console.ReadKey();
                                    }
                                }
                                break;
                            }
                    
                        }
                    break;
                    }
                
                }
            break;
            
            }
        else if (charac == "stranger") { //////stranger fights
                while (true) { 
                Console.Clear();
                Console.WriteLine("You hear a derisive laugh. A man by the bar says 'what are you, a bloody girl?'");
                Console.WriteLine("The crowd goes silent. do you:");
                Console.WriteLine("1. Hold your tounge");
                Console.WriteLine("2. Insult the thug");
                Console.WriteLine("3. Attack the thug");
                esteem = (esteem - 1);
                string attack = Console.ReadLine(); 
                    if (attack == "1") {
                        Console.Clear();
                        Console.WriteLine("You stay silent, and the crowd laughs at you");
                        esteem = (esteem - 1);
                        confidance = (confidance - 1);
                        Console.ReadKey();
                        break;
                    }
                    
                    else if (attack == "2") {
                        Console.Clear();
                        esteem = (esteem + 2);
                        confidance = (confidance + 2);
                        Console.WriteLine("The thug punches you, and you punch back");
                        Console.WriteLine("");
                        Console.WriteLine("A long and violent fight ensues, and the police are called");
                        Console.ReadKey();
                        while(true) {
                        Console.Clear();
                        Console.WriteLine("What do you do?");
                        Console.WriteLine("1. Try to run");
                        Console.WriteLine("2. Try to hide");
                        Console.WriteLine("3. Try to convince the police of your innocence");
                        string fightorflight = Console.ReadLine();     
                            if (fightorflight == "1") {
                                Console.Clear();
                                Console.WriteLine("You aren't fast enough, and the police catch you");
                                Console.ReadKey();
                                while (true) {
                                    Console.Clear();
                                    Console.WriteLine("You are taken to the station. Do you:");
                                    Console.WriteLine("");
                                    Console.WriteLine("1. Use the last of your money to bribe the guard");
                                    Console.WriteLine("2. Try to excape");
                                    Console.WriteLine("3. Wait for the trial");
                                    string prison = Console.ReadLine();
                                    if (prison == "1") {
                                        Console.Clear();
                                        Console.WriteLine("The guard takes all of your money, and sets you free.");
                                        Console.ReadKey();
                                        Console.WriteLine("Now penniless, you return to the bar.");
                                        broke = "1";
                                        Console.ReadKey();
                                        break;
                                    }
                                    else if (prison == "2") {
                                        Console.Clear();
                                        Console.WriteLine("The guard catches you!");
                                        Console.WriteLine("Press any key to retry");
                                        Console.ReadKey();
                                        
                                    }
                                    else if (prison == "3") {
                                        Console.Clear();
                                        Console.WriteLine("Since you have a clean criminal history (to the best of their knowledge), the jury sets you free");
                                        Console.WriteLine("The very next day, you return to the bar");
                                        esteem = (esteem + 2);
                                        Console.ReadKey();
                                        break;
                                    }
                                
                                }
                            break;
                            }
                            else if (fightorflight == "2") {
                                Console.Clear();
                                Console.WriteLine("you are just stealthy enough to hide from the police.");
                                Console.ReadKey();
                                Console.WriteLine("After a few hours, you return to the bar.");
                                esteem = (esteem + 1);
                                Console.ReadKey();
                                break;
                            }
                            else if (fightorflight == "3") {
                                Console.Clear();
                                Console.WriteLine("You successfuly convince the police of your innocence.");
                                Console.ReadKey();  
                                break;
                            }
                    
                        }

                        break;
                    }
            
                    else if (attack == "3") {
                        
                        Console.WriteLine("You knock the thug out with a single punch to the face! No one dares call the police");
                        confidance = (confidance + 1);
                        esteem = (esteem + 2);
                        fight = (fight + 1);
                        Console.ReadKey();
                        break;
                    }
                
                }
            break;
        
            }
            else if (charac == "runaway") {
                Console.Clear();
                Console.WriteLine("The fancy drink reminds you of home.");
                Console.WriteLine("You feel refreshsed and more confidant");
                esteem = (esteem + 1);
                confidance = (confidance + 2);
                Console.ReadKey();
                break;
            }
        }
    
        break;
        }
    
    }
break;

}
}
Console.Clear();
Console.WriteLine("Hours pass, and you grow bored. You look around the bar for someoe to approach.");
Console.ReadKey();
while(true) {
    Console.Clear();
    Console.WriteLine("Who do you approach?");
    Console.WriteLine("1. 2 strong-looking men arguing. You recognize one as the village blacksmith");
    Console.WriteLine("2. Police officers talking loudly by the bar");
    Console.WriteLine("3 A wealthy looking businessman surrounded by a group of rough-looking men");
    Console.WriteLine("4. A group of out-of-town merchants advertising their products");
    string approach = Console.ReadLine();

    if (approach == "1") {
        Console.Clear();
            Console.WriteLine("As you approach you hear the blacksmith and a frail looking man arguing");
        Console.ReadKey();
        Console.Clear();
            Console.WriteLine("As you approach you hear the blacksmith and a frail looking man arguing");
        Console.WriteLine("");
        Console.WriteLine("Blacksmith:  'Your inventions are overcomplicated and useless!'");
        Console.ReadKey();
        Console.Clear();
            Console.WriteLine("As you approach you hear the blacksmith and a frail looking man arguing");
        Console.WriteLine("");
        Console.WriteLine("Blacksmith:  'Your inventions are overcomplicated and useless!'");
        Console.WriteLine("");
        Console.WriteLine("Mystery man: 'Well, you only have the skills to make the crudest of tools!'");
        Console.ReadKey();
        Console.Clear();
            Console.WriteLine("As you approach you hear the blacksmith and a frail looking man arguing");
        Console.WriteLine("");
        Console.WriteLine("Blacksmith:  'Your inventions are overcomplicated and useless!'");
        Console.WriteLine("");
        Console.WriteLine("Mystery man: 'Well, you only have the skills to make the crudest of tools!'");
        Console.WriteLine();
        Console.WriteLine("Blacksmith:  'Oh please! there's no such thing as Trinketeer!'");
        Console.ReadKey();
        Console.Clear();
            Console.WriteLine("As you approach you hear the blacksmith and a frail looking man arguing");
        Console.WriteLine("");
        Console.WriteLine("Blacksmith:  'Your inventions are overcomplicated and useless!'");
        Console.WriteLine("");
        Console.WriteLine("Mystery man: 'Well, you only have the skills to make the crudest of tools!'");
        Console.WriteLine("");
        Console.WriteLine("Blacksmith:  'Oh please! there's no such thing as Trinketeer!'");
        Console.ReadKey();
        break;
    }
    
    else if (approach == "2") {
        Console.Clear();
        Console.WriteLine("2");
        
        Console.ReadKey();
        break;
    }

    else if (approach == "3") {
        Console.Clear();
        Console.WriteLine("3");
        Console.ReadKey();
        break;
    }

    else if (approach == "4") {
        Console.Clear();
        Console.WriteLine("4");
        Console.ReadKey();
        break;
    }

}
Console.WriteLine("Welcome to chapter 2!");