using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_2
{
    internal class User
    {
        public int Id { get; set; }
        public float WaterConsumption { get; set; }
        public string Name { get; set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
        // default generated Property, almost
        // TODO add invoke from Simulator maybe? Or transfer data from here in some way
        public void ConsumeWater(float waterConsumption) { }

        public override string ToString()
        {
            return $"{{Id: {Id}, Water consumption: {WaterConsumption}, Name: {Name}}}";
        }
    }
}
