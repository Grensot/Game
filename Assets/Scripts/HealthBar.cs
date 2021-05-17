using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public KeyCode TakeDamage;

    void Start()
    {
        currentHealth = maxHealth;
        SetMaxHealth(maxHealth);
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(TakeDamage))
        {
            currentHealth -= 20;
            SetHealh(currentHealth);
        }
    }
    public void SetMaxHealth(int health)
    {
      slider.maxValue = health;
      slider.value = health;
      fill.color = gradient.Evaluate(1f);
    }
    public void SetHealh(int health)
    {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

}
