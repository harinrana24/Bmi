using System;

using System.Threading;


namespace PatientInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            //FOR READING OF AGE
            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());

            //FOR READING OF fIRSTNAME
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            //FOR READING OF lASTNAME
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            //FOR READING OF wEIGHT
            Console.WriteLine("Please enter your weight (in KG):");
            double weight = double.Parse(Console.ReadLine());

            //FOR READING OF HEIFGHT
            Console.WriteLine("Please enter your height (in CM):");
            double height = double.Parse(Console.ReadLine());

            // TOGET INFO AND DIAPLAY OUTPUT OF bP AND BMI
            Patient patient = new Patient(firstName, lastName, weight, height);
            Console.WriteLine(patient.GetPatientInfo());


            // THIS IS A TIMER METHOD MY WINDOW WAS CLOSING AS soon as i enter the information
            // abd i was unable to get a sanpshot of output so iput this method to hold the terminal
            // for few seconds 
            Thread.Sleep(10000);
        }
    }
}
