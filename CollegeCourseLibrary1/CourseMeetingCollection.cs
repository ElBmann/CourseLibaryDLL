//******************************************************
// File: CourseMeetingCollection.cs
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
    public class CourseMeetingCollection
    {
        #region ListObject
        //Creating list object of type coursemeeting
        private List<CourseMeeting> cmList = new List<CourseMeeting>();
        #endregion
        #region Methods/Properties

        [DataMember(Name = "courseMeetings")]
        public List<CourseMeeting> CmList
        {
            get
            {
                return cmList;
            }

            set
            {
                cmList = value;
            }
        }

        
       
        
        public CourseMeetingCollection FindByCourseId(int courseId)
        {
           
            CourseMeetingCollection cm = new CourseMeetingCollection();
            foreach (var c in cmList)
            {
                
                if (c.CourseId == courseId)
                {
                    cm.CmList.Add(c);
                    
               }
            }
            return cm;
        }

        public CourseMeetingCollection FindByProfessorId(int professorId)
        {
            CourseMeetingCollection cm2 = new CourseMeetingCollection();
            foreach (var p in cmList)
            {
                if (p.Professor== professorId)
                {

                    cm2.CmList.Add(p);
                }
            }
            return cm2;
        }

        public CourseMeetingCollection FindByRoomId(int roomId)
        {
            CourseMeetingCollection cm3 = new CourseMeetingCollection();
            foreach (var r in cmList)
            {
                if ( r.RoomId == roomId)
                {
                    cm3.CmList.Add(r);
                }
            }
            return cm3;
        }
        #endregion

    }
}
