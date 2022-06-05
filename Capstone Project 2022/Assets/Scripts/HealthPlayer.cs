using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
    public float health = 100;
    public float timer;
    public Text timerText;
    public float randomHealth;
    
    private void Start() {
        
        randomHealth = Random.Range(15,60);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        float minutes = Mathf.FloorToInt((timer / 60));
        float seconds = timer % 60;

        string secodsString = seconds.ToString("F2");

        // timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = minutes + ":" + secodsString;

        if (timer <= 0)
        {
            timer = 0;
            timerText.text = "00:00";
            
        }

    }


    private void OnTriggerStay(Collider other) {
        if (other.tag == "Meja")
            {
                if(timer <= 0){
                    health = 90;
                }
            }

            else
            {  if(timer <= 0){
                health = randomHealth;
                }
            }
    }
}
