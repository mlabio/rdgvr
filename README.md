
###Running any app as vr_dual (without GearVR Headset):

Install any Gear VR app with your device signature (app can downloaded, compiled, or backed up from an official install)

Go to your device Settings -> Application manager -> Gear VR Service (usually in the "Downloaded" section but could also be in the "All" section).

Tap on "Manage storage"

Tap the "VR Service Version" number six times.

Wait for scan process to complete and you should now see the Developer Mode toggle on this screen.

You should now be able to launch your app without the headset and also dock the headset at any time without having Home launch.

*Move from: * Scene 1 Take 8 to Scene 2 Take 2

###Notes Unity MovieTexture

###In file:

MoviePlayerSample.cs

update line 160:

mediaPlayer.Call("setDataSource", "/storage/extSdCard/Oculus/360Videos/take_4.mp4");

Notes updating resolution of Oculus Mobile SDK Video Texture Hard-coded the movie texture to 960x540 inside of MediaSurface.cpp

cd /Users/buildmedia/Desktop/Bose/oculus/ovr_mobile_sdk_0.5.1/VRLib/jni/

Drag libOculusPlugin.so to assets within Unity

build.sh?

Install ADB

Copy to internal memory: adb push take_4.mp4 /mnt/sdcard/Oculus/360Videos

Copy to sdcard: adb push sam.mp4 /mnt/extSdCard/Oculus/360Videos

Debugging while in gear

Plug Note4 in via usb
Open a command prompt in windows
Type "adb tcpip 5555"
Disconnect Note4 from usb
Type "adb connect {your note4 wifi ip}
You should see a message saying you are connected
Type "adb logcat -s "UnityPlugin"
Start the app you want to check.
Log debug statements: adb logcat -s Unity

This will start logging all messages you need, especially the FPS readings for the running app.

Read this: http://elevr.com/blog/

Read this: http://elevr.com/vr-video-bubbles-for-dk2/

project inside globe: http://bernieroehl.com/360stereoinunity/

performance of 360 video http://forum.unity3d.com/threads/stereoscopic-3d-360-movie-bad-performance.293845/

** https://forums.oculus.com/viewtopic.php?t=17264&p=221543

Best viewer: http://makingview.no/?portfolio=wingsuit-flight-from-flo

###Info on recompiling texture: 
http://www.reddit.com/r/GearVR/comments/2u0ro2/gearvr_w_unity_loading_movie_onto_texture

###Flicker solve? 
http://answers.unity3d.com/questions/153314/x-and-y-local-rotation-behaving-differently-for-qu.html

###Note about resolutions: 
https://forums.oculus.com/viewtopic.php?f=67&t=19206&p=243535&hilit=360+video#p243535

http://vrcover.com/faq/

http://www.360heros.com/2014/01/worlds-first-fully-spherical-3d-360-video-and-photo-gear/

http://www.mobilefun.com/48645-samsung-gear-vr-virtual-reality-headset-for-galaxy-note-4.htm?utm_source=froogle&utm_medium=comparison&utm_campaign=froogle&referer=PLA&gclid=CILInZOElMMCFZQ2gQodmyoAPg

http://www.iximage.com/street-view-sequence/?lang=en

http://freedom360.us/

Hard coded texture value in MediaSurface.cpp. Working on compiling new values into that code and compiling into (Java Native Interface) JNI using Android Native Development Kit (NDK).

###Extract NDK on Mac: 
chmod a+x android-ndk-r10d-darwin-x86_64.bin ./android-ndk-r10d-darwin-x86_64.bin

JNI location for build using ndk-build: MacOS ▸ Users ▸ buildmedia ▸ Desktop ▸ Bose ▸ oculus ▸ sdk ▸ ovr_mobile_sdk_0.4.3 ▸ VRLib ▸ jni ▸ Integrations ▸ Unity

Re-compile the C++ plugin - it takes the Android NDK to actually build it but swapping out the hardcoded values in MediaSurface.cpp with your desired values, building it, and then copying over the libOculusPlugin.so into your Assets\Plugins folder and overwrite the one already there.

Note: cd into project directory /ovr_mobile_sdk_0.4.3/VRLib

then drag ndk-build into terminal window and hit Return
libOculusPlugin.so needs to be dragged to Assets\Plugins

###Unity Gaze selection 
http://ralphbarbagallo.com/2014/08/20/oculus-rift-world-space-cursors-for-world-space-canvases-in-unity-4-6/

http://forum.unity3d.com/threads/frequently-asked-ui-questions.264479/

3dio Notes: Use LeftEyeAnchor or RightEyeAnchor for Camera input. Doesn’t matter what the script is attached to.

###Android Dev Framework: 
http://www.gearvrf.org/bin/view/GearVRfDeveloperGuide/GearVRfDevGuide200Start
