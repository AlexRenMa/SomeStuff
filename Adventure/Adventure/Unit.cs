using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Unit
    {
        int maxHP;
        int currentHP;
        int def;
        int atk;
        int maxAP;
        int currentAP;
        int currentAmmo;
        int maxAmmo;

        public Unit(int maxHP, int currentHP, int def, int atk, int maxAP, int currentAP, int currentAmmo, int maxAmmo)
        {
            this.maxHP = maxHP;
            this.currentHP = currentHP;
            this.def = def;
            this.atk = atk;
            this.maxAP = maxAP;
            this.currentAP = currentAP;
            this.currentAmmo = currentAmmo;
            this.maxAmmo = maxAmmo;
        }
    }

    class Soldier: Unit
    {
        public Soldier()
        {

        }
    }


}
