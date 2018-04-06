//******************************************************
// File: CourseMeeting.cs
//
// Purpose: This class contains
//          C# Properities and 
//          contains a tostring
//          that returns ID,
//          Location, and capacity
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
    public class Room
    {
        #region private Member Variables
        //Initalizing private Member Variables
        [DataMember(Name = "id")]
        private int id = 0;
        [DataMember(Name = "location")]
        private string location = "";
        [DataMember(Name = "capacity")]
        private int capacity = 0;


        #endregion

        #region methods
        //****************************************************
        // Method: Id
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
        // Method: Location
        //
        // Purpose: Contains C# Properties.
        //****************************************************
        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }
        //****************************************************
        // Method: Capacity
        //
        // Purpose: Contains C# Properties.
        //****************************************************
        public int Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                capacity = value;
            }
        }
        //****************************************************
        // Method: ToString
        //
        // Purpose: returns a String of id, Location, and Capacity
        //****************************************************

        public override string ToString()
        {
            
            return "ID: " + Id + "\n Location: " + Location + "\n Capacity: " + Capacity;
         
        }
        #endregion
      
    }
    
}
