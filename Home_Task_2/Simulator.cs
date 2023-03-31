using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_2
{
    internal class Simulator
    {
        private WaterTower _waterTower; // liters/minute
        private List<User>? _users;

        public Simulator(WaterTower waterTower, List<User>? users = null)
        {
            WaterTower = waterTower;
            if (users != null && users.Count != 0)
            {
                Users = users;
            }
            else
            {
                _users = new List<User>()
                {
                    new User(1, "Alex Adams"),
                    new User(2, "Marichka Chychevychka"),
                    new User(3, "Admin Admin"),
                    new User(4, "Sad Novelist"),
                    new User(5, "Grave Nuclear")
                };
            }
        }

        // default generated Property, almost
        internal WaterTower WaterTower { get => _waterTower; set => _waterTower = value; }
        internal List<User>? Users { get => _users; set => _users = value; }

        // Invoke this method from user, or check invoking method User -> ConsumeWater()
        // maybe use attrs (like decorators in python)
        //public void ConsumeWater(User user) { }

        // invoke after every user consumption
        public void CheckCurrentWaterLevel() { }
        public void TurnPumpOn() { }
        public void TurnPumpOff() { }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Simulator info: {\n");
            stringBuilder.AppendLine($"{_waterTower.ToString()}\n");
            stringBuilder.AppendLine("Users:{");
            foreach(var user in _users)
            {
                stringBuilder.AppendLine("   " + user.ToString());
            }
            stringBuilder.AppendLine("}");
            return stringBuilder.ToString();
        }

    }
}
