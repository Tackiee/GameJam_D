using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTelling_Script : MonoBehaviour
{
    [SerializeField] Text zunda_text;
    private string[] wordArray;
    private string words = "��,��,��,��,��,��,�V,�C,��,��,��,��,��,\n";

    private string[] zunda_word;
    private string show_word;

    int say_num = 0;

    void Start()
    {
        words = "��,��,��,��,��,��,2,��,��,��,��,��,��,��,��,��,��,��,�B,\n";
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

    IEnumerator SetText()
    {
        foreach (var p in wordArray)
        {
            zunda_text.text = zunda_text.text + p;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
