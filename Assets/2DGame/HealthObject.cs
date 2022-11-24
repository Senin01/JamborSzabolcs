using System;
using UnityEngine;
using TMPro;

class HealthObject : MonoBehaviour
{
    [SerializeField] TMP_Text textComponent;
    [SerializeField] float maxHealth = 100;

    [SerializeField] Color maxHealtColor;
    [SerializeField] Color zeroHealthColor;

    float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateText();
    }

    void UpdateText()
    {
        textComponent.text = "Health: " + currentHealth;
        float healthrate = currentHealth / maxHealth;
        textComponent.color = Color.Lerp(zeroHealthColor, maxHealtColor, healthrate);
    }

    public void Kill()
    {
        currentHealth = 0;
        UpdateText();
    }

    public bool IsDead()
    {
        return currentHealth <= 0;
    }

    public void Damage(float damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateText();
    }
}