using UnityEngine;
using System.Collections;

public class ShowHand : MonoBehaviour {
	public Transform startMarker;
	public Transform endMarker;
	public float speed = 1.0F;
	public float holdUpTime = 3f;
	public float delay = 42f;
	private float startTime;
	private float journeyLength;
	private bool showIt = false;
	private bool hideIt = false;
	
	
	void Start() {
		Invoke ("showHandNow", delay);
	}
	void Update() {
		
		if (showIt) {
			float distCovered = (Time.time - startTime) * speed;
			float fracJourney = distCovered / journeyLength;
			transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
			
			if(Vector3.Distance(transform.position, endMarker.position)<0.1f)
			{
				showIt=false;
				Invoke ("hideHandNow",holdUpTime);
			}
		}
		
		if (hideIt) {
			float distCovered = (Time.time - startTime) * speed;
			float fracJourney = distCovered / journeyLength;
			transform.position = Vector3.Lerp(endMarker.position,startMarker.position, fracJourney);
			
			if(Vector3.Distance(transform.position, startMarker.position)<0.1f)
			{
				hideIt=false;
			}
		}
		
	}
	
	
	public void ResetHandTimer()
	{
		CancelInvoke ("showHandNow");
		Invoke ("showHandNow", delay);
		
	}
	
	public void showHandNow()
	{
		startTime = Time.time;
		journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
		showIt = true;
	}
	
	public void hideHandNow()
	{
		startTime = Time.time;
		journeyLength = Vector3.Distance(endMarker.position, startMarker.position);
		hideIt = true;
	}
}