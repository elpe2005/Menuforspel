using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (GameIsPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }
    public void Resume (){ //KAN LÄGGA TILL ANIMATION TILL PAUS MENYN SÅ SVARTA TRANSPARENT KOMMER SAKTA IN.
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause (){  
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menyn");
    }
    
    public void QuitGame(){
        Debug.Log("Quitting game...");
        Application.Quit();
    }
    public void BackButton(){
        SceneManager.LoadScene(0);
    }
}
