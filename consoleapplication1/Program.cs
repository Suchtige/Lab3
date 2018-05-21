using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {

            scroll scroll1 = new scroll(1, "пиво", 10);
            product product1 = new product(1, "Балтика", scroll1, 0.5, 70, "Балтика продакшн");
            product1.info();
            Console.ReadLine();
            
        }
        
    }
}
