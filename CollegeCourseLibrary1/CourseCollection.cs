//******************************************************
// File: CourseCollection.cs
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
    public class CourseCollection
    {
        #region objects
        //Creating new objects
        Course course = new Course();
        List<Course> cList = new List<Course>();
        #endregion

        #region Methods
        //****************************************************
        // Method: CList
        //
        // Purpose: Contains C# Properties and Data contract
        //serializer to specify which memebers to be serialized/deserialized
        //****************************************************
        [DataMember(Name = "courses")]
        public List<Course> CList
        {
            get
            {
                return cList;
            }

            set
            {
                cList = value;
            }
        }

        //****************************************************
        // Method: Find
        //
        // Purpose: The Find Method is of type Course that takes in one parmeter.
        //This method compares the parameter passed in with the course list
        // and then returns the course else returns null 
        //****************************************************

 
        public Course Find(int courseId)
        {
             foreach (var c in CList)
             {
           
                if (c.Id == courseId)
                {
                    //Console.WriteLine(c);
                    return c;
                }
              

             }//end foreach
            return null;
        }

        //****************************************************
        // Method: Find
        //
        // Purpose: The Find Method is overloaded and is of type Course that takes 
        // in two parmeters this method compares parameters passed in with the course list
        // and then returns the course else returns null 
        //****************************************************
        public Course Find(string designator, string Number)
        {
            foreach (var c in cList)
            {
                if (c.Designator == designator)
                {
                    return c;
                }
                if (c.Number == Number)
                {
                    return c;
                }
            }
            return null;
        }
        //****************************************************
        // Method: ToString
        //
        // Purpose: Returns String id, designator number, title, credits
        //****************************************************
        public override string ToString()
        {
            return "ID: "+ course.Id+"Designator: " +course.Designator+
                "Number: " + course.Number + "Title: " + course.Title + 
                "description: " + course.Description + "Credits"+ course.Credits;
        }
        #endregion
    }


}
