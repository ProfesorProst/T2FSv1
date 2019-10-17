using System;

namespace T2FSv1
{
    class Program
    {
        static void Main(string[] args)
        {

            MemFunc Rancid = new TrapezeMF(0, 0, 1, 5, 0, 0, 0.5, 4.5);
            MemFunc Delicious = new TrapezeMF(4, 8, 9, 9, 4.5, 8.5, 9, 9);

            MemFunc PoorService = new TrapezeMF(0, 0, 1, 3, 0, 0, 0.5, 2.5);
            MemFunc GoodService = new TrapezeMF(1, 3, 5, 7, 1.5, 3.5, 4.5, 6.5);
            MemFunc ExcellentService = new TrapezeMF(5, 7, 9, 9, 5.5, 7.5, 9, 9);

            MemFunc CheapTip = new TrapezeMF(0, 3, 3, 6, 1, 3, 3, 5);
            MemFunc AverageTip = new TrapezeMF(5, 7.5, 7.5, 10, 6, 7.5, 7.5, 9);
            MemFunc GenerousTip = new TrapezeMF(9, 12, 12, 15, 10, 12, 12, 14);

            List<MemFunc> antc = new ArrayList<MemFunc>();
            List<MemFunc> cons = new ArrayList<MemFunc>();

            List<Rule> ruleList = new ArrayList<Rule>();

            antc.add(Rancid); antc.add(PoorService); cons.add(CheapTip);
            ruleList.add(new Rule(antc, cons, new ProductTnorm()));
            antc.clear(); cons.clear();

            antc.add(Rancid); antc.add(GoodService); cons.add(CheapTip);
            ruleList.add(new Rule(antc, cons, new ProductTnorm()));
            antc.clear(); cons.clear();

            antc.add(Rancid); antc.add(ExcellentService); cons.add(AverageTip);
            ruleList.add(new Rule(antc, cons, new ProductTnorm()));
            antc.clear(); cons.clear();

            antc.add(Delicious); antc.add(PoorService); cons.add(AverageTip);
            ruleList.add(new Rule(antc, cons, new ProductTnorm()));
            antc.clear(); cons.clear();

            antc.add(Delicious); antc.add(GoodService); cons.add(AverageTip);
            ruleList.add(new Rule(antc, cons, new ProductTnorm()));
            antc.clear(); cons.clear();

            antc.add(Delicious); antc.add(ExcellentService); cons.add(GenerousTip);
            ruleList.add(new Rule(antc, cons, new ProductTnorm()));
            antc.clear(); cons.clear();

            Tipping tipping = new Tipping();

            double x = 2.0;
            double y = 8.0;

            System.out.println("Food Quality : " + x);
            System.out.println("Service Level : " + y);
            System.out.println(tipping.findTip(ruleList, x, y));

        }
    }
}
