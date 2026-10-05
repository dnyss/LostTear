using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public TMPro.TextMeshProUGUI textMesh;
    public GameObject Collectible;
    //private int score;

    private void OnTriggerEnter2D(Collider2D coll) 
    {
        if (coll.CompareTag("collect"))
        {
            Collectible.GetComponent<UpdateCollectible>().score += 1;
            
            textMesh.SetText(Collectible.GetComponent<UpdateCollectible>().score.ToString());
            Destroy(gameObject);
        }
    }

    /*
     */
}
