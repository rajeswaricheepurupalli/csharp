using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AASIGNMENT_3.EMSystem;

namespace AASIGNMENT_3
{
    public class Program
    {
        public static void Main()
        {
            Manager M1 = new Manager();
            M1.Salary = 50000;
            M1.TA = 1000;
            M1.HRA = 1000;
            M1.DA = 500;
            M1.Calculate();
            M1.SalaryCalculate();
            Console.ReadLine();

            MarketingExecutive obj = new MarketingExecutive();
            obj.Salary = 40000;
            obj.TA = 1000;
            obj.HRA = 500;
            obj.DA = 1000;
            obj.Cal();
            obj.SalaryCalculate();
            Console.ReadLine();



        }



    }
    public class EMSystem
    {
        public double TA;
        public double HRA;
        public double DA;
        public double Salary;
        double NetSalary;
        double GrossSalary;

        public virtual void SalaryCalculate()
        {
            NetSalary = GrossSalary - (TA + HRA + DA);
            Console.WriteLine(NetSalary);
        }





        public class Manager : EMSystem
        {
            private double PetrolAllowance;
            private double FoodAllowance;
            private double OtherAllowances;

            public void Calculate()
            {
                PetrolAllowance = 8 * Salary / 100;
                FoodAllowance = 13 * Salary / 100;
                OtherAllowances = 13 * Salary / 100;

                GrossSalary = PetrolAllowance + FoodAllowance + OtherAllowances;
                Console.WriteLine("GrossSalary of Managr = {0}", GrossSalary);

            }
            public override void SalaryCalculate()
            {
                NetSalary = GrossSalary - (TA + HRA + DA);
                Console.WriteLine("NetSalary of Manager = {0}", NetSalary);
            }
        }


        public class MarketingExecutive : EMSystem

        {
            private double KilometerTravel = 5000;
            private double TourAllowances = 5 * 5000;
            private double TelephoneAllowances = 1000;

            public void Cal()
            {
                GrossSalary = KilometerTravel + TourAllowances + TelephoneAllowances;
                Console.WriteLine("marketexecutive GrossSalary = {0}", GrossSalary);
            }
            public override void SalaryCalculate()
            {
                NetSalary = GrossSalary - (TA + HRA + DA);
                Console.WriteLine("marketexecutiveSalary = {0}", NetSalary);

            }
        }

    }
}