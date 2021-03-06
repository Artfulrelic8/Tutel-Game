using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float deadzonex;
    public float deadzoney;
    private float dx;
    private float dy;
    float speed = 0.06f;
    float zoomSpeed = 10f;
    public float rotateSpeed = 0.01f;

    float maxHeight = 60f;
    float minHeight = 11f;

    Vector2 p1;
    Vector2 p2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0.06f;
            zoomSpeed = 20.0f;
        } else
        {
            speed = 0.035f;
            zoomSpeed = 10.0f;
        }

        float hsp = transform.position.y * speed * Input.GetAxis("Horizontal");
        float vsp = transform.position.y * speed * Input.GetAxis("Vertical");
        float scrollSp = Mathf.Log(transform.position.y) * -zoomSpeed * Input.GetAxis("Mouse ScrollWheel");

        if((transform.position.y >= maxHeight) && (scrollSp > 0))
        {
            scrollSp = 0;
        } 
        else if ((transform.position.y <= minHeight) && (scrollSp > 0))
        {
            scrollSp = 0;
        }

        if((transform.position.y + scrollSp) > maxHeight)
        {
            scrollSp = maxHeight - transform.position.y;
        }
        else if ((transform.position.y + scrollSp) < minHeight)
        {
            scrollSp = 0;
        }

        Vector3 verticalMove = new Vector3(0, scrollSp, 0);
        Vector3 lateralMove = hsp * transform.right;
        Vector3 forwardMove = transform.forward;
        forwardMove.y = 0;
        forwardMove.Normalize();
        forwardMove *= vsp;

        Vector3 move = verticalMove + lateralMove + forwardMove;

        transform.position += move;
        getCameraRotation();
    }
    public float approxSpeed;
    void getCameraRotation()
    {
        if (Input.GetMouseButtonDown(2))
        {
            p1 = Input.mousePosition;
        }

        if (Input.GetMouseButton(2))
        {
            p2 = Input.mousePosition;

            dx = (p2 - p1).x * rotateSpeed;
            Debug.Log(dx);
            
            dy = (p2 - p1).y * rotateSpeed;
            p1.x += (p2.x - p1.x) * approxSpeed;
            

            transform.rotation *= Quaternion.Euler(new Vector3(0, dx, 0));
        }
    }
}
