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
        
        
    }

    // Update is called once per frame


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

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "PintuLemari")
            {
                Ketiban.SetActive(true);
                Time.timeScale = 0;
            }
    }

}
