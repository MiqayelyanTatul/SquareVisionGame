using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLvl : MonoBehaviour
{   
    public void GoToNextLVL()
    {
        SceneManager.LoadScene(sceneBuildIndex:+1);
    }
}
