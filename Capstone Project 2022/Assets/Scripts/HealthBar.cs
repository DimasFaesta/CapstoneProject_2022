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
        hp = GameObject.FindWithTag("FisikPlayer").GetComponent<HealthPlayer>();   
        health = hp.healthPlat;
    }

    // Update is called once per frame
    void Update()
    {
        HealthbarPlayer.fillAmount = hp.healthPlat / maxHealth;
    }
}
