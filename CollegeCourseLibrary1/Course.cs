//******************************************************
// File: Course.cs
//
// Purpose: This class contains
//          C# Properities and 
//          contains a tostring
//          that returns ID,
//          designator, number, title
//          description, credits
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
    public class Course
    {

        #region Private Memeber Variables
        //Initalizing private Member Variables
        [DataMember(Name = "id")]
        private int id = 0;
        [DataMember(Name = "designator")]
        private string designator = "";
        [DataMember(Name = "number")]
        private string number = "";
        [DataMember(Name = "title")]
        private string title = "";
        [DataMember(Name ="description")]
        private string description = "";
        [DataMember(Name = "credits")]
        private int credits = 0;
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
        // Method: designator
        //
        // Purpose: Contains C# Properties.
        //****************************************************
        public string Designator
        {
            get
            {
                return designator;
            }

            set
            {
                designator = value;
            }
        }
        //****************************************************
        // Method: Number
        //
        // Purpose: Contains C# Properties.
        //****************************************************

        public string Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }
        //****************************************************
        // Method: Title
        //
        // Purpose: Contains C# Properties.
        //****************************************************
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }
        //****************************************************
        // Method: Description
        //
        // Purpose: Contains C# Properties.
        //****************************************************
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
        //****************************************************
        // Method: Credits
        //
        // Purpose: Contains C# Properties.
        //****************************************************
        public int Credits
        {
            get
            {
                return credits;
            }

            set
            {
                credits = value;
            }
        }

        //****************************************************
        // Method: ToString
        //
        // Purpose: Returns String id, designator number, title, credits
        //****************************************************

        public override string ToString()
        {
            
            return "ID: " + Id + " Designator: " + Designator + "Number: " + Number + "Title: " + Title + "Credits: " + Credits;
        }

        #endregion
        


    }
   


}
