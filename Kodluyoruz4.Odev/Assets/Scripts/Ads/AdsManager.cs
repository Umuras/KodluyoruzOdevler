using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    private string _gameId = "1234567";
    private bool _isTest = true;

    void Start()
    {
        Advertisement.Initialize(_gameId, _isTest);
    }

    
    public void ShowInterstitialAd()
    {
        
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
        else
        {
            Debug.Log("Not ready Ad. Please try again later!");
        }
    }
}
