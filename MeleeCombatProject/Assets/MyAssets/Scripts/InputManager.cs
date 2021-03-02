using UnityEngine;
using Player;

namespace General
{
    public class InputManager : MonoBehaviour
    {
        public GameObject playerPrefabs;
        IPlayer player;
        private void Start()
        {
            player = playerPrefabs.GetComponent<IPlayer>();
        }
        private void Update()
        {
            if (Input.GetButton("Sprint"))
                player.IsRunning = true;
            else
                player.IsRunning = false;
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
