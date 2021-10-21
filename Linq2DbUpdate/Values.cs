using System;

namespace Linq2DbUpdate
{
    public static class Values
    {
        public static TestTableNotNull BuildTestRecord()
        {
            var x = Rnd.Next();
            var now = DateTime.Now;
            
            return new TestTableNotNull
            {
                Id = 1,
                Column01 = "value for c01 " + x,
                Column02 = "value for c02 " + x,
                Column03 = "value for c03 " + x,
                Column04 = "value for c04 " + x,
                Column05 = "value for c05 " + x,
                Column06 = "value for c06 " + x,
                Column07 = "value for c07 " + x,
                Column08 = "value for c08 " + x,
                Column09 = "value for c09 " + x,
                Column10 = "value for c10 " + x,
                Column11 = "value for c11 " + x,
                Column12 = "value for c12 " + x,
                Column13 = "value for c13 " + x,
                Column14 = "value for c14 " + x,
                Column15 = "value for c15 " + x,
                Column16 = "value for c16 " + x,
                Column17 = "value for c17 " + x,
                Column18 = "value for c18 " + x,
                Column19 = "value for c19 " + x,
                Column20 = 100 + x,
                Column21 = 100 + x,
                Column22 = 100 + x,
                Column23 = 100 + x,
                Column24 = 100 + x,
                Column25 = 100 + x,
                Column26 = 100 + x,
                Column27 = 100 + x,
                Column28 = 100 + x,
                Column29 = 100 + x,
                Column30 = now.AddDays(1),
                Column31 = now.AddDays(2),
                Column32 = now.AddDays(3),
                Column33 = now.AddDays(4),
                Column34 = now.AddDays(5),
                Column35 = now.AddDays(6),
                Column36 = now.AddDays(7),
                Column37 = now.AddDays(8),
                Column38 = now.AddDays(9),
                Column39 = now.AddDays(10),
                Column40 = true,
                Column41 = false,
                Column42 = true,
                Column43 = false,
                Column44 = true,
                Column45 = false,
                Column46 = true,
                Column47 = false,
                Column48 = true,
                Column49 = false,
                Column50 = 100.1m + x,
                Column51 = 100.1m + x,
                Column52 = 100.1m + x,
                Column53 = 100.1m + x,
                Column54 = 100.1m + x,
                Column55 = 100.1m + x,
                Column56 = 100.1m + x,
                Column57 = 100.1m + x,
                Column58 = 100.1m + x,
                Column59 = 100.1m + x,
            };
        }

        private static Random Rnd = new(Environment.TickCount);
    }
}