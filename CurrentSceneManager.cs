using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public bool isGamePaused = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) {
            ReloadScene();
        }

        if(Input.GetKeyDown(KeyCode.Escape)) {
            TogglePause();
        }
    }

    public void TogglePause() {
        isGamePaused = !isGamePaused;
        if(isGamePaused) {
            Resume();
        } else {
            Pause();
        }
    }

    public void Pause() {
        isGamePaused = true;
        Time.timeScale = 0;
    }

    public void Resume() {
        isGamePaused = false;
        Time.timeScale = 1;
    }

    public void Quit() {
        Application.Quit();//ne fonctionne que dans un build final du jeu
        Debug.Log("Quit game");
    }

    void ReloadScene() {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
