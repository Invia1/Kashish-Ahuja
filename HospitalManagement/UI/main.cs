using System;
using System.Collections;
using HospitalManagement.Model;
using HospitalManagement.BLL;
using System.Reflection.Emit;

namespace HospitalManagement.UI
{
    internal class main
    {
        public static void Main()
        {
            patientFunction ps = new patientFunction();
            int num;
           
            Label:
            do
            {

                Console.WriteLine(" WELCOME TO RIM HOSPITAL!!");
                Console.WriteLine("kindly tell your identity : \n 1. Patient \n 2: Visitor \n 3: Management ");
                 num = int.Parse(Console.ReadLine());
                //int n = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine(" Please fill the Registration Form !!");

                        Patient patient = new Patient();

                        Console.WriteLine(" Enter Regestration id :");

                        patient.PatientRegId= int.Parse(Console.ReadLine());
                        /*if (objlist.ContainsEquals(PatientRegId)) ;
                        {
                            Console.WriteLine(" Regestration id  Already exist: ");

                        }
                        */
                        Console.WriteLine("Enter your FirstName");
                        patient.FirstName = Console.ReadLine();

                       
                        Console.WriteLine("Enter Last name");
                        patient.LastName = Console.ReadLine();


                        Console.WriteLine("Enter Phone No.");
                        patient.PhoneNo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Gender");
                        patient.Gender = Console.ReadLine();

                        Console.WriteLine("Enter Age");
                        patient.Age = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Adress");
                        patient.Adress = Console.ReadLine();

                        Console.WriteLine("Enter Adhar No.");
                        patient.AdharNo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Speciality To Consult");
                        patient.SpecialityToConsult = Console.ReadLine();
                        ps.CreatePatient(patient);

                        break;

                    case 2:
                        Console.WriteLine(" you may go without Registraton");
                        break;
                    case 3:
                        Console.WriteLine(" Show data ");

                        List<Patient> objl = ps.GetPatientDetail();

                        if (objl.Count > 0)
                        {
                            Console.WriteLine("------------data in your list---------");
                         
                            foreach (var item in objl)
                            {
                                Console.WriteLine("First name : "+ item.FirstName+ "\n"
                                    + "Last name : "+ item.LastName + "\n"
                                    + "Phone no: "+ item.PhoneNo + "\n"
                                   + "Gender: " + item.Gender + "\n"
                                   + "Age: " + item.Age + "\n"
                                    + "Address: " +item.Adress + "\n"
                                    + "Aadhar no.: "+ item.AdharNo + "\n"
                                    + "Speciality to be consulted: "+ item.SpecialityToConsult +" \n");
                               
                            }

                        }
                        else
                        { 
                            Console.WriteLine("as of now your data list is empty"); 
                        }

                        break;


                    default:
                        Console.WriteLine(" You Can't Go Inside");
                        break;
                }
                goto Label;


            }

            while (num != 0);
        }
     }
}




