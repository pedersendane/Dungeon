using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace DungeonMonsters
{
    public class BloodStarvedBeast : Monster
    {
        //No fielsd

        //properties

        //ctors-- create a FQCTOR that we can use to create a horrible rabbit, and then create a default ctor.
        public BloodStarvedBeast(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description)
            : base(maxLife, maxDamage, minDamage, name, life, hitChance, block, description)
        {
            //just handle unique properties

        }
        //set some values for a basic monster of this type in the default ctor
        public BloodStarvedBeast()
        {
            MaxLife = 40;
            MaxDamage = 32;
            MinDamage = 4;
            Name = "Blood Starved Beast";
            Life = 36;
            HitChance = 24;
            Block = 2;

            Description = "A tentacled beast-like creature made of exposed flesh and bone that stands 30 feet tall.";

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