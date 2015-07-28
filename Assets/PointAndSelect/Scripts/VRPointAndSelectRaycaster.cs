using UnityEngine;
using System.Collections;

namespace VRPointAndSelect
{
	public class VRPointAndSelectRaycaster : MonoBehaviour {
		
		public float detectionDistance = 1000f;
		public float chargeTime = 2f;
		public OVRCameraRig					cameraController = null;
		
		private float currentCharge = 0;
		private VRPointAndSelectButton currentButton;
		private VRPointAndSelectCrosshair[] crosshairs;
		
		
		
		
		void Awake() {
			
			crosshairs = FindObjectsOfType<VRPointAndSelectCrosshair>();
			
		}
		
		
		void Update () {
			
			// get the camera forward vector and position
			Vector3 cameraPosition = cameraController.centerEyeAnchor.position;
			Vector3 cameraForward = cameraController.centerEyeAnchor.forward;
			
			
			
			//Vector3 forward = this.transform.TransformDirection(Vector3.forward);
			Vector3 forward = cameraForward;
			
			//ray cast forward
			RaycastHit hit;
			
			Debug.DrawRay(cameraPosition, forward, Color.green);
			
			if (Physics.Raycast(cameraPosition, forward, out hit, detectionDistance)) {
				
				if (hit.collider.gameObject.GetComponent<VRPointAndSelectButton>() != null) {
					
					//charging same button
					if (currentButton != null) {
						if (currentButton == hit.collider.gameObject.GetComponent<VRPointAndSelectButton>()) {
							Debug.Log("vroiubtandselectraycaster hit!");
							
							//same button charging
							currentCharge += Time.deltaTime;
							
							if (currentCharge >= chargeTime) {
								//button call method
								VRPointAndSelectButton button = hit.collider.gameObject.GetComponent<VRPointAndSelectButton>();
								button.Select();
							}
							
						} else {
							currentCharge = 0;
						}
					}
					else {
						//pointing at button detected
						currentCharge = 0;
					}
					
					currentButton = hit.collider.gameObject.GetComponent<VRPointAndSelectButton>();
					
				} else {
					//not pointing at the button
					currentButton = null;
					currentCharge = 0;
				}
			} else {
				//not pointing at the button
				currentButton = null;
				currentCharge = 0;
			}
			
			
			//refresh crossHairs
			foreach (VRPointAndSelectCrosshair crosshair in crosshairs) {
				crosshair.isHovering = currentButton != null;
				crosshair.fillAmount = currentCharge.Remap(0, chargeTime, 0, 1f);
			}
			
		}
		
		
	}
}










