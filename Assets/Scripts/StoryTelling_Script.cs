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
        words = "Ç±,Ç±,Ç©,ÇÁ,êÊ,ÇÕ,2,Ç¬,Ç…,ìπ,Ç™,ï™,Ç©,ÇÍ,Çƒ,Ç¢,ÇÈ,ÇÊ,ÅB,\n";
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
