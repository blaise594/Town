using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class House
    {
        public string Name { get; set; }
        public string DisplayName()
        {
            return Name;
        }



        public override string ToString() {
            return $"house : {Name}";
}
        
        
         
        public int NumberOfRoom { get; set; }
        public string ConstructionMaterial { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public int SquareFootage { get; }
        public int Floors { get; set; }
        public int BedRooms { get; set; }
        public int BathRooms { get; set; }
        public int Volume { get; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string FullAddress
        {
            get
            {
                return $"{this.Address1} {this.Address2}  {this.city}  {this.state}  {this.zip }";

            }
        }
        public int CurrentOccupants { get { return _CurrentOccupants; } }
        private int _CurrentOccupants;
        public void IncreaseOccupants()
        {
            _CurrentOccupants++;
        }
        public void DecreaseOccupants()
        {
            _CurrentOccupants--;
        }
    }
}