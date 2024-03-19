using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    [SerializeField]
    ScoreSystem scoreSystem;

    // Start is called before the first frame update
    private void Awake()
    {
        //scoreSystem.openVictory += openVictory;
    }

    private void openVictory()
    {
        Debug.Log("OpensVictory");
        gameObject.SetActive(true);
    }
}
