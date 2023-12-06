using CodeAlingEmne3;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int _distance = 0;

            var car = new Car(10, 10);

            while (_distance < 1000)
            {
                if (_distance >= 500)
                {
                    car.Decelerate();
                }
                else
                {
                    car.Accelerate();
                }
                _distance = car.Drive(_distance);
                
                Console.WriteLine(_distance);
            }
            Console.WriteLine("Bilen er fremme og er parkert");
            Console.WriteLine();

            int Iteration = 0;
            int _car1Distance = 0;
            int _car2Distance = 0;

            var car1 = new Car();
            var car2 = new Car();

            while (_car1Distance < 10000 && _car2Distance < 10000)
            {
                Iteration++;
                car1.SetRandomSpeed();
                car2.SetRandomSpeed();
                _car1Distance = car1.Drive(_car1Distance);
                _car2Distance = car2.Drive(_car2Distance);
                Console.WriteLine($"{Iteration} seconds into the race");
                Console.WriteLine($"Car 1: {_car1Distance}");
                Console.WriteLine($"Car 2: {_car2Distance}");
            }

            if (_car1Distance > _car2Distance)
            {
                Console.WriteLine("Car number 1 Won!");
            }
            else
            {
                Console.WriteLine("Car number 2 Won!");
            }

            Console.WriteLine($"Car 1 distance: {_car1Distance}\nCar 2 distance: {_car2Distance}");
        }
    }
}