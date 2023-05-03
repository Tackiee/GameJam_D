using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTelling_Script : MonoBehaviour
{
    [SerializeField] Text zunda_text;
    private string[] wordArray;
    private string words;

    void Start()
    {
        words = "こ,こ,か,ら,先,は,2,つ,に,道,が,分,か,れ,て,い,る,よ,。,\n";
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            wordArray = words.Split(',');
            StartCoroutine("SetText");
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
