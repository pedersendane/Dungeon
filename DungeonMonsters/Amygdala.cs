using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace DungeonMonsters
{
    public class Amygdala : Monster
    {
        //No fields

        //properties

        //ctors-- create a FQCTOR that we can use to create a horrible rabbit, and then create a default ctor.
        public Amygdala(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description)
            : base(maxLife, maxDamage, minDamage, name, life, hitChance, block, description)
        {
            //just handle unique properties

        }
        //set some values for a basic monster of this type in the default ctor
        public Amygdala()
        {
            MaxLife = 20;
            MaxDamage = 20;
            MinDamage = 1;
            Name = "Amygdala";
            Life = 30;
            HitChance = 30;
            Block = 2;

            Description = "This being takes a form that is more or less arachnoid, with seven arms and standing 100ft tall. It has six \nclawed fingers on each hand, two of which display a glowing light on the palm, and its legs are hunched and bent like a reptile. The head consists of an almond shaped organic cage containing the brain, which is host to dozens of large lidless yellow eyes,";

        }//prop

        //methods
        public override string ToString()
        {
            return base.ToString();
        }//tostring

        //public override int CalcBlock()***************TODO
        //{
        //    //return base.CalcBlock();
        //    //Typically when dealing witha  method that has a return type, you will create a variable of the type that you need to return with 
        //    // -- some defaut value. Then, you will write the return line, and then write the code in between. 
        //    int calculatedBlock = Block;


        //}
    }
}
