using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameLibrary {
    class MapEnemy : Enemy {
        private Action<Enemy> callOnDeath;

        private float _health;
        public override float Health {
            get => _health;
            protected set {
                if (value <= 0) {
                    callOnDeath(this);
                }
                _health = value;
            }
        }

        public MapEnemy(Action<Enemy> callOnDeath, int level, Bitmap img) : base(level, img) {
            this.callOnDeath = callOnDeath;
        }
    }
}
