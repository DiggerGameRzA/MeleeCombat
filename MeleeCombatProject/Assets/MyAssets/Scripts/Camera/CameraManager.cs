using UnityEngine;

public class CameraManager : MonoBehaviour
{
    static new UnityEngine.Camera camera;
    private void Start()
    {
        camera = UnityEngine.Camera.main;               //set this variable equal to main camera in scene
        Cursor.visible = false;
    }
    public static Vector3 getCameraForwardDirection()   //return forward value of camera direction
    {
        return camera.transform.forward;
    }
    public static Vector3 getCameraRightDirection()     //return right value of camera direction
    {
        return camera.transform.right;
    }
    public static Vector3 getCameraForwardDirectionNormalized()     //return normalized forward value of camera direction
    {
        Vector3 forward = getCameraForwardDirection();
        forward.y = 0;
        return forward.normalized;
    }
    public static Vector3 getCameraRightDirectionNormalized()       //return normalized right value of camera direction
    {
        Vector3 right = getCameraRightDirection();
        right.y = 0;
        return right.normalized;
    }
}
