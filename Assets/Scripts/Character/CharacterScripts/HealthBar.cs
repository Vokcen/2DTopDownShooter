using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public Image effectBar;
    [HideInInspector] public float hp;
    [SerializeField] private float maxHp;
    [SerializeField] private float hurtSpeed = 0.005f;



    void Start()
    {
        hp = maxHp; 
    }

    void Update()
    {
        healthBar.fillAmount = hp / maxHp;
        if (effectBar.fillAmount>healthBar.fillAmount)
        {
            effectBar.fillAmount -= hurtSpeed;
        }
        else
        {
            effectBar.fillAmount = healthBar.fillAmount;
        }
    }
}
