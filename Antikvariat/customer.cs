using System;
using System.Collections.Generic;

namespace Antikvariat
{
    public class customer
    {
        List<custom> listcustomer = new List<custom>();
        //listar upp böcker från klassen custom

        public customer(int count)
        {
            for (int i = 0; i < count; i++)
            {
                custom newcustom = new custom();

                System.Console.WriteLine("");
                listcustomer.Add(newcustom);
            }
        }
    }
}
