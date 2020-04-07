using System;

namespace Animals
{
    public interface IAnimal
    {
        void Move();
        void StopMoving();
        void Born();
        void Die();

        Tuple<int, double> GetInfo();
    }
}
