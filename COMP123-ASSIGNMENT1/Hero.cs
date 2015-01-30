using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_ASSIGNMENT1
{
    //---Created a Hero class-----------------------------
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

        //---Creating a method to assign values to the abilities of Hero-------------
        private void generateAbilities()
        {
            //Choosing a random number between 1 and 100 for strength,speed and health
            this.strength = ran.Next(1, 100);
            this.speed = ran.Next(1, 100);
            this.health = ran.Next(1, 100);
        }
    }
}
