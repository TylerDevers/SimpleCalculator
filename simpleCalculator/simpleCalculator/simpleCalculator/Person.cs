using System;

namespace simpleCalculator
{
    public class Person
    {
        private int _age = 25;

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int newAge)
        {
            _age = newAge;
        }

    }
}
