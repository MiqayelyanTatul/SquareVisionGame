using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVLLoader : MonoBehaviour
{
    public InterstitialAds _Ads;
    public void OnClickLVL1()
    {
        _Ads.ShowAd();
        SceneManager.LoadScene("LVL1");
    }

    public void OnClickLVL2()
    {
        _Ads.ShowAd();
        SceneManager.LoadScene("LVL2");
    }
}
