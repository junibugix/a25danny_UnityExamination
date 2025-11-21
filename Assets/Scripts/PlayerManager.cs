using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    public UnityEvent onDeath;
    
    private int coins;
    private int health;

    private float damageCooldown;

    public TextMeshProUGUI coinCountUI;
    public TextMeshProUGUI healthUI;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coins = 0;
        health = 3;

        coinCountUI.text = "Coins: " + coins;
        healthUI.text = "Health: " + health;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (damageCooldown > 0)
        {
            damageCooldown -= Time.deltaTime;
        }
    }

    public void AddCoins(int amount)
    {
        coins += amount;

        coinCountUI.text = "Coins: " + coins;
        
        print("Coins: " + coins + " (+" + amount + ")");
    }

    public void TakeDamage(int amount)
    {
        if (damageCooldown <= 0)
        {
            print("took damage ");
            health -= amount;
            healthUI.text = "Health: " + health;
            if (health <= 0)
            {
                Die();
            }

            damageCooldown = 2f;
        }
    }

    private void Die()
    {
        print("you died :(");
        onDeath.Invoke();
    }
    
}
