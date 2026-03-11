using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    void LateUpdate()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y, -10);
        transform.position = newPos;
    }
}