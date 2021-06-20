using System;
using System.Collections.Generic;
using System.Text;

namespace main_game
{
    class Monsters
    {
        #region privates

        private string _name = "unnamed";
        private float _hp = 100;

        #endregion

        #region getters and setters

        public string name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public float hp
        {
            get { return this._hp; }
            set { this._hp = value; }
        }

        #endregion

        #region constructors

        public Monsters(string name, float hp)
        {
            this._name = name;
            this._hp = hp;
        }

        #endregion
    }
}
