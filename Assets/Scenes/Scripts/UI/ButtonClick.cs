using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    void Start()
    {
        //Esto es para que solo la textura del boton sea clickeable 
        //(y no todo el rectangulo feo)
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = 0.1f;
    }
}
