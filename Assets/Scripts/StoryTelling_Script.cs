using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTelling_Script : MonoBehaviour
{
    [SerializeField] Text zunda_text;

    private bool click;
    private string[] wordArray;
    private string words = "��,��,��,��,��,��,�V,�C,��,��,��,��,��,\n";
    public GameObject Button;
    public GameObject[] zundaPic;

    private string[] zunda_word = { "�����͂ƂĂ��V�C�������̂�" ,
                                    "����ȓ��͂��񂾂�����H�ׂĂ��Ԍ�����̂Ɍ���̂�",
                                    "���Ԃ͂����������H���Ƃ��ق������ǁA���������Ă�Ƃ����v���Ȃ��̂�",
                                    "�����ǁA���񂾂������Ԃт�܂݂�ɂȂ�����䖳���Ȃ̂�",
                                    "������̉Ԃт炪���Ȃ��悤�ɂ��āA�����������񂾂�����H�ׂ����̂�"
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

           /*���j�F�T���v���̕����̒����ƌ��݂̕����̒������قȂ�Ԃ͉�
            * ��v������A���̕��͂�}��
            * �N���b�N���J�n�ȊO�̎��ɂ��ꂽ��A���͂��Ō�܂ŕ\��
            */
           

        }
    }

    IEnumerator DisplaySentence()
    {
        foreach(char x in zunda_word[i].ToCharArray())
        {
            zunda_text.text += x; //1�������ǉ�
            yield return new WaitForSeconds(0.1f);
        }
        Button.SetActive(true);
    }

    public void OnClickButton()
    {
        Button.SetActive(false);
        if (i < zunda_word.Length - 1) //�Ō�̕��͂łȂ��Ȃ�
        {
            i++;
            zunda_text.text = ""; //���݂̕��͂𔒎���
            StartCoroutine(DisplaySentence()); //���̕�������J�n
        }
    }
}
