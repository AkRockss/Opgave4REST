using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opgave4REST.Models
{
    public class FootBallPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ShirtNumber { get; set; }


        public FootBallPlayer()
        {
            
        }

        public FootBallPlayer(int id, string name, double price, int shirtNumber)
        {
            Id = id;
            Name = name;
            Price = price;
            ShirtNumber = shirtNumber;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
