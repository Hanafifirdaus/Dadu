using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dadu
{
    class Proses
    {
        public void test()
        {
            int temp;
            string a;

            int[] array = new int[5];

            for (int s = 0; s < array.Length; s++)
            {
                Console.Write("Masukkan Dadu ke- " + s + " = ");
                a = Console.ReadLine();
                array[s] = int.Parse(a);
            }

            int[] nilai = new int[7];
            int hasil = 0;

            for (int i = 1; i < 7; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i == array[j])
                    {
                        nilai[i] = nilai[i] + 1;
                        array[j] = 0;
                    }
                }
            }

            for (int l = 1; l < nilai.Length; l++)
            {
                if (l == 1)
                {
                    if (nilai[l] > 3)
                    {
                        temp = nilai[l] - 3;
                        hasil = 1000 + (temp * 100);
                    }

                    if (nilai[l] == 3)
                    {
                        hasil = hasil + 1000;
                    }
                }

                if (l == 5)
                {
                    if (nilai[l] < 3)
                    {
                        hasil = hasil + nilai[l] * 50;
                    }

                    if (nilai[l] >= 3)
                    {
                        temp = nilai[l] - 3;
                        hasil = hasil + 300 + (temp * 50);
                    }
                }

                if (nilai[l] >= 3)
                {
                    if ((l != 1) && (l != 5))
                    {
                        hasil = hasil + (l * 100);
                    }
                }

            }

            Console.WriteLine();
            Console.WriteLine("hasilnya adalah = " + hasil);
            Console.ReadKey();
            Console.Clear();

            test();
        }
    }
}
