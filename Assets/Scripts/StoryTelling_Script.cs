using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTelling_Script : MonoBehaviour
{
    [SerializeField] Text zunda_text;
    private string[] wordArray;
    private string words = "ç°,ì˙,ÇÕ,Ç∆,Çƒ,Ç‡,ìV,ãC,Ç™,Ç¢,Ç¢,ÇÃ,Çæ,\n";

    private bool clickPrevent = false;

    void Start()
    {
        words = "Ç±,Ç±,Ç©,ÇÁ,êÊ,ÇÕ,2,Ç¬,Ç…,ìπ,Ç™,ï™,Ç©,ÇÍ,Çƒ,Ç¢,ÇÈ,ÇÊ,ÅB,\n";
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
