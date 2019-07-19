using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace DungeonMonsters
{
    public class Rabbit : Monster
    {
        //No fields

        //properties
        public bool IsFluffy
        {
            get; set;
        }

        //ctors-- create a FQCTOR that we can use to create a horrible rabbit, and then create a default ctor.
        public Rabbit(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool isFluffy)
            : base(maxLife, maxDamage, minDamage, name, life, hitChance, block, description)
        {
            //just handle unique properties
            IsFluffy = isFluffy;
        }
        //set some values for a basic monster of this type in the default ctor
        public Rabbit()
        {
            MaxLife = 6;
            MaxDamage = 3;
            MinDamage = 1;
            Name = "Baby Rabbit";
            Life = 6;
            HitChance = 20;
            Block = 20;

            Description = "It's just a  bunny.";
            IsFluffy = false;
        }//prop

        //methods
        public override string ToString()
        {
            return base.ToString() + ((IsFluffy) ? "Fluffy" : "Not so fluffy");
        }//tostring

        public override int CalcBlock()
        {
            //return base.CalcBlock();
            //Typically when dealing witha  method that has a return type, you will create a variable of the type that you need to return with 
            // -- some defaut value. Then, you will write the return line, and then write the code in between. 
            int calculatedBlock = Block;

            if (IsFluffy)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }
    }
}
