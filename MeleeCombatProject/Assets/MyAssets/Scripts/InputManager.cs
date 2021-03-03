using UnityEngine;
using Player;

namespace General
{
    public class InputManager : MonoBehaviour
    {
        public GameObject playerPrefabs;        //Get player's prefab
        IPlayer player;
        private void Start()
        {
            player = playerPrefabs.GetComponent<IPlayer>();
        }
        private void Update()
        {
            if (Input.GetButton("Sprint"))      //When press run
                player.IsRunning = true;
            else
                player.IsRunning = false;

            if (Input.GetButtonDown("Fire1"))   //When press left mouse
            {
                player.getAttackManager().lightAttack();
            }
            else
                player.getAttackManager().countdownTime();
        }
        public static float getHorInput()   //return horizontal value
        {
            return Input.GetAxis("Horizontal");
        }
        public static float getVerInput()   //return vertical value
        {
            return Input.GetAxis("Vertical");
        }
        public static float getMagnitude()  //return magnitude of horizontal and vertical value
        {
            return Mathf.Clamp01(new Vector2(getVerInput(), getHorInput()).magnitude);
        }
    }
}
