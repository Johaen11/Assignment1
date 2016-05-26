using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author's Name: Johaen Gnanakumar;
 * Author’s	student	number: 300880309
 *  Date	last	Modified:
 * Program	description:
 *  Revision History:
 *  		
 */
namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Johaen");
            hero.Show();

            hero.Fight();
        }
    }
}
