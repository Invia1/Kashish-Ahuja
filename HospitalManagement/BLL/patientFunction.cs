using System;

using HospitalManagement.Model;
namespace HospitalManagement.BLL
{
    internal class patientFunction
    {
         Patient p = new Patient();
        List<Patient> objlist = new List<Patient>();
        public int CreatePatient(Patient p1)
        {
            objlist.Add(p1);
            return 1;
        }

        public List<Patient> GetPatientDetail()
        {

            return objlist;

        }
      
    }

}
