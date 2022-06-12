using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Gempa : MonoBehaviour
{
    bool aktif;
    int arah = 1;
    Rigidbody rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    public void gempa()
    {
        rig.AddForce(new Vector3(0, 3 * GameManager.nilaigempa * 100*Time.deltaTime, 0));
        rig.AddRelativeTorque(new Vector3(Random.Range(-1, 2)*.3f, 0, 0));
    }

    //public void gempaNonr()
    //{
    //    transform.rotation = Quaternion.Euler(Vector3.Slerp(new Vector3(Random.Range(-1f, 2f), 0, Random.Range(-1f, 2f)),
    //        new Vector3(Random.Range(-1f, 2f), 0, Random.Range(-1f, 2f)), GameManager.nilaigempa));
    //}

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Tanah"&&aktif==true)
        {
            gempa();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            aktif = true;
            gempa();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            aktif = false;
        }
    }


}
