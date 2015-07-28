using UnityEngine;
using System.Collections;

public class MoveTextUp : MonoBehaviour {
	
	public float speed;
	public float phoneToHoldTime = 2f;
	public float holdToCeilTime = 2f;
	public float holdTime = 5f;
	public float fadeInSpeed = 0.5f;
	public float fadeOutSpeed = 0.5f;
	public Color textFinalColor = Color.white;
	
	
	private float timer = 0f;
	private TextMesh textMesh;
	
	private bool fadingIn = true;
	private bool fadingOut = false;
	
	private Vector3 startPosition;
	
	// Use this for initialization
	void Start () {
		textMesh = GetComponent<TextMesh> ();
		
		textMesh.color = new Color(textFinalColor.r, textFinalColor.b, textFinalColor.b, 0f);
		
		startPosition = transform.position;
	}
	
	
	public void ResetTextMessageTimer()
	{
		timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		
		timer += Time.deltaTime;
		
		
		if (timer <= phoneToHoldTime) {
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		
		if (fadingIn) {
			Color tempColor = textMesh.color;
			
			float alpha = tempColor.a;
			
			alpha += fadeInSpeed * Time.deltaTime;
			
			if (alpha >=1)
			{
				fadingIn=false;
			}
			
			Color newColor = new Color(tempColor.r, tempColor.g, tempColor.b, alpha);
			
			textMesh.color = newColor;
		}
		
		if (timer > holdTime) {
			fadingOut=true;
			transform.position += Vector3.up * speed * Time.deltaTime;
			
			Color tempColor = textMesh.color;
			
			float alpha = tempColor.a;
			
			alpha -= fadeOutSpeed * Time.deltaTime;
			
			Color newColor = new Color(tempColor.r, tempColor.g, tempColor.b, alpha);
			
			textMesh.color = newColor;
		}
		
		if (fadingOut) {
			Color tempColor = textMesh.color;
			
			float alpha = tempColor.a;
			
			alpha += fadeInSpeed * Time.deltaTime;
			
			if (alpha <=0)
			{
				fadingOut=false;
			}
			
			Color newColor = new Color(tempColor.r, tempColor.g, tempColor.b, alpha);
			
			textMesh.color = newColor;
		}
		
		
		if (timer > holdTime + holdToCeilTime) {
			timer = 0f;
			gameObject.SetActive (false);
			transform.position = startPosition;
			
		}
		
	}
	
	
}
