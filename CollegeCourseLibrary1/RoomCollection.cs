//******************************************************
// File: RoomCollection.cs
//
// Purpose: This class contains
//          memeber variables that have
//          been choosen to be serialized.
//          Along with two find methods to 
//          search for serialized course collection
//          Objects
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

namespace CollegeCourseLibrary1
{
    public class RoomCollection
    {
        #region objects
        //Creating new objects
        List<Room> rList = new List<Room>();
        Room room = new Room();
        #endregion

        #region Methods
        //****************************************************
        // Method: RList
        //
        // Purpose: Contains C# Properties and Data contract
        //serializer to specify which memebers to be serialized/deserialized
        //****************************************************
        public List<Room> RList
        {
            get
            {
                return rList;
            }

            set
            {
                rList = value;
            }
        }//end property

        //Default Method
        public RoomCollection()
        {
            
           
        }

        //****************************************************
        // Method: Find
        //
        // Purpose: The Find Method is of type Room that takes in one parmeter.
        //This method compares the parameter passed in with the Room list
        // and then returns the Room else returns null 
        //****************************************************
        public Room Find(int roomdId)
        {
            foreach (var r in rList)
            {
                if (r.Id == roomdId)
                {
                    return r;
                }
            }
            return null;
        }
        //****************************************************
        // Method: Find
        //
        // Purpose: The Find Method is overloaded and is of type Room that takes 
        // in two parmeters this method compares parameters passed in with the Room list
        // and then returns the Room else returns null 
        //****************************************************
        public Room Find(string Location)
        {
            foreach (var r in rList)
            {
                if (r.Location == Location)
                {
                    return r;
                }
            }
            return null;
        }// end of find

        //****************************************************
        // Method: ToString
        //
        // Purpose: Returns String id, designator number, title, credits
        //****************************************************
        public override string ToString()
        {
            return "ID: " + room.Id + "Location: " + room.Location + "Capcity" + room.Capacity;
        }
        #endregion
    }
}
