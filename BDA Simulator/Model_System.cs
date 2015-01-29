using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace BDA_Simulator
{
    [Serializable]
    public class Model_System
    {
        private String strSystemName;
        private Double dblSystemTotal;
        private Double dblSystemTotalOffensive;
        private Double dblSystemTotalDefensive;
        public List<Weapon> WeaponList = new List<Weapon>();

        // Serialize weapon systems
        public void SaveWeaponData(Stream fStream)
        {
            XmlSerializer xmlFormater = new XmlSerializer(typeof(Weapon));
            foreach (Weapon val in WeaponList)
            {
                xmlFormater.Serialize(fStream, val);
            }
        }
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
            WeaponList.Add(val);
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
