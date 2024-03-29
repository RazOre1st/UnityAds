﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    public Button btnAdd;
    public Button btnUse;
    public Text txCoin;

    int coin = 0;
    string placementId = "rewardedVideo";

#if UNITY_IOS
    private string gameId = "1678494";
#elif UNITY_ANDROID
    private string gameId = "1678493";
#endif

    // Start is called before the first frame update
    void Start()
    {
        if (btnAdd) btnAdd.onClick.AddListener(ShowAd);
        if (btnUse) btnUse.onClick.AddListener(UseCoin);

        if (Advertisement.isSupported)
        {
            Advertisement.Initialize(gameId, true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (btnAdd) btnAdd.interactable = Advertisement.IsReady(placementId);
        btnUse.interactable = (coin > 0);
    }

    void ShowAd()
    {
        ShowOptions options = new ShowOptions();
        options.resultCallback = HandleShowResult;
        Advertisement.Show(placementId, options);
    }

    void HandShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            Debug.Log("Video selesai - tawarkan coin ke pemain");
            coin += 50;
            txCoin.text = "Coin: " + coin;
        }
        else if (result == ShowResult.Skipped)
        {
            Debug.LogWarning("Video dilewati - tidak menawarkan coin ke permain");
        }
    }

    void UseCoin()
    {
        if (coin > 0)
        {
            coin -= 10;
            txCoin.text = "Coin: " + coin;
        }
    }
}
