using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
     public void LoadMenu() {
          SceneManager.LoadScene(0);
     }
     public void LoadLevel1 () {
         SceneManager.LoadScene(1);
     }
     public void LoadLevel2() {
         SceneManager.LoadScene(2);
     }
     public void LoadLevel3() {
         SceneManager.LoadScene(3);
     }
}
