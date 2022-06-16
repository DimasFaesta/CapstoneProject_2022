using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthPlayer : MonoBehaviour
{
    public float healthPlat = 100;
    public float timerhold;
    public float randomHealth;
    public TimerShow time;
    public GameObject Ketiban;

    bool aman;
    
    private void Awake() {
    }
    
    void Start() {
        DontDestroyOnLoad(this.gameObject);
        time = GameObject.FindWithTag("Timer").GetComponent<TimerShow>();
        randomHealth = Random.Range(65,95);
        // timerhold = scr.value;
        
    }
    private void FixedUpdate() {
        
        // scr.value = time.timer;
        timerhold = time.timer;

        if (aman == false && timerhold <= 0)
        {
            healthPlat = randomHealth;
            randomHealth = healthPlat;
            Debug.Log("2");
        }

    }


    private void OnTriggerEnter(Collider other) {
        if (other.tag == "PintuLemari")
        {
            Ketiban.SetActive(true);
            Time.timeScale = 0;
        }

        if (other.tag == "Meja")
        {
            Debug.Log("1");
            aman = true;
            if (timerhold <= 0)
            {
                healthPlat = 95;
            }
            Debug.Log(aman);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Meja")
        {
            if (timerhold >= 0)
            {
                aman = false;
            }
        }
    }

}
