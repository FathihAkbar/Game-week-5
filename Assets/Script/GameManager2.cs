using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Misiscript : MonoBehaviour
{
   public GameObject PanelMisi;

   public void misiControl()
   {
    if (Time.timeScale == 1){
        PanelMisi.SetActive (true);
        Time.timeScale = 0;
    } else {
        Time.timeScale = 1;
        PanelMisi.SetActive (false);
    }
   }
}
