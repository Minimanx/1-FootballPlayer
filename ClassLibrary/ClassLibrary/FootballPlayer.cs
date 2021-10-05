using System;

namespace ClassLibrary
{
    public class FootballPlayer
    {
        private int _id;
        private string _name;
        private int _price;
        private int _shirtNumber;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _name = value;
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _price = value;
            }
        }

        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value >= 1 && value <= 100)
                {
                    _shirtNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public FootballPlayer(string name, int price, int shirtNumber)
        {
            Price = price;
            Name = name;
            ShirtNumber = shirtNumber;
        }

        public FootballPlayer()
        {

        }
    }
}
