using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour
{
    [SerializeField] private GameObject _reloadPanel;
    public InterstitialAds _Ads;
    public void ReloadLVL()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void WrongCube()
    {
        _Ads.ShowAd();
        _reloadPanel.SetActive(true);
    }
}
