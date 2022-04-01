using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Lotto
    {
        private List<int> lottoSzamok;

        public Lotto()
        {
            this.lottoSzamok = new List<int>();
        }

        public void LottoSzamok()
        {
            Random rnd = new Random();
            while (this.lottoSzamok.Count != 5)
            {
                int x = rnd.Next(1, 91);
                if (!this.lottoSzamok.Contains(x))
                {
                    this.lottoSzamok.Add(x);
                }
            }
        }

        public List<int> getLottoSzamok()
        {
            return this.lottoSzamok;
        }
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            Lotto lotto = new Lotto();

            lotto.LottoSzamok();

            foreach (var item in lotto.getLottoSzamok())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
