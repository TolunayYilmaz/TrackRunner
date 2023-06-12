using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CheckCollision : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI CoinText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Debug.Log("Coin");
            other.transform.parent.gameObject.SetActive(false);
            AddCoin();

        }
    }
    public void AddCoin()
    {
        score++;
        CoinText.text = "Score: "+score;
    }
}
