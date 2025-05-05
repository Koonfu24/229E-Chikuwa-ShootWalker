using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void StartGame()
  {
    SceneManager.LoadScene("Game");
    Time.timeScale = 1;
  }
  public void loadCredits()
  {
    SceneManager.LoadScene("Credits");
  }
  
  public void mainMenu()
  {
    SceneManager.LoadScene("MainMenu");
  }
  
}
