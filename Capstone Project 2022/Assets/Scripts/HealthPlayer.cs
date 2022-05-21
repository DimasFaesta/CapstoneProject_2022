using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{

    Image Healthbar;
    float maxHealth = 100f;
    public static float health;
    // Start is called before the first frame update
    void Start()
    {
        Healthbar = GetComponent<Image>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Healthbar.fillAmount = health / maxHealth;
        attack();

    }

    public void attack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            health -= 10f;
        }
    }
}
