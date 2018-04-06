//******************************************************
// File: Professor.cs
//
// Purpose: This class contains
//          C# Properities and 
//          contains a tostring
//          that returns ID,
//          Name, and Phone
//
// Written By: Brian J. Recuero
//
// Compiler: Visual Studio 2015
//
//******************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace CollegeCourseLibrary1
{
   [DataContract]
    public class Professor
    {
        #region private Member Variables
        //Initalizing private Member Variables
        [DataMember(Name = "id")]
        private int id = 0;
        [DataMember(Name = "name")]
        private string name = "";
        [DataMember(Name = "phone")]
        private string phone = "";


        #endregion

        #region Methods
        //****************************************************
        // Method: ID
        //
        // Purpose: Contains C# Properties.
        //****************************************************

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        //****************************************************
        // Method: Name
        //
        // Purpose: Contains C# Properties.
        //****************************************************

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        //****************************************************
        // Method: Phone
        //
        // Purpose: Contains C# Properties.
        //****************************************************

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        //****************************************************
        // Method: To String
        //
        // Purpose: Returns ID, Name, Phone
        //****************************************************

        public override string ToString()
        {
            return " ID: "+ Id + "\n Name: " + Name + "\n Phone: " + Phone;
        }
        #endregion

        
    }
    
}
