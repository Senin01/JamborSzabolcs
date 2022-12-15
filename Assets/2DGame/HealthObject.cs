using System;
using UnityEngine;
using TMPro;

class HealthObject : MonoBehaviour
{
    [SerializeField] TMP_Text textComponent;
    [SerializeField] float maxHealth = 100;

    [SerializeField] Color maxHealtColor;
    [SerializeField] Color zeroHealthColor;
    [SerializeField] GameObject objektToTurnOnWhenDie;

    float currentHealth;
    const string healthKey = "health";

    void OnDestroy()
    {
        PlayerPrefs.SetFloat(healthKey, currentHealth);
    }


    void Awake()
    {

    }


    void Start()
    {
        if (PlayerPrefs.HasKey(healthKey))
        {
            currentHealth = PlayerPrefs.GetFloat(healthKey);
        }
        if (currentHealth == 0)
        {
            currentHealth = maxHealth;
        }
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
        TestDeath();
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
        TestDeath();
    }

    void TestDeath()
    {
        if (IsDead())
        {
            objektToTurnOnWhenDie?.SetActive(true);
        }
    }
}