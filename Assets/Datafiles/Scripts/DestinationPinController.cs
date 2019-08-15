using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;
using UnityEngine.SceneManagement;

[RequireComponent (typeof(VRInteractiveItem))]
public class DestinationPinController : MonoBehaviour 
{
	//Name of the destination Scene
	public string sceneName;

	//VR Interactive object component
	VRInteractiveItem vrInteractive;

	void Awake()
	{
		vrInteractive = GetComponent<VRInteractiveItem> ();
	}

	void ChangeScene()
	{
		SceneManager.LoadScene (sceneName);
	}

	//Called when gameObject becomes enabled
	void OnEnable()
	{
		vrInteractive.OnClick += ChangeScene;
	}

	//Called when gameObjects becomes disabled
	void OnDisable()
	{
		vrInteractive.OnClick -= ChangeScene;
	}
}
