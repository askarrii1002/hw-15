using System;
using System.Collections.Generic;
using System.Text;

namespace hw15
{
    class Human : powerRangers
    {
        public string _gender { get; set; }

        public Human(string name, string color, int abilityLevel, string ability) : base(name, color, abilityLevel, ability)
        {
            _name = name;
            _color = color;
            _abilityLevel = abilityLevel;
            _ability = ability;
            _gender = _gender;
        }

        public bool fight(string isFighting)
        {
            bool enemy = true;
            if (isFighting == "Fighting")
            {
                return false;
            } else if (isFighting == "training")
            {
                return true;
            } else
            {
                return true;
            }
        }
    }
}
