using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandIntefaces
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List
            List<string> lstString = new List<string>();
            lstString.Add("Toon");
            lstString.Add("Emre");
            lstString.Add("Jarno");
            lstString.Add("Mauro");
            lstString.Add("Francis");
            lstString.Sort();
            /* Display(lstString)*/
            
            #endregion

            #region IList
            IList<string> ilstString = new List<string>();
            ilstString.Add("Toon");
            ilstString.Add("Tim");
            ilstString.Add("Jan");
            ilstString.Add("Maria");
            //ilstString.Sort();

           // DiplayIList(ilstString);
            //Display(ilstString);

            #endregion

            #region ICollection

            ICollection<string> collString = new List<string>();
            collString.Add("Toon");
            collString.Add("Tim");
            collString.Add("Jan");
            collString.Add("Maria");

            foreach (var item in collString)
            {
                Console.WriteLine(item);
            }

           // DisplayIcollection(collString);

            #endregion


        }

        private static void DisplayIcollection(ICollection<string> lst)
        {
            
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }
        private static void DiplayIList(IList<string> lst) // it can accept any class that implements Ilist
        {
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }
        private static void Display(List<string> lst)
        {
            
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }
}
