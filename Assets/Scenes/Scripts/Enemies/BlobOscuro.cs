using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobOscuro : MonoBehaviour
{
    public AudioSource soundEffect;
    public ParticleSystem ps;
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "player")
        {
            if(Input.GetKeyDown("space"))
            {
                this.GetComponent<Animator>().SetTrigger("pisado");
                soundEffect.Play();
            }
        }
    }

    public void PlaySound()
    {
        ps.Play();
        soundEffect.Play();
    }
}
