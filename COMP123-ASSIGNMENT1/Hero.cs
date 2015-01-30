using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_ASSIGNMENT1
{
    //---Created a Hero class---------------------------------------------------------
    class Hero
    {
        //----------------------------PRIVATE PROPERTIES------------------------------
        private int strength;
        private int speed;
        private int health;

        //----------------------------PUBLIC PROPERTIES-------------------------------
        public string name;

        //Instantiating object for pre-defined Random class
        Random ran = new Random();

        //----------------------------PARAMETERISED CONSTRUCTOR-----------------------
        public Hero(string name)
        {
            //---Assigning a value to the name property-------------------------------
            this.name = name;
            this.generateAbilities(); // Calling generateAbilities() method
        }

        //---Creating a method to assign values to the abilities of Hero--------------
        private void generateAbilities()
        {
            //Choosing a random number between 1 and 100 (both inclusive) for strength,speed and health
            this.strength = ran.Next(1, 101);
            this.speed = ran.Next(1, 101);
            this.health = ran.Next(1, 101);
        }

        //---Creating a method to display the damage caused to the target-------------
        public void fight()
        {
            int damage; //Damage caused to target
            //Checking whether the hero hits the target or not
            if (hitAttempt())
            {
                damage = hitDamage(); //Calling hitDamage method to calculate damage 
                Console.WriteLine("Yay!!!!! /n Hit Attempt successful!!!!!");
                Console.WriteLine("Damage caused to the target: {0}", damage);
            }
            else
            {
                Console.WriteLine("Oops!!!!! Hit Attempt unsuccessful!!!!!");
                Console.WriteLine("Hero missed the target!!!!!");
                Console.WriteLine("No damage caused to the target");
            }
        }

        //---Creating a method to return whether the hero hit the target or not-------
        private bool hitAttempt()
        {
            //Generating a random number between 1 and 100 (both inclusive)
            double hitTime = ran.Next(1, 101);
            //Checking if hitTime is less than or equal to 20
            if (hitTime<= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //---Creating a method to calculate damage caused to the target
        private int hitDamage()
        {
            //Calculating damage by multiplyin' strength by number between 1 and 6
            int damage = this.strength * ran.Next(1, 7);
            return damage;
        }
    }
}
