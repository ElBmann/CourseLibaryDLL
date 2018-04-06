//******************************************************
// File: UnitTest1.cs
//
// Purpose: This class contains
//          several test methods 
//          that test if the propreties
//          are correctly created. By
//          setting the property set value
//          to value of the test variable
//          then testing if they are both
//          equal. If they are equal then
//          message Pass is written to console
//          if fail then fail is wrriten to console
//          
// Written By: Brian J. Recuero
//
// Compiler: Visual Studio 2015
//
//******************************************************
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollegeCourseLibrary1;

namespace CourseScheduleUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        #region CourseTest
        //****************************************************
        // Method: UnitTestCourse
        //
        // Purpose: Checks to see if properties where created correctly.
        //****************************************************

        [TestMethod]
        public void UnitTestCourse()
        {
            #region Variables
            //Creating an instants and setting default values
            Course courseTest = new Course();
            int expectedId = 0;
            string expectedDesignator = "";
            string expectedNumber = "";
            string expectedTitle = "";
            string expectedDescription = "";
            int expectedCredits = 0;
            #endregion
            #region setting Properties and Logic
            //Setting the properties to equal default value
            courseTest.Id = expectedId;
            courseTest.Designator = expectedDesignator;
            courseTest.Number = expectedNumber;
            courseTest.Title = expectedTitle;
            courseTest.Description = expectedDescription;
            courseTest.Credits = expectedCredits;
           
            //Logic to determine if test passes or fails
            if (courseTest.Id == expectedId)
            {
                Console.WriteLine("Course Id Property: Pass");
            }
            else
            {
                Console.WriteLine("Course Id Property: Fail");
            }


            if (courseTest.Designator == expectedDesignator)
            {
                Console.WriteLine("Course Designator Property: Pass");
            }
            else
            {
                Console.WriteLine("Course Designator Property: Fail");
            }

            if (courseTest.Number == expectedNumber)
            {
                Console.WriteLine("Course Number Property: Pass");
            }else
            {
                Console.WriteLine("Course Number Property: Fail");
            }

            if (courseTest.Title == expectedTitle)
            {
                Console.WriteLine("Course Title Property: Pass");
            }else
            {
                Console.WriteLine("Course Title Property: Fail");
            }

            if (courseTest.Description == expectedDescription)
            {
                Console.WriteLine("Course Description Property: Pass");
            }else
            {
                Console.WriteLine("Course Description Property: Fail");
            }
            if(courseTest.Credits == expectedCredits)
            {
                Console.WriteLine("Course Credits Property: Pass");
            }else
            {
                Console.WriteLine("Course Credits Property: Fail");
            }
            #endregion
        }
        #endregion
        #region Professor Test
        //****************************************************
        // Method: UnitTestProfessor
        //
        // Purpose: Checks to see if properties where created correctly.
        //****************************************************
        [TestMethod]
        public void UnitTestProfessor()
        {
            #region Variables
            //Creating an instants and setting default values
            Professor p = new Professor();
            int expectedId = 0;
            string expectedName = "";
            string expectedPhone = "";
            #endregion
            #region setting Properties and Logic
            //Setting the properites to equal default value
            p.Id = expectedId;
            p.Name = expectedName;
            p.Phone = expectedPhone;
            
            //Logic to determine if test passes or fails
            if (p.Id == expectedId)
            {
                Console.WriteLine("Professor Id Property: Pass");
            }
            else
            {
                Console.WriteLine("Professor Id Property: Fail");
            }

            if(p.Name == expectedName)
            {
                Console.WriteLine("Professor Name Property: Pass");
            }else
            {
                Console.WriteLine("Professor Name Property: Fail");
            }

            if (p.Phone == expectedPhone)
            {
                Console.WriteLine("Professor Phone Property: Pass");
            }
            else
            {
                Console.WriteLine("Professor Phone Property: Fail");
            }
            #endregion

        }
        #endregion
        #region Room Test
        //****************************************************
        // Method: UnitTestRooms
        //
        // Purpose: Checks to see if properties where created correctly.
        //****************************************************
        [TestMethod]
        public void UnitTestRoom()
        {
            #region Variables
            //Creating an instants and setting default values
            Room r = new Room();
            int expectedId = 0;
            string expectedLocation = "";
            int expectedCapacity = 0;
            #endregion
            #region setting Properties and Logic
            //Setting the properites to equal default value
            r.Id = expectedId;
            r.Location = expectedLocation;
            r.Capacity = expectedCapacity;

            //Logic to determine if test passes or fails
            if (r.Id == expectedId)
            {
                Console.WriteLine("Room Id Property: Pass");
            }else
            {
                Console.WriteLine("Room Id Property: Fail");
            }

            if (r.Location == expectedLocation)
            {
                Console.WriteLine("Room Location Property: Pass");
            }else
            {
                Console.WriteLine("Room Location Property: Fail");
            }

            if (r.Capacity == expectedCapacity)
            {
                Console.WriteLine("Room Capacity Property: Pass");
            }else
            {
                Console.WriteLine("Room Location Property: Fail");
            }
            #endregion

        }
        #endregion
        #region CourseMeeting Test
        //****************************************************
        // Method: UnitTestCourseMeeting
        //
        // Purpose: Checks to see if properties where created correctly.
        //****************************************************
        [TestMethod]
        public void UnitTestCourseMeeting()
        {
            #region Variables
            //Creating an instants and setting default values
            CourseMeeting cm = new CourseMeeting();
            int expectedRoomId = 0;
            int expectedCourseId = 0;
            int expectedProfessor = 0;
            string expectedDayTime = "";
            #endregion
            #region setting Properties and Logic
            //Setting the properites to equal default value
            cm.RoomId = expectedRoomId;
            cm.CourseId= expectedCourseId;
            cm.Professor = expectedProfessor;
            cm.DayTime = expectedDayTime;
            //Logic to determine if test passes or fails
            if (cm.RoomId == expectedRoomId)
            {
                Console.WriteLine("Course Meeting Room Id Property: True");
            }else
            {
                Console.WriteLine("Course Meeting Room Id Property: Fail");
            }
            if (cm.CourseId == expectedCourseId)
            {
                Console.WriteLine("Course Meeting Id Property: True");
            }else
            {
                Console.WriteLine("Course Meeting Id Property: Fails");
            }

            if (cm.Professor == expectedProfessor)
            {
                Console.WriteLine("Course Meeting Professor Property: True");
            }else
            {
                Console.WriteLine("Course Meeting Professor Property: Fail");
            }

            if (cm.DayTime == expectedDayTime)
            {
                Console.WriteLine("Course Meeting Day Time Property: True");
            }else
            {
                Console.WriteLine("Course Meeting Day Time Property: Fail");
            }

            #endregion
        }
        #endregion
    }
}
