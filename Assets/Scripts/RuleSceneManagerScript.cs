using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RuleSceneManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MovetoMain()
    {
        SceneManager.LoadScene("playFild");
    }

    public void MovetoOperation()
    {
        SceneManager.LoadScene("OperationManual_Scene");
    }

    public void MovetoItem()
    {
        SceneManager.LoadScene("ItemManual_Scene");
    }
}
