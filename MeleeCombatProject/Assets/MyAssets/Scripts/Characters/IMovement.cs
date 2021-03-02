using UnityEngine;

namespace Characters.Movement
{
    public interface IMovement
    {
        void walk(Vector3 direction);
        void run(Vector3 direction);
    }
}