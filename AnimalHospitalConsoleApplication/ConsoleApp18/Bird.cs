using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{

     class Bird : Pet
    {

        private string PetName;
        private string OwnerName;
        private string PetColor;
        private bool FeathersClipped;
        protected int Gender;
        public string sex;

        public Bird(string name, string ownerName, string color, bool feathersClipped) : base(name, ownerName, color)
        {
            PetName = name;
            OwnerName = ownerName;
            PetColor = color;
            FeathersClipped = feathersClipped;
        }

       public bool getClipped()
        {
            return FeathersClipped;
        }

        public void setClipped()
        {
            FeathersClipped = true;
        }

        public string GetPetInfo()
        {
            return " " + GetType().Name + Environment.NewLine + OwnerName + "owned by" + PetName +
                       System.Environment.NewLine + "Color:" + PetColor + System.Environment.NewLine +
                        "Feathers Clipped :" + FeathersClipped;
        }
    }
}
