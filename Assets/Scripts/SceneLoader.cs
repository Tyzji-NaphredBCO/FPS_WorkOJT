using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
   public void LoadLevel1 () {
        SceneManager.LoadScene(2);
   }
   public void LoadMenu() {
        SceneManager.LoadScene(1);
   }
}
