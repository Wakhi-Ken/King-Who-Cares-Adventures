using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float fixedY = 0f;

    void LateUpdate()
    {
        Vector3 newPos = new Vector3(target.position.x, fixedY, -10);
        transform.position = newPos;
    }
}