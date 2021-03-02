using UnityEngine;
using General;

namespace Player.MoveDirection
{
    public class ThridPersonCamera : IMovementDirection
    {
        public Vector3 getDirection()   //return direction value of camera's direction
        {
            Vector3 forward = CameraManager.getCameraForwardDirectionNormalized();
            Vector3 right = CameraManager.getCameraRightDirectionNormalized();
            return forward * InputManager.getVerInput() + right * InputManager.getHorInput();
        }
    }
}
