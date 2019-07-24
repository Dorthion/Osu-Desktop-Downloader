using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuDesktop
{
    class BeatmapCalculator
    {
        protected double AimValue = 0;
        protected double SpeedValue = 0;
        protected double AccValue = 0;
        protected double TotalValue;
        internal ushort NumMiss = 0;
        internal ushort NumGeki = 0;
        internal ushort NumKatu = 0;
        internal ushort Num50 = 0;
        internal ushort Num100 = 0;
        internal ushort Num300 = 0;

        private int TotalHits() => NumMiss + Num50 + Num100 + Num300;
        private int TotalSuccHits() => Num50 + Num100 + Num300;

        internal float CalcAcc()
        {
            if (TotalHits() == 0)
                return 0;
            return (Num50 * 50 + Num100 * 100 + Num300 * 300) / (TotalHits() * 300);
        }

        internal float CalcTotalValue()
        {
            //if(relax/autoplay)
            //return 0;
            float Multiplaier = 1.12f;
            //if(nofail>0)
            //  Multiplaier *= 0.9f;
            //if(SpunOut>0)
            //  Multiplaier *= 0.95f;

            //Ended at 100l

            TotalValue = Math.Pow(
                Math.Pow(AimValue, 1.1f) +
                Math.Pow(SpeedValue, 1.1f) +
                Math.Pow(AccValue, 1.1f), 1.0f / 1.1f
            ) * Multiplaier;
            return 0;
        }
        
    }
}
