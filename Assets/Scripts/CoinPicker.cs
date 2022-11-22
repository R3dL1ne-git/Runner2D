using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    private float coins = 0;
    public TMP_Text cointText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            coins++;
            cointText.text = coins.ToString();
            Destroy(collision.gameObject);
        }
    }
}
