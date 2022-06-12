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
    public string nameScene;

    private void Awake() {
        time = GameObject.Find("Timer").GetComponent<TimerShow>();
    }
    
    private void Start() {
        
        randomHealth = Random.Range(35,75);
        DontDestroyOnLoad(this.gameObject);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timerhold = time.timer;
        if(timerhold == 0){
            SceneManager.LoadScene(nameScene);
        }
    }


    private void OnTriggerStay(Collider other) {
        if (other.tag == "Meja")
            {
                if(timerhold <= 0){
                    healthPlat = 95;
                }
            }

            else
            {  if(timerhold <= 0){
                healthPlat = randomHealth;
                }
            }
    }

    // void TimerColdown(){
    //     timer -= Time.deltaTime;

    //     float minutes = Mathf.FloorToInt((timer / 60));
    //     float seconds = timer % 60;

    //     string secodsString = seconds.ToString("F2");

    //     // timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    //     timerText.text = minutes + ":" + secodsString;

    //     if (timer <= 0)
    //     {
    //         timer = 0;
    //         timerText.text = "00:00";
            
    //     }
    // }
}
