namespace ExploringVars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string heroFirstName = "Shawn";
            string heroLastName = "Tyson";
            string heroFullName;
            string villainTitle = "The Ghastly Regent";
            string minionTitle = "Impish Pipsqueak";
            string villainName;
            string minion1Name;
            string minion2Name;

            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength =5;

            //Begin Code Instructions
            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold the legendary hero of programming, whose name is: " + heroFullName);

            villainName = "Craig";
            minion1Name = "Bazzle";
            minion2Name = "Syndred";

            Console.WriteLine("In today's episode: " + heroFullName + " still must defeat " + villainTitle);
            //Don't Forget the Minions!!
            Console.WriteLine("First he must face off against " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name);
            Console.WriteLine("Fun Fact: " + villainTitle + " went by '" + villainName + "' before he turned evil.");

            //Are you prepared to fight!?
            Console.WriteLine("Our brave protagonist enters the room!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            Console.WriteLine("Minion 1's health: " + minion1Health);
            Console.WriteLine("Minion 2's health: " + minion2Health);
            
            //Time to fight!

            //The enemy strikes first! Yikes!
            //Boss Strikes first
            Console.WriteLine(villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainTitle + " deaks " + bossStrength + " damage!");
            //Take the current health, sub the damage then store the new val back into health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + "is now at " + heroHealth + " health!");
            //Minions Turn
            Console.WriteLine(villainTitle + "'s minions follow suit");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage!");
            //Take the current health, sub the damage then store the new val back into health
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + "is now at " + heroHealth + " health!");
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage!");
            //Take the current health, sub the damage then store the new val back into health
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + "now has " + heroHealth + " health!");

            //Our Hero Strikes Back!
            Console.WriteLine(heroFullName + " attacks each villain for " + heroStrength + " damage!");
            //do math
            //Take the current health, sub the damage then store the new val back into health
            //Though we're using the combination assignment and arithmetic operator here!
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;

            //Display results in the console
            Console.WriteLine(villainTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion1Health + " health!");

            //The minions have been defeated!
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated!");

            //End of round buff!
            Console.WriteLine(heroFullName + " has " + heroHealth + " health");
            Console.WriteLine(heroFullName + " eats an apple to restore health!");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Final round of fight
            Console.WriteLine("The remaining fighters continue the fight!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            //Boss strikes first this time
            Console.WriteLine(villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainTitle + " deaks " + bossStrength + " damage!");
            //Take the current health, sub the damage then store the new val back into health
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + "is now at " + heroHealth + " health!");
            //Our Hero Strikes Fiercely!
            Console.WriteLine(heroFullName + " attacks each villain for " + heroStrength + " damage!");
            //do math
            bossHealth -= heroStrength;
            //Display results in the console
            Console.WriteLine(villainTitle + " now has " + bossHealth + " health!");
            //Results
            Console.WriteLine(heroFullName + " is victorious!");
            Console.WriteLine("Huzzah for our glorious, beautiful hero!");
        }
    }
}
