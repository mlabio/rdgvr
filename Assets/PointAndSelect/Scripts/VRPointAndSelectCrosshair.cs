using UnityEngine;
using System.Collections;

namespace VRPointAndSelect
{
	public class VRPointAndSelectCrosshair : MonoBehaviour {
		
		public Texture crosshairNormal;
		public Texture crosshairHover;
		public Texture crosshairFill;
		public GameObject sphere;
		
		[HideInInspector] public bool isHovering;
		[HideInInspector] public float fillAmount;
		
		private Camera cam;
		
		
		
		
		void Awake(){
			if (this.GetComponent<Camera>() != null) {
				cam = this.GetComponent<Camera>();
			} else Debug.LogError("Cannot find Camera component", this.gameObject);
		}
		
		
		
		
		
		void Update()
		{
			if (fillAmount > 0) {
				Debug.Log("woot1");

				if (crosshairFill != null) {
					Debug.Log("woot2");

					fillAmount = Mathf.Clamp01(fillAmount);
					
					//calculate rect per fill amount
					float width = (float)crosshairFill.width * fillAmount;
					float height = (float)crosshairFill.height * fillAmount;
					
					//Rect fillRect = new Rect(cam.pixelRect.center.x - (width * 0.5f), (cam.pixelRect.center.y) - (height * 0.5f), width, height);
					//GUI.DrawTexture(fillRect, crosshairFill);
					
					//sphere.transform.localScale =  Vector3.one * fillAmount;

					Debug.Log(fillAmount);
					
				} else Debug.LogError("Crosshair fill texture missing", this.gameObject);
			}
			
			
			if (crosshairNormal != null) {
				
				//normal
				//GUI.DrawTexture(GetRectInScreenCenter(crosshairNormal), crosshairNormal);
				
			} else Debug.LogError("Crosshair normal texture missing", this.gameObject);
			
			
			if (isHovering){
				if (crosshairHover != null) {
					//GUI.DrawTexture(GetRectInScreenCenter(crosshairHover), crosshairHover);
				} else Debug.LogError("Crosshair hover texture missing", this.gameObject);
			}
			
			sphere.transform.localScale =  Vector3.one * fillAmount * 0.3f;

			
			
		}
		
		
		
		
		
		Rect GetRectInScreenCenter(Texture texture) {
			return new Rect((cam.pixelRect.center.x - ((float)texture.width * 0.5f)), (cam.pixelRect.center.y) - ((float)texture.height * 0.5f), texture.width, texture.height);
		}
		
		
	}
}


