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
        Car[] carList = new Car[6];

        Car car1 = new Car();
        Car car2 = new Car();
        Car car3 = new Car();
        Car car4 = new Car();
        Car car5 = new Car();
        Car car6 = new Car();



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

        public Car makeYourCar()
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
                    car1.model = inputModel;
                    car1.year = inputYear;
                    car1.inputColor = inputColor;
                    car1.inputTransmission = inputTransmission;

                    return car1;
                }
                else if (i == 1)
                {
                    car2.model = inputModel;
                    car2.year = inputYear;
                    car2.inputColor = inputColor;
                    car2.inputTransmission = inputTransmission;

                    return car2;
                }
                else if (i == 2)
                {
                    car3.model = inputModel;
                    car3.year = inputYear;
                    car3.inputColor = inputColor;
                    car3.inputTransmission = inputTransmission;

                    return car3;
                }
                else if (i == 3)
                {
                    car4.model = inputModel;
                    car4.year = inputYear;
                    car4.inputColor = inputColor;
                    car4.inputTransmission = inputTransmission;

                    return car4;
                }
                else if (i == 4)
                {
                    car5.model = inputModel;
                    car5.year = inputYear;
                    car5.inputColor = inputColor;
                    car5.inputTransmission = inputTransmission;

                    return car5;
                }
                else if (i == 5)
                {
                    car6.model = inputModel;
                    car6.year = inputYear;
                    car6.inputColor = inputColor;
                    car6.inputTransmission = inputTransmission;

                    return car6;
                }

            }
            return car1;
           
            
        }

        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public string Color { get => color; set => color = value; }
        public bool Automatic { get => automatic; set => automatic = value; }

       

    }
}
