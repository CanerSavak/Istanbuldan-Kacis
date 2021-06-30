using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamyon : MonoBehaviour
{

    public AudioSource sesdosyasi;
    public AudioClip arabasesi;
    float hiz2= 5;
    void Update()
    {
        transform.Translate(hiz2 * Time.deltaTime, 0, 0);
        sesdosyasi.PlayOneShot(arabasesi);
    }
}
