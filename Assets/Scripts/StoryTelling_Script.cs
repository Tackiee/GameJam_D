using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryTelling_Script : MonoBehaviour
{
    [SerializeField] Text zunda_text;

    public GameObject Button;
    public GameObject SceneButton;
    public GameObject[] zundaPic;

    private string[] zunda_word = { "今日はとても天気がいいのだ" ,
                                    "こんな日はずんだもちを食べてお花見するのに限るのだ",
                                    "世間はさくらもちを食えとかほざくけど、頭が沸いてるとしか思えないのだ",
                                    "だけど、ずんだもちが花びらまみれになったら台無しなのだ",
                                    "さくらの花びらがつかないようにして、おいしいずんだもちを食べたいのだ"
                                  };
    private string show_word;

    int i;

    void Start()
    {
        Button.SetActive(false);
        SceneButton.SetActive(false);
        StartCoroutine(DisplaySentence());
    }

    void Update()
    {
        
    }

    IEnumerator DisplaySentence()
    {
        if(i != zunda_word.Length - 1)
        {
            foreach (char x in zunda_word[i].ToCharArray())
            {
                zunda_text.text += x; //1文字ずつ追加
                yield return new WaitForSeconds(0.1f);
            }
            Button.SetActive(true);
        }
        else
        {
            foreach (char x in zunda_word[i].ToCharArray())
            {
                zunda_text.text += x; //1文字ずつ追加
                yield return new WaitForSeconds(0.1f);
            }
            SceneButton.SetActive(true);
        }
        
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

    public void OnClickSceneButton()
    {
        SceneManager.LoadScene("Rule_Scene");
    }
}
