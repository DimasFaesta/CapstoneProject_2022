using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrigger : MonoBehaviour
{

    public HealthPlayer HP;
    public float damage =1;
    // Start is called before the first frame update
    void Start()
    {
        HP = GameObject.FindWithTag("FisikPlayer").GetComponent<HealthPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Api"){
            Debug.Log("Api");
            HP.healthPlat -= damage;
        }
    }
}
