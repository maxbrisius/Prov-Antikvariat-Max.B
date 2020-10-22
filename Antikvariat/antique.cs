using System.CodeDom.Compiler;
using System.Threading.Tasks.Dataflow;
using System;

namespace Antikvariat
{
    public class antique
    {
        public string book;
        public int rarity;

        public int actualValue;

        public string name;
        Random generator = new Random();

        public book (string t)//skrev in string och det löste det
        {
            rarity = generator.Next(1,100);
            actualValue = generator.Next(1,100);
            //slumpar värden för rarity och actual
            //verkar inte fungera men du förstår principen


        }
        //vrf är du röd

       
    }
    
}
//Jag fattar noll