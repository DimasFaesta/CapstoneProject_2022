using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pintu : MonoBehaviour
{
    Animator anim;
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
        }
        else
        {
            anim.SetBool("Buka", false);
        }
    }
}
