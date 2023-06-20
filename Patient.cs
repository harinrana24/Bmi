//HARIN RANA (200532753)
//tHIS PROGRAM CALCULATE bmi  AND BLOOD PRESSURE OF PERSON BASED ON INPUT OF AGE NAME AND HEIGHT AND DIAPLAY WHETHER PERSON IS FIT OR UNFIT



using System;

namespace PatientInformation
{
    public class Patient
    {
       // defining the properties for patient
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }


        // Constructor to Intialize the object of patient
        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
            Height = height;
        }

        // for calculation of blood pressure
        public string CalculateBloodPressure(int systolic, int diastolic)
        {
            if (systolic < 0 || diastolic < 0)
            {
                return "Invalid blood pressure values";
            }

            if (systolic < 120 && diastolic < 80)
            {
                return "NORMAL";
            }
            else if (systolic < 130 && diastolic < 80)
            {
                return "ELEVATED";
            }
            else if (systolic < 140 || diastolic < 90)
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
            }
            else if (systolic < 180 || diastolic < 120)
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
            }
            else if (systolic >= 180 || diastolic >= 120)
            {
                return "HYPERTENSIVE CRISIS (consult your doctor immediately)";
            }
            else
            {
                return "Blood pressure values not in range";
            }
        }

        // for Calculation of body mass index (BMI)
        public double CalculateBMI()
        {
            double heightInMeter = Height / 100;
            return Weight / (heightInMeter * heightInMeter);
        }

        // INFORMATION OF PATIENT BASED ON RESULT
        public string GetPatientInfo()
        {
            string fullName = $"{FirstName} {LastName}";
            string bloodPressure = CalculateBloodPressure(120, 80);
            double bmi = CalculateBMI();
            string bmiStatus = "";

            if (bmi >= 25.0)
            {
                bmiStatus = "Overweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                bmiStatus = "Normal (In the healthy range)";
            }
            else
            {
                bmiStatus = "Underweight";
            }

            return $"Full Name: {fullName}\nWeight: {Weight} KG\nHeight: {Height} CM\nBlood Pressure: {bloodPressure}\nBMI: {bmi}\nBMI Status: {bmiStatus}";
        }
    }
}
