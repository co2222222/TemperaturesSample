using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TemperaturesSample
{
    public interface ISampleClass
    {
        void GetResult();
        void GetSummary();
    }

    public class SampleClass : ISampleClass
    {
        public int StartRange { get; set; }
        public int EndRange { get; set; }
        public int countDragonFly { get; set; }
        public int countAI { get; set; }
        public int countDragonFlyAI { get; set; }
        public int countInteger { get; set; }
        public string Result { get; set; }
        public string Summary { get; set; }

        public void GetResult()
        {
            string result = "";
            int i = StartRange;

            while (i <= EndRange)
            {
                if (IsDivisible(i, 3) && IsDivisible(i, 5))
                {
                    result += "DragonflyAI ";
                    countDragonFlyAI++;
                }
                else if (IsDivisible(i, 5))
                {
                    result += "AI ";
                    countAI++;
                }
                else if (IsDivisible(i, 3))
                {
                    result += "Dragonfly ";
                    countDragonFly++;
                }
                else
                {
                    result += string.Format("{0} ",i.ToString());
                    countInteger++;
                }
                i++;
            }
            Result = result;
        }

        public bool IsDivisible(int x, int n)
        {
            return (x % n) == 0;
        }
        public void  GetSummary()
        {

        }
    }


}
