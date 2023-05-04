using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class player : MonoBehaviour
{
    public CountDown countDown;

    int speed = 5;
    static bool isGround = true;
    // Start is called before the first frame update
    public Vector2 rotationSpeed = new Vector2(0.1f, 0.1f);
    public bool reverse;

    bool checker;

    private Camera mainCamera;
    private Vector2 lastMousePosition;
    private Vector2 newAngle = Vector2.zero;
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        checker = countDown.startChecker;
        if(checker)
        {
            if (Input.GetKey(KeyCode.W))
            {
                this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                this.transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            }

            if (isGround)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    this.transform.position += new Vector3(0, 500 * Time.deltaTime, 0);
                }
            }
            if (Input.GetMouseButtonDown(0))
            {
                newAngle = mainCamera.transform.localEulerAngles;
                lastMousePosition = Input.mousePosition;
            }
            else if (Input.GetMouseButton(0))
            {
                if (!reverse)
                {
                    newAngle.y -= (lastMousePosition.x - Input.mousePosition.x) * rotationSpeed.y;
                    newAngle.x -= (Input.mousePosition.y - lastMousePosition.y) * rotationSpeed.x;

                    mainCamera.transform.localEulerAngles = newAngle;
                    lastMousePosition = Input.mousePosition;
                }
                else
                {
                    newAngle.y -= (Input.mousePosition.x - lastMousePosition.x) * rotationSpeed.y;
                    newAngle.x -= (lastMousePosition.y - Input.mousePosition.y) * rotationSpeed.x;

                    mainCamera.transform.localEulerAngles = newAngle;
                    lastMousePosition = Input.mousePosition;
                }
            }
        }

    }

    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.tag == "fild")
        {
            isGround = true;
        }

    }

    void OnCollisionExit(Collision obj)
    {
        if (obj.gameObject.tag == "fild")
        {
            isGround = false;
        }

    }
    

    
}
