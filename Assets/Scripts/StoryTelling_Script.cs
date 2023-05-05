using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTelling_Script : MonoBehaviour
{
    [SerializeField] Text zunda_text;

    private bool click;
    private string[] wordArray;
    private string words = "今,日,は,と,て,も,天,気,が,い,い,の,だ,\n";
    public GameObject Button;
    public GameObject[] zundaPic;

    private string[] zunda_word = { "今日はとても天気がいいのだ" ,
                                    "こんな日はずんだもちを食べてお花見するのに限るのだ",
                                    "世間はかしわもちを食えとかほざくけど、頭が沸いてるとしか思えないのだ",
                                    "だけど、ずんだもちが花びらまみれになったら台無しなのだ",
                                    "さくらの花びらがつかないようにして、おいしいずんだもちを食べたいのだ"
                                  };
    private string show_word;

    int i;
    

    int say_num = 0;

    void Start()
    {
        Button.SetActive(false);
        StartCoroutine(DisplaySentence());
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

    IEnumerator DisplaySentence()
    {
        foreach(char x in zunda_word[i].ToCharArray())
        {
            zunda_text.text += x; //1文字ずつ追加
            yield return new WaitForSeconds(0.1f);
        }
        Button.SetActive(true);
    }

    public void OnClickButton()
    {
        Button.SetActive(false);
        if (i < zunda_word.Length - 1) //最後の文章でないなら
        {
            i++;
            zunda_text.text = ""; //現在の文章を白紙に
            StartCoroutine(DisplaySentence()); //次の文字送り開始
        }
    }
}
