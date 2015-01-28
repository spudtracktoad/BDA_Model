using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BDA_Simulator
{
    public class Contorller : Form
    {
        Model_System modelSystemT90;
        Model_System modelSystemM1;
        Weapon tmpWeaponT90Main;
        Weapon tmpWeaponT90ATGM;
        Weapon tmpWeaponM1Main;


        public void Build_T90()
        {
            tmpWeaponT90Main = new Weapon(.84, .73, .75, .82, .95, .99, .99, .81);
            tmpWeaponT90ATGM = new Weapon(.16, .1, .1, .7, .7, .99, .99, .95);
            modelSystemT90 = new Model_System();
            modelSystemT90.AddSystemWeapon(tmpWeaponT90ATGM);
            modelSystemT90.AddSystemWeapon(tmpWeaponT90Main);
        }
        public void Build_M1()
        {
            tmpWeaponM1Main = new Weapon(1, .73, .86, .9, .92, .99, .99, .82);
            modelSystemM1 = new Model_System();
            modelSystemM1.AddSystemWeapon(tmpWeaponM1Main);
        }
        public double GetT90Info()
        {
            return modelSystemT90.DblTotal;
        }
        public double GetM1Info()
        {
            return modelSystemM1.DblTotal;
        }

    }
}
