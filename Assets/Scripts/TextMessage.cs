using UnityEngine;
using System.Collections;

public class TextMessage : MonoBehaviour {
	
	public GameObject textMessageText;
	public float delay = 37f;
	
	// Use this for initialization
	void Start () {
		Invoke ("showTextMessage", delay);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void showTextMessage()
	{
		textMessageText.SetActive (true);
	}
	
	public void ResetTextMessageTimer()
	{
		CancelInvoke ("showTextMessage");
		Invoke ("showTextMessage", delay);
		
	}
}
