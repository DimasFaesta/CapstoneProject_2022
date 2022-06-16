using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreMechanic : MonoBehaviour
{

    public HealthPlayer hp;
    public TimerShow time;
    public GameObject ScoringPanel;
    public Text scoreText;
    public Text highScoreText;

    public float score;
    public float highScore;
    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.FindWithTag("FisikPlayer").GetComponent<HealthPlayer>();
        time = GameObject.FindWithTag("Timer").GetComponent<TimerShow>();   
    }

    // Update is called once per frame
    void Update()
    {
        highScore = PlayerPrefs.GetFloat("Highscore");
        scoreText.text = score.ToString("F0") + " %";
        highScoreText.text = highScore.ToString("F0") + " %";

        if(score > highScore){
            PlayerPrefs.SetFloat("Highscore", score);
        }
    }

    void Counting(){
        score = ((hp.healthPlat * 4) + time.timer)/10;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag=="Player"){
            Time.timeScale = 0;
            Counting();
            ScoringPanel.SetActive(true);
        }
    }
}
