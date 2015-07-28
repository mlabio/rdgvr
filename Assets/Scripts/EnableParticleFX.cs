using UnityEngine;
using System.Collections;

public class EnableParticleFX : MonoBehaviour {
	
	public float delay = 40f;
	public GameObject particleFX;
	
	// Use this for initialization
	void Start () {
		Invoke ("showParticles", delay);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void showParticles()
	{
		particleFX.SetActive (true);
	}
	
	public void disableParticles()
	{
		particleFX.SetActive (false);
	}
	public void ResetVortexTimer()
	{
		CancelInvoke ("showParticles");
		Invoke ("showParticles", delay);
	}
}
