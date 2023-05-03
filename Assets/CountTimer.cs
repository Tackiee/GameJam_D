using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountTimer : MonoBehaviour
{
    public static float CountDown;
    public TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        CountDown = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        CountDown -= Time.deltaTime;
        timerText.text = CountDown.ToString();
        if (CountDown < 0)
        {
            timerText.text = "Game Over";
        }
    }
}
