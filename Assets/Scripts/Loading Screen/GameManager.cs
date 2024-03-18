using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;

        SceneManager.LoadSceneAsync((int)SceneIndexes.MainMenu, LoadSceneMode.Additive);
    }

    public void LoadGame()
    {
        SceneManager.UnloadSceneAsync((int)SceneIndexes.MainMenu);
        SceneManager.LoadSceneAsync((int)SceneIndexes.Level1, LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync((int)SceneIndexes.NavMesh, LoadSceneMode.Additive);
    }
}
