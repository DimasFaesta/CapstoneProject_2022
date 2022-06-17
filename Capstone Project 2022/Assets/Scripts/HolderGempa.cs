using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolderGempa : MonoBehaviour
{
    public GameManager GM;
    public HealthPlayer hp;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("Game manager").GetComponent<GameManager>();
        GM.IntensitasGempa =1;
        StartCoroutine(Shaking());
        hp = GameObject.FindWithTag("FisikPlayer").GetComponent<HealthPlayer>(); 
    }
    // Update is called once per frame
    void Update()
    {
 
    }

    IEnumerator Shaking(){
        GM.IntensitasGempa = 1f;
        yield return new WaitForSeconds(10f);
        GM.IntensitasGempa = 0f;
        yield return new WaitForSeconds(15f);
        GM.IntensitasGempa = 0.5f;
        yield return new WaitForSeconds(15f);
        GM.IntensitasGempa = 0f;
        yield return new WaitForSeconds(15f);
        StartCoroutine(Shaking());
        
    }

}
