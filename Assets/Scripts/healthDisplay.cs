using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthDisplay : MonoBehaviour
{
    [SerializeField] float baseHealth = 5;
    [SerializeField] int damage = 1;
    float health;
    Text healthText;

    private void Start()
    {
        health = baseHealth - PlayerPrefsController.GetDifficulty();
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
            FindObjectOfType<LevelController>().LoseCoindition();

        }
    }

    public float GetBaseHealth()
    {
        return health;
    }
}
