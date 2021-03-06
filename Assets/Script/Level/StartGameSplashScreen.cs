﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameSplashScreen: MonoBehaviour {

	// Scene name that we want to transition into.

	public string sceneName;

	private bool loadLock;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && !loadLock) {
			LoadScene ();
		}
	}

	void LoadScene(){
		loadLock = true;
		SceneManager.LoadScene (sceneName);
	}
}
