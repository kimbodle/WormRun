using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_move : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Tuto");
    }

    public void Scenestart()
    {
        SceneManager.LoadScene("StartScene");
    }
}
