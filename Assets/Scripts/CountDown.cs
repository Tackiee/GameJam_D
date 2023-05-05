using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
	private bool countFinish = false;
	[SerializeField] AudioSource count321;
	[SerializeField] AudioSource count0;
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
		Debug.Log("3");
		CountText.text = "3";
		count321.Play();
		yield return new WaitForSeconds(1.0f);

		Debug.Log("2");
		CountText.text = "2";
		count321.Play();
		yield return new WaitForSeconds(1.0f);

		Debug.Log("1");
		CountText.text = "1";
		count321.Play();
		yield return new WaitForSeconds(1.0f);

		Debug.Log("GO!");
		count0.Play();
		CountText.text = "GO!";
		countFinish = true;
		yield return new WaitForSeconds(2.0f);

		CountText.gameObject.SetActive(false);
	}
}
