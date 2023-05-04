using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTimeManager : MonoBehaviour
{
    public CountDown countDown;
    float timer = 20.0f;
    bool checker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timer);
        checker = countDown.startChecker;
        if (checker)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                timer = 0.0f;
            }
        }
    }
}
