using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static public void Main()
        {
            Student st = new Student(3, 5, "Иванов");
            st.Show();
            st.Avarage();
            Console.ReadKey();
        }


        class Student
        {
            string FIO;
            int ocenka1;
            int ocenka2;
            public Student(int oc1, int oc2, string fio)
            {
                this.FIO = fio;
                ocenka1 = oc1;
                ocenka2 = oc2;
            }
            public void Show()
            {
                Console.WriteLine("Фамилия: " + FIO + "     оценка1: " + ocenka1 + "    оценка2: " + ocenka2);
            }
            public void Avarage()
            {

                Console.WriteLine("Cредняя оценка = " + ((ocenka2 + ocenka1) / 2));
            }
        }
    }
}
