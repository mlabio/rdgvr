using UnityEngine;
using System.Collections;
using VRPointAndSelect;

public class HideExample : VRPointAndSelectButtonTarget {

	public GameObject[] dynamicObjects;




	public void Show() {
		foreach (GameObject dynamicObject in dynamicObjects) {

			if (dynamicObject.GetComponent<MeshRenderer>() != null) dynamicObject.GetComponent<MeshRenderer>().enabled = true;

			foreach (Transform child in dynamicObject.gameObject.transform) {
				if (child.GetComponent<MeshRenderer>() != null) child.GetComponent<MeshRenderer>().enabled = true;
			}

		}
	}



	public void Hide() {
		foreach (GameObject dynamicObject in dynamicObjects) {
			
			if (dynamicObject.GetComponent<MeshRenderer>() != null) dynamicObject.GetComponent<MeshRenderer>().enabled = false;
			
			foreach (Transform child in dynamicObject.gameObject.transform) {
				if (child.GetComponent<MeshRenderer>() != null) child.GetComponent<MeshRenderer>().enabled = false;
			}
			
		}
	}


}
