//******************************************************
// File: ProfessorCollection.cs
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
using System.Runtime.Serialization;

namespace CollegeCourseLibrary1
{
    [DataContract]
    public class ProfessorCollection
    {
        #region objects
        //Creating new objects
        Professor professor = new Professor();
        List<Professor> pList = new List<Professor>();
        #endregion

        #region Methods
        //****************************************************
        // Method: PList
        //
        // Purpose: Contains C# Properties and Data contract
        //serializer to specify which memebers to be serialized/deserialized
        //****************************************************

        [DataMember(Name = "professors")]
        public List<Professor> PList
        {
            get
            {
                return pList;
            }

            set
            {
                pList = value;
            }
        }

        //****************************************************
        // Method: Find
        //
        // Purpose: The Find Method is of type Professor that takes in one parmeter.
        // This method compares the parameter passed in with the Professor list
        // and then returns the Professor else returns null 
        //****************************************************
        public Professor Find(int professorId)
        {
            foreach (var p in pList)
            {
                if (p.Id == professorId)
                {
                    return p;
                }
            }
            return null;
        }

        //****************************************************
        // Method: Find
        //
        // Purpose: The Find Method is overloaded and is of type Professor that takes 
        // in two parmeters this method compares parameters passed in with the Professor list
        // and then returns the Professor else returns null 
        //****************************************************
        public Professor Find(string Name )
        {
            foreach (var n in pList)
            {
                if (n.Name == Name)
                {
                    return n;
                }
            }
            return null;

        }

        //****************************************************
        // Method: ToString
        //
        // Purpose: Returns ID, Name, Phone
        //****************************************************

        public override string ToString()
        {

            return "ID: " + professor.Id+ "Name: "+ professor.Name + "Phone: " + professor.Phone;
        }
        #endregion
    }

}
