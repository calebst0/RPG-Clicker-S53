using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void changemenuscene(string scenename)
    {
        Application.LoadLevel(scenename);
    }

    public void SceneLoader(int sceneid)
    {
        SceneManager.LoadScene(sceneid);
    }
}