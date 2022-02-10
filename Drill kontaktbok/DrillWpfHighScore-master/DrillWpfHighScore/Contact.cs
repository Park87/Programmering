using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DrillWpfHighScore
{
    class Contact : IComparable<Contact>
    {
        private string preName;
        private string postName;
        private string phoneNum;



        public Contact(string preName, string postName, string phoneNum)
        {
            this.preName = preName;
            this.postName = postName;
            this.phoneNum = phoneNum;
        }

        public string PreName { get => preName; set => preName = value; }
        public string PostName { get => postName; set => postName = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }



        public override string ToString()
        {
            return preName + " " + postName + " " + phoneNum;
        }


        public int CompareTo([AllowNull] Contact other)
        {
            // Metoden CompareTo behövs för att implementera interfacet IComparable.
            // Denna metod används sedan när listan sorteras.
            // Sorteras på score. Störst kommer först.
            // Metoden returnerar -1 om detta (this) objektet är större än det andra objektet (other)
            // och annars returneras 1
            // null-värde hamnar sist i listan. Vi bör dock inte ha null-värden i listan.

            if (other == null)
            {
                // this is first
                return -1;
            }
            else
            {
                return preName.CompareTo(other.preName);
            }         
        }
    }
}
