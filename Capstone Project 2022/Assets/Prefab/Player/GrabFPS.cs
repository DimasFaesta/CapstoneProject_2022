using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabFPS : MonoBehaviour
{

    public float KekuatanGenggam;
    public float PanjangTangan;
    public Transform tangan;

    RaycastHit hit;
    Rigidbody benda;

    [HideInInspector]
    public int megang = 1;

    private void FixedUpdate()
    {
        if (benda != null)
        {
            benda.AddForce((tangan.position - benda.transform.position),ForceMode.VelocityChange);

            Mathf.Clamp(benda.velocity.x, -1, 1);
            Mathf.Clamp(benda.velocity.y, -1, 1);
            Mathf.Clamp(benda.velocity.z, -1, 1);

            benda.velocity = benda.velocity * KekuatanGenggam;
        }
    }

    public void Ambil()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit,PanjangTangan))
        {
            if (hit.collider.CompareTag("Pintu"))
            {
                GameObject pintu = hit.collider.gameObject;

                pintu.GetComponent<Pintu>().Aksi();
            }

            //if (hit.collider.attachedRigidbody)
            //{
            //    if (megang == 1)
            //    {
            //        benda = hit.rigidbody;
            //        benda.useGravity = false;
            //    }
            //}
            //if (megang == -1)
            //{
            //    if (megang == -1)
            //    {
            //        benda.useGravity = true;
            //        benda = null;
            //    }
            //}
            //megang = megang * -1;

        }

    }

}
