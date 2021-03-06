﻿//******************************************************
// File: DataLayer.cs
//
// Purpose: This class contains Call Event arguments 
// that are fired once buttons are clicked on the wpf
// side.   
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
using System.Runtime.Serialization.Json;
using System.IO;

namespace CollegeCourseLibrary1
{
   
    [DataContract]
   public class DataLayer
    {
        #region private memeber variable
        
        CourseCollection cc = new CourseCollection();
        CourseMeeting cm1 = new CourseMeeting();
        ProfessorCollection pc = new ProfessorCollection();
        RoomCollection rc = new RoomCollection();
        CourseMeetingCollection cmc = new CourseMeetingCollection();
        #endregion

        #region CallEvents
        //****************************************************
        // Method: CC_CallEventArgs
        // Event argument class.
        //
        //*****************************************************
        public class CC_CallEventArgs: EventArgs {

            private CourseCollection courses;
            public CourseCollection Courses
            {
                get
                {
                    return courses;
                }

                set
                {
                    courses = value;
                }
            }
          
            public CC_CallEventArgs(CourseCollection cc)
            {
                Courses = cc;
            }

        }//end event Args

        //Declare the call event
        public event EventHandler<CC_CallEventArgs> CallEvent;

        public void FireCallEvent(CourseCollection cc)
        {
            if(CallEvent == null)
            {
                return;
            }
            DataLayer.CC_CallEventArgs CCEvtArgs = new DataLayer.CC_CallEventArgs(cc);
            CallEvent(this, CCEvtArgs);
        }// End FireCall Event


        //****************************************************
        // Method: PP_CallEventArgs
        // Event argument class.
        //
        //*****************************************************
        public class PP_CallEventArgs:EventArgs
        {
            private ProfessorCollection professors;
            public ProfessorCollection Professors
            {
                get
                {
                    return professors;
                }

                set
                {
                    professors = value;
                }
            }
            public PP_CallEventArgs(ProfessorCollection pp)
            {
                professors = pp;
            }
        }//End of PP_CallEventArgs

        //Declare the call event
        public event EventHandler<PP_CallEventArgs> pp_CallEvent;


        //****************************************************
        // Method: RC_CallEventArgs
        // Event argument class.
        //
        //*****************************************************
        public class RC_CallEventArgs : EventArgs
        {
            private RoomCollection rooms;
            public RoomCollection Rooms
            {
                get
                {
                    return rooms;
                }

                set
                {
                    rooms = value;
                }
            }
            public RC_CallEventArgs(RoomCollection rc)
            {
                rooms = rc;
            }
        }//End RC_CallEventArgs


        //****************************************************
        // Method: CMC_CallEventArgs
        // Event argument class.
        //
        //*****************************************************
        public class CMC_CallEventArgs : EventArgs
        {
            private CourseMeetingCollection courseMeetings;
            public CourseMeetingCollection CourseMeetings
            {
                get
                {
                    return courseMeetings;
                }

                set
                {
                    courseMeetings = value;
                }
            }
            public CMC_CallEventArgs(CourseMeetingCollection cmc)
            {
                courseMeetings = cmc;
            }
        }//End CMC_CallEventArgs
           


        //This class Fires the the call event
        public bool AddCourse(Course c)
        {

            try
            {

                cc.CList.Add(c);


                return true;
            }
            catch (NullReferenceException E)
            {

                return false;
            }

        }//end of Add Course


        public bool AddProfessor(Professor p)
        {
            try
            {
                pc.PList.Add(p);



                return true;
            }
            catch (NullReferenceException E)
            {
               
                return false;
            }
        }//end of add Professor

        public bool AddRoom(Room r)
        {
            try
            {

                rc.RList.Add(r);


                return true;
            }
            catch (NullReferenceException E)
            {
                
                return false;
            }

        }// end of Add Room

        public bool AddCourseMeeting(CourseMeeting cm)
        {
            try
            {

                cmc.CmList.Add(cm);
                //TODO: Remove


                return true;
            }
            catch (NullReferenceException E)
            {
                
                return false;
            }
        }


        public void RemoveCourse(int courseId)
        {
            try
            {
                Course c;
                c = cc.Find(courseId);
                if (c != null)
                {
                    cc.CList.Remove(c);

                }


            }
            catch (NullReferenceException E)
            {

            }

        }// end Remove Course

        public void RemoveProfessor(int professorId)
        {
            Professor p;
            p = pc.Find(professorId);
            if (p != null)
            {
                pc.PList.Remove(p);
            }
        }// End Remove Professor

        public void RemoveRoom(int roomId)
        {
            Room r;

            r = rc.Find(roomId);
            if (r != null)
            {
                rc.RList.Remove(r);
            }
        }

        public void RemoveCourseMeeting(int courseId, int professorId, int roomId, string daytime)
        {
             CourseMeetingCollection resultCmc;

            var cmID = cm1.CourseId;
              resultCmc = cmc.FindByCourseId(courseId);
            foreach (CourseMeeting cm in cmc.CmList)
            {
                if (cm.CourseId == courseId && cm.Professor == professorId && cm.RoomId == roomId && cm.DayTime == daytime)
                {
                    resultCmc.CmList.Remove(cm);
                }
            }
        }



        

        //TODO: Add the rest of the lists to be deserialize
       
        public void Initialize()
        {
            
            string courseFileName = "CourseCollection.json";
            FileStream CC_reader = new FileStream(courseFileName, FileMode.Open, FileAccess.Read);

            DataContractJsonSerializer inputSerializer;
            inputSerializer = new DataContractJsonSerializer(typeof(CourseCollection));

            cc = (CourseCollection)inputSerializer.ReadObject(CC_reader);
           
            CC_reader.Close();
        }// End Initialize

        #endregion
    }
}
