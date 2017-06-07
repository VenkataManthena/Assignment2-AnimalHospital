using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Pet
    {

        private string PetName;
        private string OwnerName;
        private string PetColor;

        protected int Gender;
        public string sex;


        public Pet(string name, string ownerName, string color)
        {

            PetName = name;
            OwnerName = ownerName;
            PetColor = color;
        }

        public string getPetName()
        {
            return PetName;
        }

        public string getOwnerName()
        {
            return OwnerName;
        }

        public string getColor()
        {
            return PetColor;

        }
        public void setGender(int sexId)
        {

            if (sexId == 0)
            {
                sex = "Female";
            }
            else
            {
                sex = "Male";
            }

        }
        public string getGender()
        {

            return sex;
        }

        public string getPetInfo()
        {

            return "" + OwnerName + "owned by" + PetName + System.Environment.NewLine + "Color:" + PetColor + System.Environment.NewLine + "Sex:" + sex;

        }

    }    
           
 }
    
