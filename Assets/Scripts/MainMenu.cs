using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void StartGame()
  {
    SceneManager.LoadScene("Game");
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
