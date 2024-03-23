using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void LoadScene (string GamePlay)
    {
        SceneManager.LoadScene (GamePlay);
    }

    public void ExitGame()
    {
        Application.Quit ();
    }
}
