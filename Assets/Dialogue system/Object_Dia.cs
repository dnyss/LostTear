using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDia : MonoBehaviour
{
    //This is for when he talks to you on the street out of nowhere
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //player.GetComponent<CharacterMovement>().Detect();
        this.gameObject.SetActive(false);
    }
}