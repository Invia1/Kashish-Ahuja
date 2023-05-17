using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Xml.Linq;


namespace HospitalManagement.Model
{
    internal class Patient
    {

        int regId;
        string _fname;
        string _lname;

        public int PatientRegId
        {
            get
            {
                return regId;
            }
            set
            {
                regId = value;
                int id = regId;
            }

        }
       

        public string FirstName 
        {
            get 
            {
                return _fname;
            }

            set
            {
                if (Regex.IsMatch(value, @"\w{1-35}"))
                    throw new ArgumentException("Name must be 1-35 alfanum");
                _fname = value;
            }
        }

		public string LastName
        {
            get { return _lname; }

            set
            {
                if (Regex.IsMatch(value, @"\w{1-35}"))
                    throw new ArgumentException("Name must be 1-35 alfanum");
                _lname = value;
            }
        }
		public int PhoneNo{ get; set; }
        public string Gender { get; set;}
		public int Age { get; set;}
		public string Adress { get; set;}
		public long AdharNo { get; set; }
		public string SpecialityToConsult{get; set;}

      
            }
}
