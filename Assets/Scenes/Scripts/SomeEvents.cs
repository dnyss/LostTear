using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeEvents : MonoBehaviour
{
    public GameObject blackOut;
    public GameObject teleport;
    public GameObject player;
    public GameObject npcColgado;
    public GameObject npcFree;
    public GameObject dialogoAlone;

    IEnumerator ExampleCoroutine()
    {

        yield return new WaitForSeconds(0.7f);
        npcColgado.SetActive(false);
        dialogoAlone.SetActive(false);
        npcFree.SetActive(true);
        player.transform.position = teleport.transform.position;
    }

    public void BlackOut()
    {
        blackOut.SetActive(true);
        StartCoroutine(ExampleCoroutine());
    }
}
