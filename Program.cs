using System;
using System.Collections.Generic;

namespace T2FSv1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMemFunc vulnerabilityLittle = new TrapezeMF(0, 0, 2, 3.5, 0, 0, 1.5, 2.5);
            IMemFunc vulnerabilityModerate = new TrapezeMF(2.5, 3.5, 6.5, 7.5, 3.5, 4, 6, 6.5);
            IMemFunc vulnerabilityMax = new TrapezeMF(6, 9, 10, 10, 7.5, 9, 10, 10);

            IMemFunc threatsLittle = new TrapezeMF(0, 0, 2.5, 3.5, 0, 0, 1.5, 2.5);
            IMemFunc threatsSome = new TrapezeMF(1, 2.5, 3.5, 5, 2, 3, 3, 4);
            IMemFunc threatsModeerate = new TrapezeMF(2.5, 4, 6, 7.5, 3.5, 4, 6, 6.5);
            IMemFunc threatsLarge = new TrapezeMF(5, 6.5, 8.5, 10, 6, 7, 8, 9);
            IMemFunc threatsMax = new TrapezeMF(6, 9, 10, 10, 7.5, 9, 10, 10);

            IMemFunc techDamageNegligble = new TrapezeMF(0, 0, 2, 3.5, 0, 0, 1.5, 2.5);
            IMemFunc techDamageModerate = new TrapezeMF(2.5, 3.5, 6.5, 7.5, 3.5, 4, 6, 6.5);
            IMemFunc techDamageCritical = new TrapezeMF(6, 9, 10, 10, 7.5, 9, 10, 10);

            IMemFunc bizDamageNeglible = new TrapezeMF(0, 0, 2.5, 3.5, 0, 0, 1.5, 2.5);
            IMemFunc bizDamageMinor = new TrapezeMF(1, 2.5, 3.5, 5, 2, 3, 3, 4);
            IMemFunc bizDamageModerate = new TrapezeMF(2.5, 4, 6, 7.5, 3.5, 4, 6, 6.5);
            IMemFunc bizDamageCritical = new TrapezeMF(5, 6.5, 8.5, 10, 6, 7, 8, 9);
            IMemFunc bizDamageCatastrophic = new TrapezeMF(6, 9, 10, 10, 7.5, 9, 10, 10);

            IMemFunc rezultLow = new TrapezeMF(0, 0, 1.5, 3.5, 0, 0, 1.5, 2.5);
            IMemFunc rezultMedium = new TrapezeMF(1, 2.5, 4.5, 6.5, 2, 3, 4, 5.5);
            IMemFunc rezultHigh = new TrapezeMF(4, 5.5, 7.5, 9, 5, 6, 7, 8);
            IMemFunc rezultExtreme = new TrapezeMF(7, 8.5, 10, 10, 8, 8.5, 10, 10);

            List<IMemFunc> antc = new List<IMemFunc>();
            List<IMemFunc> cons = new List<IMemFunc>();

            List<Rule> ruleList = new List<Rule>();

            T2FS t2FS = new T2FS();
            t2FS.AddRule(new IMemFunc[] { vulnerabilityLittle, threatsLittle, techDamageNegligble, bizDamageNeglible },rezultLow, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { vulnerabilityMax, threatsLittle, techDamageNegligble, bizDamageNeglible }, rezultHigh, ref ruleList);


            double x = 10.0;
            double y = 1.0;
            double z = 1.0;
            double c = 1.0;

            Console.WriteLine("Food Quality : " + x);
            Console.WriteLine("Service Level : " + y);

            t2FS = new T2FS(ruleList, new double[] { x, y, z, c});
            Console.WriteLine(t2FS.Calculete());
            Console.ReadLine();

            //-------------------------
            /*
            IMemFunc Rancid = new TrapezeMF(0, 0, 1, 5, 0, 0, 0.5, 4.5);
            IMemFunc Delicious = new TrapezeMF(4, 8, 9, 9, 4.5, 8.5, 9, 9);

            IMemFunc PoorService = new TrapezeMF(0, 0, 1, 3, 0, 0, 0.5, 2.5);
            IMemFunc GoodService = new TrapezeMF(1, 3, 5, 7, 1.5, 3.5, 4.5, 6.5);
            IMemFunc ExcellentService = new TrapezeMF(5, 7, 9, 9, 5.5, 7.5, 9, 9);

            IMemFunc CheapTip = new TrapezeMF(0, 3, 3, 6, 1, 3, 3, 5);
            IMemFunc AverageTip = new TrapezeMF(5, 7.5, 7.5, 10, 6, 7.5, 7.5, 9);
            IMemFunc GenerousTip = new TrapezeMF(9, 12, 12, 15, 10, 12, 12, 14);
            
            ruleList = new List<Rule>();

             t2FS = new T2FS();
            t2FS.AddRule(new IMemFunc[] { Rancid, PoorService}, CheapTip, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { Rancid, GoodService }, CheapTip, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { Rancid, ExcellentService }, AverageTip, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { Delicious, PoorService }, AverageTip, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { Delicious, GoodService }, AverageTip, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { Delicious, ExcellentService }, GenerousTip, ref ruleList);

             x = 1.0;
             y = 1.0;

            Console.WriteLine("Food Quality : " + x);
            Console.WriteLine("Service Level : " + y);

            t2FS = new T2FS(ruleList, new double[] { x, y }) ;
            Console.WriteLine(t2FS.Calculete());
            Console.ReadLine();
            */
        }




    }
}
