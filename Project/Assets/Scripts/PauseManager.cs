using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class PauseManager : MonoBehaviour {
	
	Canvas canvas;
	//GameObject camera;
	//AudioListener music;
	
	void Start()
	{
		canvas = GetComponent<Canvas>();
		canvas.enabled = false;
		//GetComponent<Camera>() = GameObject.FindGameObjectWithTag ("MainCamera");
		//music = GetComponent<Camera>().GetComponent<AudioListener> ();
	}
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Pause();
		}
	}
	
	public void Pause()
	{
		canvas.enabled = !canvas.enabled;
		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
		//music.enabled = false;
	}
	
	public void Quit()
	{
		#if UNITY_EDITOR 
		EditorApplication.isPlaying = false;
		#else 
		Application.Quit();
		#endif
	}
}