using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace DungeonMonsters
{
    public class TheOneReborn : Monster
    {
        //No fielsd

        //properties

        //ctors-- create a FQCTOR that we can use to create a horrible rabbit, and then create a default ctor.
        public TheOneReborn(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description)
            : base(maxLife, maxDamage, minDamage, name, life, hitChance, block, description)
        {
            //just handle unique properties

        }
        //set some values for a basic monster of this type in the default ctor
        public TheOneReborn()
        {
            MaxLife = 40;
            MaxDamage = 32;
            MinDamage = 4;
            Name = "The One Reborn";
            Life = 36;
            HitChance = 24;
            Block = 2;

            Description = "The One Reborn is an amalgamate of grotesque misshapen body parts assembled to form one massive unliving creature. \nIt has a singular giant humanoid torso attached to the entire mass which controls its entire being, though other parts of its body seem just as independently alive as the humanoid on top of the horrific creature.";

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