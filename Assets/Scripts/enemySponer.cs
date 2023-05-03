
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySponer : MonoBehaviour
{
    public GameObject enemyPrefab;
    public static float enemyTime;

    // Start is called before the first frame update
    void Start()
    {
        enemyTime = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        enemyTime -= Time.deltaTime;
        if (enemyTime < 0)
        {
            Instantiate(enemyPrefab, this.transform.position + new Vector3(Random.Range(-10.0f, 10.0f), 10, Random.Range(-10.0f, 10.0f)), this.transform.rotation);
            enemyTime = 2.0f;
        }
        
    }
}
