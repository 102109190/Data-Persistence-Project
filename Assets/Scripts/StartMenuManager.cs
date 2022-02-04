using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuManager : MonoBehaviour
{
    public static string playerName;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public static void setPlayerName(GameObject _playerName)
    {
        playerName = _playerName.GetComponent<Text>().text;
        nextScene();
    }

    private static void nextScene()
    {
        SceneManager.LoadScene("main");
    }
}
