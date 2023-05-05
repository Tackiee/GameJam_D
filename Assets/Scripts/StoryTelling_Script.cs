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
    [SerializeField] GameObject[] zundaPic = new GameObject[5];
    [SerializeField] AudioSource[] zundaVoice = new AudioSource[5];

    private string[] zunda_word = { "今日はとても天気がいいのだ" ,
                                    "こんな日は、ずんだもちを食べてお花見するのに限るのだ",
                                    "世間は、さくらもちを食えとか言ってくるけど、何も分かっていないのだ",
                                    "だけど、ずんだもちが花びらまみれになったら台無しなのだ",
                                    "さくらの花びらがつかないようにしておいしいずんだもちを食べたいのだ"
                                  };
    private string show_word;

    int i;

    void Start()
    {
        Button.SetActive(false);
        SceneButton.SetActive(false);
        zundaVoice[i].Play();
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
                yield return new WaitForSeconds(0.15f);
            }
            Button.SetActive(true);
        }
        else
        {
            foreach (char x in zunda_word[i].ToCharArray())
            {
                zunda_text.text += x; //1文字ずつ追加
                yield return new WaitForSeconds(0.15f);
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
            zundaPic[i - 1].SetActive(false);
            zundaPic[i].SetActive(true);
            zundaVoice[i].Play();
            zunda_text.text = ""; //現在の文章を白紙に
            StartCoroutine(DisplaySentence()); //次の文字送り開始
        }
    }

    public void OnClickSceneButton()
    {
        SceneManager.LoadScene("Rule_Scene");
    }
}
