using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaiduApdorojimas
{
    internal class Program
    {
        private class ManoIsimtis : Exception
        {
            public int MyProperty { get; set; }

            public ManoIsimtis()
            {
            }

            public ManoIsimtis(string message) : base(message)
            {
            }
        }

        private static void Main(string[] args)
        {
            string[] skaiciai = { "1", "-10", "1.8", "KK", "20" };
            string a = null;
            for (int i = 0; i < 6; i++)
            {
                try
                {
                    int skaicius = int.Parse(skaiciai[i]);
                    Console.WriteLine(skaicius);
                    if (i % 3 == 0)
                    {
                        throw new ManoIsimtis("Mano sugeneruotas exception");
                    }
                    if (a == null)
                    {
                        throw new Exception("Nesuinicializuota a");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Formatas netinkamas");
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Masyvas out of range");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}