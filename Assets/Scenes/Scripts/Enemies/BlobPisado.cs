using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobPisado : MonoBehaviour
{
    public AudioSource soundEffect;
    public ParticleSystem ps;
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "player")
        {
            this.GetComponent<Animator>().SetTrigger("pisado");
            soundEffect.Play();
            ps.Play();
        }
    }
}
