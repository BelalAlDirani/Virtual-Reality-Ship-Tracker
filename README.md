# Maritime: Ship Tracker in VR

Maritime: Tracker in VR is a Virtual Reality app that has been developed to visualise a range of AIS data including ship positions, static and dynamic voyages and historical movements. The application will be used for tracking purposes and can be accessed by users on Android devices with a Virtual Reality (VR) headset. The user is able to select a scenario from a playlist to view. While viewing a scenario a user can view ships, their AIS Data and the ship's present and historical movements. The application connects the device to the web server and retrieves AIS data to display the ships in the chosen playlist and scene.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

You need to have a Google Cardboard (or any other similar headset), Android device (Recommend running version Lollipop or higher), Computer running Windows and your Android development environment set up before testing our Unity application on your Android device. Setting up your Android development environment involves downloading these files:

* [UNITY](https://unity3d.com/get-unity/download/archive)
* [JDK](http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html)
* [SDK](https://developer.android.com/studio/index.html)

### Installing

A step by step series of examples that tell you have to get a development environment running

1. Download Unity5.6.2f1 making sure to download "Android Build Support" through the Unity Download Assistant.
2. Download and install the Java JDK
3. Download and install the Android Software Development Kit (SDK) with the Android platforms, platform tools and build tools.
4. Either clone the Repository to a Folder on the Desktop and/or download the zip file adn unzip it to the Desktop
5. Open Unity and click the "Open" Tab, find where the repository is and click on the "Tracker Application VR" folder
6. Unity should now be building the Application for testing
7. To make sure the Android Environement is setup go into Unity Preferences found in (Edit > Preferences> External Tools) to make sure the JDK and SDK are installed
8. Within Unity, configure Mapbox Acces by going to (Mapbox > Configure Access) located at the top of Unity, and put in the code found in Assets/StreamingAssets/MapboxAccess.text
9. Application is now setup for Deployment and testing


## Running the tests

Running tests are difficult for VR development, in Unity itself, you can go ahead and test the application by:

* Clicking on the play button when VRMain and only VRMain is inside the Hierarchy tab, there you can see the Game view as well as the Console for testing and debugging (for the better results Deploy of Application to an Android device then tes using a headset)

## Deployment

1. Within Unity, open up build Settings and the top menu (File > Build Settings).
2. Click Android from the list of platforms on the left and choose Switch Platform at the bottom of the window (may take awhile to change) Making sure all 8 scenes, which are found in Assets/Scenes are selected and are in the "Scenes in Build", this is a very crucial step
3. Then connect your android device to the Computer making sure "debugging mode is ON" 
4. Back in Unity click on "Player Settings", and again making sure under the "Other Settings" tab has Cardboard inside Virtual Reality SDK's section.
5. Finally, click on "Build and Run", saving th Application as an .apk and installing it onto your device.

## Built With

* [UNITY](https://unity3d.com/get-unity/download/archive) - Main Software
* [Mapbox](https://www.mapbox.com/) - 3D Map
* [GoogleVR](https://developers.google.com/vr/unity/) - Virtual Reality SDK

## Versioning

We use Player Settings inside Unity for versioning. 

## Authors

* **Belal Dirani** - *Inital Work* - [ShipTrackerVR](https://github.com/BelalAlDirani)
* **Alisha Brown** - *Intial Work* - [ShipTrackerVR](https://github.com/leeshbrown)

## Acknowledgments

* Jason Thompson
* Google
* Pivot Maritime
