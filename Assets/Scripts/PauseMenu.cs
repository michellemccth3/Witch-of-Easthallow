using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void PauseGame ()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    
    public void ResumeGame ()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartGame ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame (){
        Application.Quit();
    }

}
