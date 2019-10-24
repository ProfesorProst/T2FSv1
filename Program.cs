using System;
using System.Collections.Generic;

namespace T2FSv1
{
    class Program
    {
        static void Main(string[] args)
        {

            IMemFunc Rancid = new TrapezeMF(0, 0, 1, 5, 0, 0, 0.5, 4.5);
            IMemFunc Delicious = new TrapezeMF(4, 8, 9, 9, 4.5, 8.5, 9, 9);

            IMemFunc PoorService = new TrapezeMF(0, 0, 1, 3, 0, 0, 0.5, 2.5);
            IMemFunc GoodService = new TrapezeMF(1, 3, 5, 7, 1.5, 3.5, 4.5, 6.5);
            IMemFunc ExcellentService = new TrapezeMF(5, 7, 9, 9, 5.5, 7.5, 9, 9);

            IMemFunc CheapTip = new TrapezeMF(0, 3, 3, 6, 1, 3, 3, 5);
            IMemFunc AverageTip = new TrapezeMF(5, 7.5, 7.5, 10, 6, 7.5, 7.5, 9);
            IMemFunc GenerousTip = new TrapezeMF(9, 12, 12, 15, 10, 12, 12, 14);

            List<IMemFunc> antc = new List<IMemFunc>();
            List<IMemFunc> cons = new List<IMemFunc>();

            List<Rule> ruleList = new List<Rule>();

            antc.Add(Rancid); antc.Add(PoorService); cons.Add(CheapTip);
            ruleList.Add(new Rule(antc, cons, new ProductTnorm()));
            antc.Clear(); cons.Clear();

            antc.Add(Rancid); antc.Add(GoodService); cons.Add(CheapTip);
            ruleList.Add(new Rule(antc, cons, new ProductTnorm()));
            antc.Clear(); cons.Clear();

            antc.Add(Rancid); antc.Add(ExcellentService); cons.Add(AverageTip);
            ruleList.Add(new Rule(antc, cons, new ProductTnorm()));
            antc.Clear(); cons.Clear();

            antc.Add(Delicious); antc.Add(PoorService); cons.Add(AverageTip);
            ruleList.Add(new Rule(antc, cons, new ProductTnorm()));
            antc.Clear(); cons.Clear();

            antc.Add(Delicious); antc.Add(GoodService); cons.Add(AverageTip);
            ruleList.Add(new Rule(antc, cons, new ProductTnorm()));
            antc.Clear(); cons.Clear();

            antc.Add(Delicious); antc.Add(ExcellentService); cons.Add(GenerousTip);
            ruleList.Add(new Rule(antc, cons, new ProductTnorm()));
            antc.Clear(); cons.Clear();

            double x = 1.0;
            double y = 1.0;

            Console.WriteLine("Food Quality : " + x);
            Console.WriteLine("Service Level : " + y);

            T2FS t2FS = new T2FS(ruleList, new double[] { x, y }) ;
            Console.WriteLine(t2FS.Calculete());
            Console.ReadLine();
        }


    }
}
