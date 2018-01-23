using System;
using System.ComponentModel;

namespace ConsoleAppPlayTime
{
    class Program
    {

      
        static void Main(string[] args)
        {

            Car[] carList = new Car[6];

            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();
            Car car4 = new Car();
            Car car5 = new Car();
            Car car6 = new Car();




            Console.WriteLine("Hello World!");
            Console.ReadLine();

            Car myCar = new Car();
            myCar.Color = "black";
            myCar.Automatic = true;
            myCar.Model = "Porche";
            myCar.Year = 2017;

            Car mySecondCar = new Car();
            mySecondCar.Color = "Red";
            mySecondCar.Year = 2000;
            mySecondCar.Model = "Trans Am";
            mySecondCar.Automatic = false;

            Car myThirdCar = new Car("Tesla",2018,"Purple", false);


            Console.WriteLine("My new car is a {0} {1} {2} {3} " ,myCar.Automatic,myCar.Color, myCar.Model,myCar.Year);
            Console.ReadLine();

            Console.WriteLine("My second car is a {0} {1} {2} {3} ", mySecondCar.Automatic, mySecondCar.Color, mySecondCar.Model, mySecondCar.Year);
            Console.ReadLine();

            Console.WriteLine("My second car is a {0} {1} {2} {3} ", myThirdCar.Model, myThirdCar.Year, myThirdCar.Color, myThirdCar.Automatic);
            Console.ReadLine();




            Car newCar = new Car();

            newCar.makeYourCar();
            newCar.showCar();
            
                  
        
        }

    }

    class Car
    {


        private string model;
        private int year;
        private string color;
        private string transmission;
        private bool automatic;

        private string inputModel;
        private int inputYear;
        private string inputColor;
        private string inputTransmission;
        private Car car1;
        private Car car2;

        //


        public Car()
        {
            model = "Firebird";
        }

        public Car(string model, int year, string color, bool automatic)
        {
            Model = model;
            Year = year;
            Color = color;
            Automatic = automatic;
           
        }

        public void showCar()
        {

            Console.WriteLine("You chose to drve a {0} {1} {2} {3}", inputModel, inputYear, inputColor, inputTransmission);
            Console.ReadLine();

            Console.WriteLine("Here are your cars");

            Console.WriteLine("car 1:");

            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(car1);

            EventDescriptorCollection events = TypeDescriptor.GetEvents(car1);


            foreach (PropertyDescriptor pd in props)
                Console.WriteLine(pd.DisplayName);


        }

        public void makeYourCar()
        {

           
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("What kind of car do you want?");
                inputModel = Console.ReadLine();

                Console.WriteLine("What year?");
                inputYear = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Color?");
                inputColor = Console.ReadLine();

                Console.WriteLine("Press 1 for Automatic and 2 for manual transmission");
                inputTransmission = Console.ReadLine();
                if (inputTransmission == "1")
                {
                    this.transmission = "Auto";
                }
                else
                {
                    this.transmission = "Manual";
                }

                if (i == 0)
                {
                    model = inputModel;
                    year = inputYear;
                    color = inputColor;
                    transmission = inputTransmission;

                   
                }
                else if (i == 1)
                {
                    model = inputModel;
                    year = inputYear;
                  color = inputColor;
                    transmission = inputTransmission;

              
                }
                else if (i == 2)
                {
                    model = inputModel;
                    year = inputYear;
                    color = inputColor;
                    transmission = inputTransmission;

             
                }
                else if (i == 3)
                {
                   model = inputModel;
                    year = inputYear;
                  color = inputColor;
                   transmission = inputTransmission;

                
                }
                else if (i == 4)
                {
                   model = inputModel;
                    year = inputYear;
                  color = inputColor;
                   transmission = inputTransmission;

                    
                }
                else if (i == 5)
                {
                    model = inputModel;
                    year = inputYear;
                    color = inputColor;
                  transmission = inputTransmission;

                    
                }

            }
           
           
            
        }

        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public string Color { get => color; set => color = value; }
        public bool Automatic { get => automatic; set => automatic = value; }

       

    }
}
