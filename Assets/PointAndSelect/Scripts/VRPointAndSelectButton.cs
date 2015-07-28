using UnityEngine;
using System.Collections;




namespace VRPointAndSelect
{
	public class VRPointAndSelectButton : MonoBehaviour {

		public VRPointAndSelectButtonTarget target;
		public string methodNameToCall;


		public void Select() {
			target.Invoke(methodNameToCall, 0);
		}

	}
}
