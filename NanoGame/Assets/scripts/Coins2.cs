using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerTagg"))
        {
            MoneyScore1.Coin += 200;
            //Destroy(gameObject);
        }
    }
}
