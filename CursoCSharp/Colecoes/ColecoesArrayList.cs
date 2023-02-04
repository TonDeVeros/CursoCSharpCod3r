using System;
using System.Collections;
using System.Collections.Generic;//arraylist não usa Generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class ColecoesArrayList
    {
        public static void Executar()
        {
            var arrayList = new ArrayList
            {
                 "palavra"
                ,3
                ,true
            };

            arrayList.Add(3.14);

            foreach (var item in arrayList) //posso também colocar o object que é um tipo mais generico
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
