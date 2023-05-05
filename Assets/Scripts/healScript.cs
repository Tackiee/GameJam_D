using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healScript : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0.2f);
        }
    }
}
