using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthDisplay : MonoBehaviour
{

    [SerializeField] int health = 100;
    [SerializeField] int damage = 1;
    Text healthText;

    private void Start()
    {
        healthText = GetComponent<Text>();
        UpdateDisplay();
    }
    private void UpdateDisplay()
    {
        healthText.text = health.ToString();
    }

    public void HealthDown()
    {
        health -= damage;
        UpdateDisplay();
        if(health <= 0)
        {
            // FindObjectOfType<LoadLevel>().LoadGameOver();
            FindObjectOfType<LevelController>().LoseCoindition();

        }
    }
}
