using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevels : MonoBehaviour
{
    public void CutsceneSun()
    {
        SceneManager.LoadScene("Cutscene0");
    }
    public void CutsceneUniverse()
    {
        SceneManager.LoadScene("CutsceneUNIVERSE");
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "player")
        {
            SceneManager.LoadScene("CutsceneUNIVERSE"); 
        }
    }
}
