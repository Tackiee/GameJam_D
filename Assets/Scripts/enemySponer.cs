
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySponer : MonoBehaviour
{
    public GameObject enemyPrefab;
    public static float enemyTime;
    public CountDown countDown;
    bool checker;

    // Start is called before the first frame update
    void Start()
    {
        enemyTime = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        checker = countDown.startChecker;
        if (checker)
        {
            enemyTime -= Time.deltaTime;
            if (enemyTime < 0)
            {
                Instantiate(enemyPrefab, this.transform.position + new Vector3(Random.Range(-20.0f, 20.0f), 10, Random.Range(-20.0f, 20.0f)), this.transform.rotation);
                enemyTime = 0.1f;
            }
        }
        
        
    }
}
