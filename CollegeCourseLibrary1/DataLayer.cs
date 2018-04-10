//******************************************************
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

        CourseCollection cc;
        CourseMeeting cm1;
        ProfessorCollection pc;
        RoomCollection rc;
        CourseMeetingCollection cmc;
        #endregion

        #region CallEvents
        //****************************************************
        // Method: CC_CallEventArgs
        // Event argument class.
        //
        //*****************************************************
        public class C_CallEventArgs: EventArgs {

            private Course courses;
            public Course Courses
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
          
            public C_CallEventArgs(Course c)
            {
                Courses = c;
                
            }

        }//end event Args

        //Declare the call event
        public event EventHandler<C_CallEventArgs> CallEvent;

        public void FireCallEvent(Course c)
        {
            if(CallEvent == null)
            {
                return;
            }

            DataLayer.C_CallEventArgs CEvtArgs = new DataLayer.C_CallEventArgs(c);

            CallEvent(this, CEvtArgs);
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
           


        
        public bool AddCourse(Course c)
        {
            //add course fire event in here
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



        public override string ToString()
        {
            return cc.ToString() + pc.ToString();
        }// end To String

        #endregion
    }
}
