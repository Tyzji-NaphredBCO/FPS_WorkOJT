using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TAB_Funct : MonoBehaviour
{
    public GameObject settings;
    public bool isettingactive;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isettingactive == false)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }
    public void Pause()
    {
        settings.SetActive(true);
        isettingactive = true;
        this.GetComponent<MouseS>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Resume()
    {
        settings.SetActive(false);
        isettingactive = false;
        this.GetComponent<MouseS>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
