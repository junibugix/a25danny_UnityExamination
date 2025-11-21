using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private int coins;
    private int health;

    public TextMeshProUGUI coinCountUI;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coins = 0;
        health = 0;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoins(int amount)
    {
        coins += amount;

        coinCountUI.text = "Coins: " + coins;
        
        print("Coins: " + coins + " (+" + amount + ")");
    }

    public void TakeDamage(int amount)
    {
        print("took damage");
        health -= amount;
        if (health <= 0)
        {
            Die();
            enabled = false;
        }
    }

    private void Die()
    {
        print("you died :(");
    }
    
}
