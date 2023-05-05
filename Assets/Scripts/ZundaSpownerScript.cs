using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZundaSpownerScript : MonoBehaviour
{
    public GameObject zundaPrefab;
    public static float zundaTime;
    public CountDown countDown;
    bool checker;

    // Start is called before the first frame update
    void Start()
    {
        zundaTime = 4.0f;
    }

    // Update is called once per frame
    void Update()
    {
        checker = countDown.startChecker;
        if (checker)
        {
            zundaTime -= Time.deltaTime;
            if (zundaTime < 0)
            {
                Instantiate(zundaPrefab, this.transform.position + new Vector3(Random.Range(-20.0f, 20.0f), 0, Random.Range(-20.0f, 20.0f)), this.transform.rotation);
                zundaTime = 4.0f;
            }
        }


    }
}
