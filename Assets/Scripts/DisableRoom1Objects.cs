using UnityEngine;
using System.Collections;

public class DisableRoom1Objects : MonoBehaviour {
	
	public GameObject[] objectsToDisable;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void DisableObjectsNow()
	{
		
		foreach (GameObject go in objectsToDisable) {
			
			go.SetActive (false);
			
		}
		
	}
}