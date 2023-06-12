using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float xSpeed;
    public float limitX;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        SwipeCheck();
        
    } 
    void SwipeCheck()
    {
        float newX = 0;
        float touchX = 0;
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            touchX = Input.GetTouch(0).deltaPosition.x / Screen.width;

        }
        else if (Input.GetMouseButton(0))
        {
            touchX = Input.GetAxis("Mouse X");
        }
        newX = transform.position.x + xSpeed * touchX * Time.deltaTime;
        newX = Mathf.Clamp(newX, -limitX, limitX);
        Vector3 newPosition = new Vector3(newX, transform.position.y, transform.position.z + speed * Time.deltaTime);
        transform.position = newPosition;
    }
}

   