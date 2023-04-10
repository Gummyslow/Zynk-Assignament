using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthInfo : MonoBehaviour
{
    public static HealthInfo Instance { get; private set; }

    public Text MaxHealth;
    public Text CurrentHealth;

    void OnEnable()
    {
        Instance = this;
    }

    public void UpdateMaxHealth(int health)
    {
        string hp = health.ToString();
        MaxHealth.text = hp;
    }

    public void UpdateCurrentHealth(int current_health)
    {
        string current_hp = current_health.ToString();
        CurrentHealth.text = current_hp;
    }

}
