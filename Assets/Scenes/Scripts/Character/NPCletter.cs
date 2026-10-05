using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCletter : MonoBehaviour
{
    public GameObject cantalk;
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "player")
        {
            cantalk.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "player")
        {
            cantalk.SetActive(false);
        }
    }
}
