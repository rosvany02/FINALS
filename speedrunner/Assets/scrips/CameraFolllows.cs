
using UnityEngine;

public class CameraFolllows : MonoBehaviour {

    public Transform target;

    public float smoothSpeed = 900f;
    public Vector3 offset;

   void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothposition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothposition;

        transform.LookAt(target);
    }
}
