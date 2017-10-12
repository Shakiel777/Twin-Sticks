using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManger : MonoBehaviour {

    public bool recording = true;
    private bool isPaused = false;
    private float fixedDeltaTime;

	// Use this for initialization
	void Start ()
    {
        PlayerPrefsManager.UnlockLevel(1);
        print(PlayerPrefsManager.IsLevelUnlocked(1));
        print(PlayerPrefsManager.IsLevelUnlocked(2));
        fixedDeltaTime = Time.fixedDeltaTime;
        print(fixedDeltaTime);

    }
	
	// Update is called once per frame
	void Update ()
    {
        StartPlayBack();

        if (Input.GetKeyDown(KeyCode.P) && isPaused)
        {
            isPaused = false;
            ResumeGame();
        }else if (Input.GetKeyDown(KeyCode.P) && !isPaused)
        {
            isPaused = true;
            PauseGame();
        }
	}

    void StartPlayBack()
    {
        if (CrossPlatformInputManager.GetButton("Fire1"))
        {
            recording = false;
        }else
        {
            recording = true;
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        Time.fixedDeltaTime = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = fixedDeltaTime;
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        isPaused = pauseStatus;  // would need to check the status in update.
    }
}
