using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausedscript : MonoBehaviour
{
   public GameObject PanelPaused;
   public GameObject PanelMisi;

   public void pauseControl()
   {
    if (Time.timeScale == 1){
        PanelPaused.SetActive (true);
        Time.timeScale = 0;
    } else {
        Time.timeScale = 1;
        PanelPaused.SetActive (false);
    }
   }

   public void Restart()
   {
    SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
    Time.timeScale = 1;
   }

   public void MenuUtama()
   {
    Application.LoadLevel(0);
   }

   public void misiControl()
   {
    if (Time.timeScale == 1){
        PanelMisi.SetActive (true);
    } else {
        Time.timeScale = 1;
        PanelMisi.SetActive (false);
    }
   }
}
