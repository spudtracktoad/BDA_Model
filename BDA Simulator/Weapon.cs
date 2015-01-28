using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDA_Simulator
{
    /// <summary>
    /// This is a model of each weapon system
    /// </summary>
    /// <remarks>The weapon will have a name, chance to hit Offensive Moving, 
    /// Offensive Stationary Targets, and Defensive Moving, Defensive Stationary Targets.  
    /// Will have chance to netrulize Light Armor, Medium Armor, and Heavy Armor, and 
    /// total chance to neturlize any system, and an Offensive and defensive chance to 
    /// neturlize any system.</remarks>
    public class Weapon
    {
        private String strName;
        private Double dblUse;
        private int intTotal;
        private int intTotalOffensive;
        private int intTotalDefensive;
        private Double dblHitOM;
        private Double dblHitOS;
        private Double dblHitDM;
        private Double dblHitDS;
        private Double dblNLA;
        private Double dblNMA;
        private Double dblNHA;

        //Methods
        public Weapon(Double use, Double HitOM, Double HitOS,
                                  Double HitDM, Double HitDS,
                                  Double NeturlizeLA, Double NeturlizeMA,
                                  Double NeturlizeHA)
        {
            dblUse = use;
            dblHitDM = HitDM;
            dblHitOM = HitOM;
            dblHitDS = HitDS;
            dblHitOS = HitOS;
            dblNHA = NeturlizeHA;
            dblNMA = NeturlizeMA;
            dblNLA = NeturlizeLA;
            CalculateTotal();
            CalculateTotalDefensive();
            CalculateTotalOffensive();
        }
        public Weapon()
        {
            dblUse = 1;
            dblHitDM = .5;
            dblHitOM = .5;
            dblHitDS = .5;
            dblHitOS = .5;
            dblNHA = .5;
            dblNMA = .5;
            dblNLA = .5;
        }
        private void CalculateTotal()
        {
            DblTotal = Convert.ToInt32(((DblUse * DblHitDM * DblHitOM * DblHitDS * DblHitOS * DblNHA * DblNMA * DblNLA) * 100));
        }
        private void CalculateTotalOffensive()
        {
            DblTotalOffensive = Convert.ToInt32(((DblUse * DblHitOM * DblHitOS * DblNHA * DblNMA * DblNLA) * 100));
        }
        private void CalculateTotalDefensive()
        {
            DblTotalDefensive = Convert.ToInt32(((DblUse * DblHitDM * DblHitDS * DblNHA * DblNMA * DblNLA) * 100));
        }

        //Properties
        public String StrName
        {
            get { return strName; }
            set { strName = value; }
        }
        public Double DblNHA
        {
            get { return dblNHA; }
            set
            {
                dblNHA = value;
                CalculateTotal();
                CalculateTotalDefensive();
                CalculateTotalOffensive();
            }
        }
        public Double DblNMA
        {
            get { return dblNMA; }
            set
            {
                dblNMA = value;
                CalculateTotal();
                CalculateTotalDefensive();
                CalculateTotalOffensive();
            }
        }
        public Double DblNLA
        {
            get { return dblNLA; }
            set 
            {
                dblNLA = value;
                CalculateTotal();
                CalculateTotalDefensive();
                CalculateTotalOffensive();
            }
        }
        public Double DblHitDS
        {
            get { return dblHitDS; }
            set 
            {
                dblHitDS = value;
                CalculateTotal();
                CalculateTotalDefensive();
                CalculateTotalOffensive();
            }
        }
        public Double DblHitDM
        {
            get { return dblHitDM; }
            set 
            {
                dblHitDM = value;
                CalculateTotal();
                CalculateTotalDefensive();
                CalculateTotalOffensive();
            }
        }
        public Double DblHitOS
        {
            get { return dblHitOS; }
            set 
            {
                dblHitOS = value;
                CalculateTotal();
                CalculateTotalDefensive();
                CalculateTotalOffensive();
            }
        }
        public Double DblHitOM
        {
            get { return dblHitOM; }
            set
            {
                dblHitOM = value;
                CalculateTotal();
                CalculateTotalDefensive();
                CalculateTotalOffensive();
            }
        }
        public Double DblUse
        {
            get { return dblUse; }
            set
            {
                dblUse = value;
                CalculateTotal();
                CalculateTotalDefensive();
                CalculateTotalOffensive();
            }
        }
        public int DblTotalDefensive
        {
            get { return intTotalDefensive; }
            set { intTotalDefensive = value; }
        }
        public int DblTotalOffensive
        {
            get { return intTotalOffensive; }
            set { intTotalOffensive = value; }
        }
        public int DblTotal
        {
            get { return intTotal; }
            set { intTotal = value; }
        }
    }
}
