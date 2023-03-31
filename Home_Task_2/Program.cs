using Home_Task_2;

Pump defaultPump = new Pump(500);
WaterTower defaultWaterTower = new WaterTower(10000, 1000, 500, defaultPump);

Simulator simulator = new Simulator(defaultWaterTower);

Random rnd = new Random();
foreach(var user in simulator.Users)
{
    user.ConsumeWater(rnd.Next(10, 100));
}

Console.WriteLine(defaultPump);
Console.WriteLine(defaultWaterTower);
Console.WriteLine(simulator);