using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class plaierscript : MonoBehaviour
{
    public static int speed = 5;
    public Vector2 rotationSpeed = new Vector2(0.1f, 0.1f);
    public bool reverse;
    private Camera mainCamera;
    private Vector2 lastMousePosition;
    private Vector2 newAngle = Vector2.zero;
    public GameObject[] lifeArray = new GameObject[3];
    private int lifePoint = 3;
    private Rigidbody rb;
    private bool isGround;

    void Start()
    {
        mainCamera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
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

        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rb.AddForce(new Vector3(0, speed * 100, 0));
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

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Plane")
        {
            isGround = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Plane")
        {
            isGround = false;
        }
    }


    public void speedUp(int s)
    {
        StartCoroutine(speedChange(s));

    }

    public IEnumerator speedChange(int k)
    {
        speed += k;
        Debug.Log(speed);
        yield return new WaitForSeconds(3.0f);
        speed -= k;
        Debug.Log(speed);

    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "enemy" && lifePoint > 0)
        {
            Debug.Log("Hit");
            lifeArray[lifePoint - 1].SetActive(false);
            lifePoint--;
        }

        if (col.gameObject.tag == "heal" && lifePoint < 3)
        {
            lifePoint++;
            lifeArray[lifePoint - 1].SetActive(true);
        }

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
