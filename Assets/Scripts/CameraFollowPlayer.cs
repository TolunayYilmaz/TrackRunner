using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform camTarget;
    public float speed;
    public Vector3 distance;
    public Transform lookTarget;

    private void LateUpdate()
    {
        Vector3 dPos = camTarget.position + distance;
        Vector3 sPos = Vector3.Lerp(transform.position,dPos,speed*Time.deltaTime);
        transform.position = sPos;  
        transform.LookAt(lookTarget.position);
    }
}
