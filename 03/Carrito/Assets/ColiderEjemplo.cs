using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderEjemplo : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }
}
