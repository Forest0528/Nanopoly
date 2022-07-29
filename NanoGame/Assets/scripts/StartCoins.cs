using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCoins : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerTag"))
        {
            MoneyScore.Coin += 1300;
            Destroy(gameObject);
        }
    }
}
