using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTelling_Script : MonoBehaviour
{
    [SerializeField] Text zunda_text;
    private string[] wordArray;
    private string words = "今,日,は,と,て,も,天,気,が,い,い,の,だ,\n";

    private string[] zunda_word;
    private string show_word;

    int say_num = 0;

    void Start()
    {
        words = "こ,こ,か,ら,先,は,2,つ,に,道,が,分,か,れ,て,い,る,よ,。,\n";
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

           /*方針：サンプルの文字の長さと現在の文字の長さが異なる間は回す
            * 一致したら、次の文章を挿入
            * クリックが開始以外の時にされたら、文章を最後まで表示
            */
           

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
