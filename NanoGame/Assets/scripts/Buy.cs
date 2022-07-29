using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    //player1MoveText = GameObject.Find("Player2Buy");

    public void MoneyButton()
    {
        MoneyScore.Coin -= 50;
        //player1MoveText.gameObject.SetActive(false);
    }
}
