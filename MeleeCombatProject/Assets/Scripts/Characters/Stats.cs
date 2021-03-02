using UnityEngine;

namespace Characters
{
    public class Stats : MonoBehaviour
    {
        [Header("Health")]
        public float maxHealth = 100;           //Max Health

        [Header("Attack")]
        public float attackDelay = 0.9f;        //Attack Delay(second)
        public float attackDamage = 20f;        //Main Attack Damage
        public float[] damageMultiple = new float[3];   //Damage Multiple for attack combo

        [Header("Movement")]
        public float walkSpeed = 10f;           //Walking Speed
        public float runSpeed = 20f;            //Running Speed
        public float rotationSpeed = 5f;        //Rotating Speed
    }
}
