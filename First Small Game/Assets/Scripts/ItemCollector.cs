using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int counterCoins = 0;
    [SerializeField] Text coinsText;

    [SerializeField] AudioSource soundCollecting;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            counterCoins++;
            coinsText.text = "Coins: " + counterCoins;
            soundCollecting.Play();
        }
    }
}
