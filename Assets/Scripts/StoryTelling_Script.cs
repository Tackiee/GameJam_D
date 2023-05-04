using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTelling_Script : MonoBehaviour
{
    [SerializeField] Text zunda_text;
    private string[] wordArray;
    private string words = "今,日,は,と,て,も,天,気,が,い,い,の,だ,\n";

    private bool clickPrevent = false;

    void Start()
    {
        words = "こ,こ,か,ら,先,は,2,つ,に,道,が,分,か,れ,て,い,る,よ,。,\n";
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPrevent = true;
            wordArray = words.Split(',');
            StartCoroutine("SetText");
            string[] removeChars = { "," };
            foreach (string c in removeChars)
            {
                words = words.Replace(c.ToString(), "");
            }
            if(zunda_text.ToString() == words)
            {
                clickPrevent = false;
            }
        }
    }

    IEnumerator SetText()
    {
        foreach (var p in wordArray)
        {
            zunda_text.text = zunda_text.text + p;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
