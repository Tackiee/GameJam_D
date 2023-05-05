using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreShowScript : MonoBehaviour
{
    public Text ScoreShow;
    // Start is called before the first frame update
    void Start()
    {
        ScoreShow.text = PlayTimeManager.count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
