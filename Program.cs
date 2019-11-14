using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var diary = new OOPCSEntities();
            var list = diary.Expenditures.ToArray();
            int sum = 0;
            for (int i =0; i < list.Length; i++)
            {
                sum = sum + list[i].Price;
                //Console.WriteLine("ID=" + list[i].id, "Date=" + list[i].Date, "Price =" + list[i].Price);
                Console.WriteLine("Tong chi tieu :" + sum);
            }
            diary.Dipose();
        }
    }
}
