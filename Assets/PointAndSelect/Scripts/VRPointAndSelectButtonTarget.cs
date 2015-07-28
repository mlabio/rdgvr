using UnityEngine;
using System.Collections;

public class VRPointAndSelectButtonTarget : MonoBehaviour {
	public SwitchAudio switchAudio;
	public EnableParticleFX enableParticleFX;
	//public MovieTexture_v1 movieTexture_v1;
	
	public void switchRoom(){
		switchAudio.toggleNow (1);
		
		enableParticleFX.disableParticles();
		
	}
	
}
