using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicitImplement_Interface

{
    interface StudentDetails
    {
        void details();                                           //StudentDetails Interface having details method
    }
    interface TeacherDetails
    {
        void details();                                          //TeacherDetails Interface having same method name details  
    }
    class Implement : StudentDetails, TeacherDetails              //Multiple Inheritence of interface student and teacher
    {
        void StudentDetails.details()                                      //defining body of both methods of interfaces
        {
            Console.WriteLine("This is Interface of StudentDetails");
        }

        void TeacherDetails.details()
        {
            Console.WriteLine("This is Interface of TeacherDetails");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Implement i = new Implement();                            //creating object of class
            ((StudentDetails)i).details();                            //implicitly calling the methods of interfaces as both interface have same method name.
            ((TeacherDetails)i).details();
        }
    }
}
