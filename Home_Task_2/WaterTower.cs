using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_2
{
    internal class WaterTower
    {
        private float _maxCapacity;
        private float _currentCapacity;
        private float _minCapacity;

        private bool _isEmpty;
        private bool _isFull;

        private Pump _pump; // TODO add prop?

        public WaterTower(float maxCapacity, float currentCapacity, float minCapacity, Pump pump, bool isEmpty = false, bool isFull = true)
        {
            (string message, bool validationResult) capacityValidator = Validator.ValidateWaterTowerMaxCapacity(maxCapacity);
            if (capacityValidator.validationResult)
            {
                MaxCapacity = maxCapacity;
            }
            else
            {
                Console.WriteLine(capacityValidator.message);
                return;
            }

            capacityValidator = Validator.ValidateWaterTowerMinCapacity(minCapacity, _maxCapacity);
            if (capacityValidator.validationResult)
            {
                MinCapacity = minCapacity;
            }
            else
            {
                Console.WriteLine(capacityValidator.message);
                return;
            }

            capacityValidator = Validator.ValidateWaterTowerCurrentCapacity(currentCapacity, _maxCapacity);
            if (capacityValidator.validationResult)
            {
                CurrentCapacity = currentCapacity;
            }
            else
            {
                Console.WriteLine(capacityValidator.message);
                return;
            }
            IsEmpty = isEmpty;
            IsFull = isFull;
            _pump = pump;
        }

        // default generated Property, almost
        // TODO change in future if needable.
        public float MaxCapacity { get => _maxCapacity; private set => _maxCapacity = value; }
        public float CurrentCapacity { get => _currentCapacity; set => _currentCapacity = value; }
        public float MinCapacity { get => _minCapacity; set => _minCapacity = value; }

        public bool IsEmpty { get => _isEmpty; set => _isEmpty = value; }
        public bool IsFull { get => _isFull; set => _isFull = value; }

        public override string? ToString()
        {
            return "Water tower info {" +
                    $"   Max capacity:\t{_maxCapacity}" + "\n" +
                    $"   Current capacity:\t{_currentCapacity}" + "\n" +
                    $"   Min capacity:\t{_minCapacity}" + "\n" +
                    $"   Is empty:\t{_isEmpty}" + "\n" +
                    $"   Is full:\t{_isFull}" + "\n" +
                    $" {_pump.ToString()}" + "\n" +
                    "}";
        }
    }
}
