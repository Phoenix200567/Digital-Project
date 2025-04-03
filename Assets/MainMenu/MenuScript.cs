using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
   public void PlayGame()
   {
    SceneManager.LoadScene("interface_Loggin");
   }
   public void GoToSettingsMenu()
   {
    SceneManager.LoadScene("SettingsMenu");
   }
   public void GoToMainMenu()
   {
    SceneManager.LoadScene("MainMenu");
   }
   public void QuitGame()
   {
    Application.Quit();
   }

}
