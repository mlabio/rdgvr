using UnityEngine;
using System.Collections;

public class ResetTimers : MonoBehaviour {
	
	public TextMessage textMessageTrigger;
	public EnableParticleFX enableParticleFX;
	public ShowHand showHand;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void resetTimers()
	{
		textMessageTrigger.ResetTextMessageTimer();
		enableParticleFX.ResetVortexTimer ();
		showHand.ResetHandTimer ();
	}
}