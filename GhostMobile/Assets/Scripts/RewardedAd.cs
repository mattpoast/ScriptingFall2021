using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
[RequireComponent (typeof (Button))]
public class RewardedAd : MonoBehaviour, IUnityAdsListener {
#if UNITY_IOS
    private string gameId = "4495716";
#elif UNITY_ANDROID
    private string gameId = "4495717";
#endif
    Button myButton;
    public int coins;
    public string myPlacementId = "RewardedVideo";
    void Start () {   
        myButton = GetComponent <Button> ();
        myButton.interactable = Advertisement.IsReady (myPlacementId);
        if (myButton) myButton.onClick.AddListener (ShowRewardedVideo);
        Advertisement.AddListener (this);
        Advertisement.Initialize (gameId, false);
    }
    void ShowRewardedVideo () {
        Advertisement.Show (myPlacementId);
    }
    public void OnUnityAdsReady (string placementId) {
        if (placementId == myPlacementId) {        
            myButton.interactable = true;
        }
    }
    public void OnUnityAdsDidFinish (string placementId, ShowResult showResult) {
        if (showResult == ShowResult.Finished)
        {
            coins = PlayerPrefs.GetInt("Coins");
            coins += 5;
            PlayerPrefs.SetInt("Coins", coins);
            SceneManager.LoadScene(2);
        } else if (showResult == ShowResult.Skipped) {
        } else if (showResult == ShowResult.Failed) {
            Debug.LogWarning ("The ad did not finish due to an error.");
        }
    }
    public void OnUnityAdsDidError (string message) {
    }
    public void OnUnityAdsDidStart (string placementId) {
    } 
}