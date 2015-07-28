using UnityEngine;
using System.Collections;

public class SplashOpen : MonoBehaviour {
	
	// Use this for initialization
	void Start() {
		Invoke ("callDoLoad", 0.2f);
	}
	
	
	void callDoLoad()
	{
		StartCoroutine ("doLoad");
	}
	
	
	IEnumerator doLoad()
	{
		AsyncOperation async = Application.LoadLevelAsync("RDGVRv1");
		yield return async;
		Debug.Log("Loading complete");
	}
	
}