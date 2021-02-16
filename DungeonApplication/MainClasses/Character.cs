using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public abstract class Character
    {
        public string DefaultName { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public bool IsBoosted { get; set; }

        public Character(string defaultName, string name, char gender, bool isBoosted)
        {
            DefaultName = defaultName;
            Name = name;
            Gender = gender;
            IsBoosted = isBoosted;
        }

        public Character() { }
    }
}
