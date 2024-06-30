using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderEjemplo : MonoBehaviour
{
    [SerializeField] float delayDestroy = 0.5f;
    private bool tienePaquete; //false
    [SerializeField] Color32 tienePaqueteColor = new Color32(r: 255, g: 0, b: 0, a: 255);
    [SerializeField] Color32 noTienePaqueteColor = new Color32(r: 0, g: 0, b: 0, a: 255);
    private SpriteRenderer spriteRenderer;


    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entrando en trigger!");
        if (other.tag == "Paquete" && !tienePaquete)
        {
            Debug.Log("Recogio paquete!");
            tienePaquete = true;
            spriteRenderer.color = tienePaqueteColor;
            Destroy(other.gameObject, delayDestroy);
        }
        if (other.tag == "Cliente" && tienePaquete)
        {
            tienePaquete = false;
            spriteRenderer.color = noTienePaqueteColor;
            Debug.Log("Dejo paquete!");
        }
    }


}
