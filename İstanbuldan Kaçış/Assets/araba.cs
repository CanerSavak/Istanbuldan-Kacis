using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class araba : MonoBehaviour
{
    public AudioSource sesdosyasi2;
    public AudioClip arabasesi2;
    float hiz = 5;
    void Update()
    {
        transform.Translate(0, 0, hiz * Time.deltaTime);
        sesdosyasi2.PlayOneShot(arabasesi2);
    }
}
