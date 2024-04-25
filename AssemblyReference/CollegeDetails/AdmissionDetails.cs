using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeDetails
{

    public enum AdmissionStatus{Select, Admitted, Cancelled}
    public class AdmissionDetails
    {
        /*
        a.	AdmissionID – (Auto Increment ID - AID1001)
        b.	StudentID
        c.	DepartmentID
        d.	AdmissionDate
        e.	AdmissionStatus – Enum- (Select, Admitted, Cancelled)
        */


        //Field
        //Static field
        private static int s_admissionID = 1000;

        //Properties
        public string AdmissionID { get;}
        public string StudentID { get;}
        public string DepartmentID { get;}
        public DateTime AdmissionDate { get; set; }
        public AdmissionStatus AdmissionStatus { get; set; }


        //Constructor
        public AdmissionDetails(string studentID, string departmentID, DateTime admissionDate, AdmissionStatus admissionStatus)
        {
            s_admissionID++;

            AdmissionID = "AID"+s_admissionID;
            StudentID = studentID;
            DepartmentID = departmentID;
            AdmissionDate = admissionDate;
            AdmissionStatus = admissionStatus;
        }
        
    }
}