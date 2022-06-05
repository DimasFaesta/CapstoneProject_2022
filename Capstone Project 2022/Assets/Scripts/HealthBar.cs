using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Image HealthbarPlayer;
    public float maxHealth = 100f;
    public float health;
    public HealthPlayer hp;
    // Start is called before the first frame update
    void Start()
    {
        HealthbarPlayer = GetComponent<Image>();
        // health = maxHealth;
        health = hp.health;
    }

    // Update is called once per frame
    void Update()
    {
        HealthbarPlayer.fillAmount = hp.health / maxHealth;

    }
}
