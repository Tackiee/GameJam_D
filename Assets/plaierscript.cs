using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class plaierscript : MonoBehaviour
{
    int speed = 5;
    static bool isGround = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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

        if (isGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.transform.position += new Vector3(0, 500 * Time.deltaTime, 0);
            }
        }


    }
   
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Debug.Log("Hit");
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
