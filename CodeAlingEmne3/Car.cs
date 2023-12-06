using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlingEmne3
{
    internal class Car
    {
        private int _speed;
        private int _acceleration;

        public Car(int speed, int acceleration)
        {
            _speed = speed;
            _acceleration = acceleration;
        }

        public Car()
        {

        }

        public int Drive(int distance)
        {
            return distance += _speed;
        }
        public void Accelerate()
        {
            _speed += _acceleration;
        }

        public void Decelerate()
        {
            _speed -= _acceleration;
            if (_speed < 10)
            {
                _speed = 10;
            }
        }

        public void SetRandomSpeed()
        {
            _speed = new Random().Next(60, 201);
        }
    }
}
