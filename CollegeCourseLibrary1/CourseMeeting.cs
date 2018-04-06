//******************************************************
// File: CourseMeeting.cs
//
// Purpose: This class contains
//          C# Properities and 
//          contains a tostring
//          that returns RoomId,
//          courseId, professor and daytime
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
    public class CourseMeeting
    {
        #region private Member Variables
        //Initalizing private Member Variables
        [DataMember(Name = "roomId")]
        private int roomId = 0;
        [DataMember(Name = "courseId")]
        private int courseId = 0;
        [DataMember(Name ="professorId")]
        private int professorId = 0;
        [DataMember(Name = "dayTime")]
        private string dayTime = "";


        #endregion

        #region Methods
        //****************************************************
        // Method: RoomId
        //
        // Purpose: Contains C# Properties.
        //****************************************************

        public int RoomId
        {
            get
            {
                return roomId;
            }

            set
            {
                roomId = value;
            }
        }
        //****************************************************
        // Method: Course Id
        //
        // Purpose: Contains C# Properties.
        //****************************************************

        public int CourseId
        {
            get
            {
                return courseId;
            }

            set
            {
                courseId = value;
            }
        }
        //****************************************************
        // Method: Professor
        //
        // Purpose: Contains C# Properties.
        //****************************************************

        public int Professor
        {
            get
            {
                return professorId;
            }

            set
            {
                professorId = value;
            }
        }
        //****************************************************
        // Method: DayTime
        //
        // Purpose: Contains C# Properties.
        //****************************************************

        public string DayTime
        {
            get
            {
                return dayTime;
            }

            set
            {
                dayTime = value;
            }
        }

        //****************************************************
        // Method: ToString
        //
        // Purpose: returns a String of Room Id, Course Id, Professor Id and DayTime
        //****************************************************



        public override string ToString()
        {
            //roomId = 700;
            //courseId = 1234;
            //professorId = 5168;
            //dayTime = "Noon";

            return "Room Id: " + RoomId + "\n Course Id: " + CourseId + "\n professor Id: " + Professor + "\n Day Time:" + DayTime;
        }
        #endregion
       
    }
   
}
