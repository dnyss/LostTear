using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIOffOn : MonoBehaviour
{
    //========================= HELP ===================================
        //========================= HELP ===================================
        public GameObject tutorial1;
        public GameObject tutorial2;
        public GameObject tutorial3;
        public GameObject tutorial4;

    void OnTriggerEnter2D(Collider2D coll){
            if (coll.gameObject.tag == "tutorial1") {
                tutorial1.SetActive(false);
                tutorial2.SetActive(true);
                tutorial3.SetActive(false);}

            if (coll.gameObject.tag == "tutorial2") {
                tutorial1.SetActive(false);
                tutorial2.SetActive(false);
                tutorial3.SetActive(true);}

            if (coll.gameObject.tag == "tutorial3") {
                tutorial1.SetActive(false);
                tutorial2.SetActive(false);
                tutorial3.SetActive(false);
                tutorial4.SetActive(true);}
            if (coll.gameObject.tag == "tutorial4")
            {
                tutorial1.SetActive(false);
                tutorial2.SetActive(false);
                tutorial3.SetActive(false);
                tutorial4.SetActive(false);
            }
    }
}
