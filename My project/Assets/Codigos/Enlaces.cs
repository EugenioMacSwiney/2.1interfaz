using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enlaces : MonoBehaviour
{
    public void EnlacesDeBoton(string enlace)
    {
        Application.OpenURL(enlace);
    }
}