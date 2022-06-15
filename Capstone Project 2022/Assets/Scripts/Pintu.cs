using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pintu : MonoBehaviour
{
    Animator anim;
    public AudioSource SBuka, STerkunci;
    public bool Dikunci;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Aksi()
    {
        if (anim.GetBool("Buka") == false && Dikunci == false)
        {
            anim.SetBool("Buka", true);
            SBuka.Play();
        }
        else if(Dikunci == false)
        {
            anim.SetBool("Buka", false);
            SBuka.Play();
        }
       else 
        {
            STerkunci.Play();
        }
    }
}
