using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
	private bool countFinish = false;
	public bool startChecker
	{
		get { return this.countFinish; }
		//private set { this.countFinish = value; }
	}
	public Text CountText;
    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine(CountdownCoroutine());
	}

    // Update is called once per frame
    void Update()
    {
		if(countFinish)
        {
			Debug.Log("カウント終了");
        }
    }

	IEnumerator CountdownCoroutine()
	{
		Debug.Log("5");
		CountText.text = "5";
		yield return new WaitForSeconds(1.0f);
		
		Debug.Log("4");
		CountText.text = "4";
		yield return new WaitForSeconds(1.0f);

		Debug.Log("3");
		CountText.text = "3";
		yield return new WaitForSeconds(1.0f);

		Debug.Log("2");
		CountText.text = "2";
		yield return new WaitForSeconds(1.0f);

		Debug.Log("1");
		CountText.text = "1";
		yield return new WaitForSeconds(1.0f);

		Debug.Log("GO!");
		CountText.text = "GO!";
		countFinish = true;
		yield return new WaitForSeconds(2.0f);

		CountText.gameObject.SetActive(false);
	}
}
