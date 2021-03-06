﻿/*
 *Author: Raveena Tayal
 *Last Modified on 1/30/2015
 *Program Description: Create a Hero class with strength, speed, health and name properties. Assign a random 
 *                     number between 1 and 100 (both inclusive) to the abilities and display them using a method.
 *                     Also determine the damage if hero hits the target and display appropriate messages to the 
 *                     console. Implement the class by creating a new hero object and call show() and fight() 
 *                     methods.
 *Revision History: 
 *                 Revision: 8
 *                 Modified: 1/30/2015(5:24 pm)
 *                 Author: Raveena Tayal
 *                 Log Entry: Extra features added by creating 3 methods to check abilities of hero and 
 *                 modifying the output
 *                 -----------------------------------------------------------------------
 *                 Revision: 7
 *                 Modified: 1/30/2015(4:46 pm)
 *                 Author: Raveena Tayal
 *                 Log Entry: Modified Program.cs 
 *                 -----------------------------------------------------------------------
 *                 Revision: 6
 *                 Modified: 1/30/2015(4:40 pm)
 *                 Author: Raveena Tayal
 *                 Log Entry: Implemented Hero class by creating hero object in Program.cs 
 *                 -----------------------------------------------------------------------
 *                 Revision: 5
 *                 Modified: 1/30/2015(4:29 pm)
 *                 Author: Raveena Tayal
 *                 Log Entry: Added show() method 
 *                 -----------------------------------------------------------------------
 *                 Revision: 4
 *                 Modified: 1/30/2015(3:38 pm)
 *                 Author: Raveena Tayal             
 *                 Log Entry: Added fight(), hitAttempt() and hitDamage() methods
 *                 -----------------------------------------------------------------------
 *                 Revision: 3
 *                 Modified: 1/30/2015(3:18 pm)
 *                 Author: Raveena Tayal
 *                 Log Entry: Modified generateAbilities method to include 100
 *                 -----------------------------------------------------------------------
 *                 Revision: 2
 *                 Modified: 1/30/2015(3:16 pm)
 *                 Author: Raveena Tayal
 *                 Log Entry: Added generateAbilities method to assign values to abilities
 *                 -----------------------------------------------------------------------
 *                 Revision: 1
 *                 Modified: 1/30/2015(3:13 pm)
 *                 Author: Raveena Tayal
 *                 Log Entry: Created Hero class with properties and constructor
 *                 -----------------------------------------------------------------------
 */
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
                Console.WriteLine("Yay!!!!! \n Hit Attempt successful!!!!!");
                Console.WriteLine("Damage caused to the target: {0}", damage);
            }
            else
            {
                Console.WriteLine("Oops!!!!! Hit Attempt unsuccessful!!!!!");
                Console.WriteLine("No damage caused to the target");
            }
        }

        //---Creating a method to return whether the hero hit the target or not-------
        private bool hitAttempt()
        {
            //Generating a random number between 1 and 100 (both inclusive)
            int hitTime = ran.Next(1, 101);
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

        //---Creating a method to check strength of hero 
        public void checkStrength()
        {
            if(this.strength<50)
            {
                Console.WriteLine("Watch out. Your hero is not strong enough!!!!");
            }
            else
            {
                Console.WriteLine("Wow !!! How strong your hero is!!");
            }
        }

        //---Creating a method to check speed of hero 
        public void checkSpeed()
        {
            if (this.speed < 50)
            {
                Console.WriteLine("Omg!!! Your hero is so slow!!");
            }
            else
            {
                Console.WriteLine("Amazing speed!!!");
            }
        }
        
        // Creating a method to check health of hero
        public void checkHealth()
        {
            if (this.health < 40)
            {
                Console.WriteLine("Look. Your hero isn't healthy enough!!!");
            }
            else
            {
                Console.WriteLine("Hero is quite healthy!!!");
            }
        }

        //---Creating a method to display ablities of hero
        public void show()
        {

            Console.WriteLine("\n*******************************\n");
            Console.WriteLine("Yay!!!{0} is the hero !!!!\n", this.name);
            Console.WriteLine("{0} has followin' abilities::\n", this.name);
            Console.Write("  Strength: {0}  --->  ", this.strength);
            checkStrength();
            Console.Write("  Speed: {0}  --->  ", this.speed);
            checkSpeed();
            Console.Write("  Health: {0}  --->  ", this.health);
            checkHealth();
            Console.WriteLine("\n*******************************\n");
        }
    }
}
