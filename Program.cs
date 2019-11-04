﻿using System;
using System.Collections.Generic;
using T2FSv1.Controller;
using T2FSv1.Entity;

namespace T2FSv1
{
    class Program
    {
        static void Main(string[] args)
        {
            //vulnerabilityLittle vulnerabilityModerate vulnerabilityMax
            IMemFunc vulnerabilityLittle = new TrapezeMF(0, 0, 2, 3.5, 0, 0, 1.5, 2.5);
            IMemFunc vulnerabilityModerate = new TrapezeMF(2.5, 3.5, 6.5, 7.5, 3.5, 4, 6, 6.5);
            IMemFunc vulnerabilityMax = new TrapezeMF(6, 9, 10, 10, 7.5, 9, 10, 10);

            //threatsLittle threatsSome threatsModeerate threatsLarge threatsMax
            IMemFunc threatsLittle = new TrapezeMF(0, 0, 2.5, 3.5, 0, 0, 1.5, 2.5);
            IMemFunc threatsSome = new TrapezeMF(1, 2.5, 3.5, 5, 2, 3, 3, 4);
            IMemFunc threatsModeerate = new TrapezeMF(2.5, 4, 6, 7.5, 3.5, 4, 6, 6.5);
            IMemFunc threatsLarge = new TrapezeMF(5, 6.5, 8.5, 10, 6, 7, 8, 9);
            IMemFunc threatsMax = new TrapezeMF(6, 9, 10, 10, 7.5, 9, 10, 10);

            //techDamageNegligble techDamageModerate techDamageCritical
            IMemFunc techDamageNegligble = new TrapezeMF(0, 0, 2, 3.5, 0, 0, 1.5, 2.5);
            IMemFunc techDamageModerate = new TrapezeMF(2.5, 3.5, 6.5, 7.5, 3.5, 4, 6, 6.5);
            IMemFunc techDamageCritical = new TrapezeMF(6, 9, 10, 10, 7.5, 9, 10, 10);

            //bizDamageNeglible bizDamageMinor bizDamageModerate bizDamageCritical bizDamageCatastrophic
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


            //vulnerabilityLittle                           vulnerabilityModerate                       vulnerabilityMax
            //threatsLittle         threatsSome             threatsModeerate        threatsLarge        threatsMax
            //techDamageNegligble                           techDamageModerate                          techDamageCritical
            //bizDamageNeglible     bizDamageMinor          bizDamageModerate       bizDamageCritical   bizDamageCatastrophic
            T2FS t2FS = new T2FS();
            t2FS.AddRule(new IMemFunc[] { vulnerabilityLittle, threatsLittle, techDamageNegligble, bizDamageNeglible }, rezultLow, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { vulnerabilityLittle, threatsSome, techDamageNegligble, bizDamageNeglible }, rezultLow, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { vulnerabilityLittle, threatsLittle, techDamageNegligble, bizDamageMinor }, rezultLow, ref ruleList);

            t2FS.AddRule(new IMemFunc[] { vulnerabilityModerate, threatsModeerate, techDamageModerate, bizDamageMinor }, rezultMedium, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { vulnerabilityModerate, threatsSome, techDamageModerate, bizDamageMinor }, rezultMedium, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { vulnerabilityModerate, threatsLarge, techDamageModerate, bizDamageMinor }, rezultMedium, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { vulnerabilityModerate, threatsModeerate, techDamageModerate, bizDamageCritical }, rezultMedium, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { vulnerabilityModerate, threatsModeerate, techDamageModerate, bizDamageMinor }, rezultMedium, ref ruleList);

            t2FS.AddRule(new IMemFunc[] { vulnerabilityModerate, threatsLarge, techDamageModerate, bizDamageCritical }, rezultHigh, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { vulnerabilityMax, threatsLarge, techDamageModerate, bizDamageCritical }, rezultHigh, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { vulnerabilityModerate, threatsLarge, techDamageModerate, bizDamageCritical }, rezultHigh, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { vulnerabilityModerate, threatsLarge, techDamageCritical, bizDamageCritical }, rezultHigh, ref ruleList);

            t2FS.AddRule(new IMemFunc[] { vulnerabilityMax, threatsMax, techDamageCritical, bizDamageCatastrophic }, rezultExtreme, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { vulnerabilityMax, threatsLarge, techDamageCritical, bizDamageCatastrophic }, rezultExtreme, ref ruleList);
            t2FS.AddRule(new IMemFunc[] { vulnerabilityMax, threatsMax, techDamageCritical, bizDamageCritical }, rezultExtreme, ref ruleList);

            double vulnerability = 10.0;
            double threats = 1.0;
            double techDamage = 1.0;
            double bizDamage = 1.0;

            Console.WriteLine("vulnerability : " + vulnerability);
            Console.WriteLine("threats : " + threats);
            Console.WriteLine("Tech Damage : " + techDamage);
            Console.WriteLine("Biz Damage : " + bizDamage);

            t2FS = new T2FS(ruleList, new double[] { vulnerability, threats, techDamage, bizDamage });
            Console.WriteLine(t2FS.Calculete());
            Console.ReadLine();

        }
    }
}
