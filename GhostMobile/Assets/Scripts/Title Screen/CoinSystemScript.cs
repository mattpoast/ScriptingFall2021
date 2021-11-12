using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSystemScript : MonoBehaviour
{
    public float PlayerCoins;
    public float CoinCost;
    public GameObject GratsScreen;
    public GameObject InsFunds;

    void Start()
    {

    }

    public void Purchase()
    {
        if (PlayerCoins >= CoinCost)
        {
            PlayerCoins -= CoinCost;
            GratsScreen.SetActive(true);
        }
        else
        {
            InsFunds.SetActive(true); 
        }
    }
    
}
