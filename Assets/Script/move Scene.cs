using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToRumah()
    {
        SceneManager.LoadScene("Rumah");
    }

   public void ToScene3()
   {
        SceneManager.LoadScene("Scene 3");
   }
}
