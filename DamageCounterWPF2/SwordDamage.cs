using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCounter2
{
    class SwordDamage
    {
        public SwordDamage(int roll) { 
            this.Roll = roll;
        }

        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        private int roll;
        public int Roll { 
            get => roll; 
            private set {
                this.roll = value;
                CalculateDamage();
            }
        }
        private bool magic;
        public bool Magic {
            get => magic;
            set { 
                this.magic = value;
                CalculateDamage();
            }
        }

        private bool flaming;
        public bool Flaming {
            get => flaming;
            set { 
                this.flaming = value;
                CalculateDamage();
            }
        }

        public int Damage { get; private set; }

        private void CalculateDamage() {
            var MagicMultipier = Magic ? 1.75M : 1.0M; 

            Damage = (int)(Roll * MagicMultipier) + BASE_DAMAGE;

            Damage = Flaming ? Damage += FLAME_DAMAGE : Damage;
        }
    }
}
