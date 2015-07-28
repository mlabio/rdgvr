using UnityEngine;
using System.Collections;



public class SwitchAudio : MonoBehaviour {
	
	public OmniController omniController;
	public MovieTexture_v1 movieTexture_v1;

	public AudioClip clipIn0;
	public AudioClip clipIn90;
	public AudioClip clipIn180;
	public AudioClip clipIn270;
	
	public AudioClip clipIn0a;
	public AudioClip clipIn90a;
	public AudioClip clipIn180a;
	public AudioClip clipIn270a;
	
	private int _roomNumber = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	public void toggleNow(int roomNumber)
	{
		
		
		if(roomNumber != _roomNumber)
		{
			switch (roomNumber)
			{
			case 0:
                movieTexture_v1.PlayVideo1();
				omniController.clipIn0 = clipIn0;
				omniController.clipIn90 = clipIn90;
				omniController.clipIn180 = clipIn180;
				omniController.clipIn270 = clipIn270;
				break;
			case 1:
                movieTexture_v1.PlayVideo2();
				omniController.clipIn0 = clipIn0a;
				omniController.clipIn90 = clipIn90a;
				omniController.clipIn180 = clipIn180a;
				omniController.clipIn270 = clipIn270a;
				break;
			}
			
			_roomNumber = roomNumber;
			omniController.playSources ();
		}
		
		
	}
}	
