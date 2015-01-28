using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDA_Simulator
{
    public class Model_System
    {
        private String strSystemName;
        private Double dblSystemTotal;
        private Double dblSystemTotalOffensive;
        private Double dblSystemTotalDefensive;
        private LinkedList<Weapon> WeaponList = new LinkedList<Weapon>();

        //Methods
        private void CalculateSystemTotal()
        {
            dblSystemTotal = 0;
            foreach (Weapon val in WeaponList)
            {
                dblSystemTotal += val.DblTotal;
            }
        }
        private void CalculateSystemTotalOffensive()
        {
            dblSystemTotalOffensive = 0;
            foreach (Weapon val in WeaponList)
            {
                dblSystemTotalOffensive += val.DblTotalOffensive;
            }
        }
        private void CalculateSystemTotalDefensive()
        {
            dblSystemTotalDefensive = 0;
            foreach (Weapon val in WeaponList)
            {
                dblSystemTotalDefensive += val.DblTotalDefensive;
            }
        }
        public void AddSystemWeapon(Weapon val)
        {
            WeaponList.AddLast(val);
            CalculateSystemTotalDefensive();
            CalculateSystemTotalOffensive();
            CalculateSystemTotal();
        }

        //Properties
        public String StrName
        {
            get { return strSystemName; }
            set { strSystemName = value; }
        }
        public Double DblTotalDefensive
        {
            get { return dblSystemTotalDefensive; }
            set { dblSystemTotalDefensive = value; }
        }
        public Double DblTotalOffensive
        {
            get { return dblSystemTotalOffensive; }
            set { dblSystemTotalOffensive = value; }
        }
        public Double DblTotal
        {
            get { return dblSystemTotal; }
            set { dblSystemTotal = value; }
        }
        
    }
}
