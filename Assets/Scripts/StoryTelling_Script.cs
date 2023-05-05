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

    private string[] zunda_word = { "�����͂ƂĂ��V�C�������̂�" ,
                                    "����ȓ��͂��񂾂�����H�ׂĂ��Ԍ�����̂Ɍ���̂�",
                                    "���Ԃ́A�����������H���Ƃ������Ă��邯�ǁA�����������Ă��Ȃ��̂�",
                                    "�����ǁA���񂾂������Ԃт�܂݂�ɂȂ�����䖳���Ȃ̂�",
                                    "������̉Ԃт炪���Ȃ��悤�ɂ��āA�����������񂾂�����H�ׂ����̂�"
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
                zunda_text.text += x; //1�������ǉ�
                yield return new WaitForSeconds(0.15f);
            }
            Button.SetActive(true);
        }
        else
        {
            foreach (char x in zunda_word[i].ToCharArray())
            {
                zunda_text.text += x; //1�������ǉ�
                yield return new WaitForSeconds(0.15f);
            }
            SceneButton.SetActive(true);
        }
        
    }

    public void OnClickButton()
    {
        Button.SetActive(false);
        if (i < zunda_word.Length - 1) //�Ō�̕��͂łȂ��Ȃ�
        {
            i++;
            zundaPic[i - 1].SetActive(false);
            zundaPic[i].SetActive(true);
            zundaVoice[i].Play();
            zunda_text.text = ""; //���݂̕��͂𔒎���
            StartCoroutine(DisplaySentence()); //���̕�������J�n
        }
    }

    public void OnClickSceneButton()
    {
        SceneManager.LoadScene("Rule_Scene");
    }
}
