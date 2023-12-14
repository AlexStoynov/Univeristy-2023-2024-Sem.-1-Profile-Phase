using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BikeTrip
{
    public class Trip
    {
        private string destination;
        private double distance;
        private double rating;
        private TransportationType transportation;

        public Trip(string destination, double distance, double rating)
        {
            this.destination = destination;
            this.distance = distance;
            this.rating = rating;
            this.transportation = TransportationType.BICYCLE;
        }

        public Trip(string destination, double distance, double rating, TransportationType transportation)
        {
            this.destination = destination;
            this.distance = distance;
            this.rating = rating;
            this.transportation = transportation;
        }

        public string Destination {  get { return destination; } }
        public double Distance { get { return distance; } }
        public double Rating { get { return rating; } }

        public override string ToString()
        {
            return $"{this.destination} - {this.distance:f2} KM by {this.transportation} with a rating of {this.rating}";
        }
    }
}
