using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    player player;
    Transform temas_kupu;

    float mesafe;
    void Start()
    {
        player = GameObject.Find("player").GetComponent<player>();
        temas_kupu = GameObject.Find("player/temas_kupu").transform;
    }

    // Update is called once per frame
    void Update()
    {
      if(player.miknatis_alindi == true )
        {
            mesafe = Vector3.Distance(transform.position, temas_kupu.position);

            if(mesafe<=10)
            {
                transform.position = Vector3.MoveTowards(transform.position, temas_kupu.position, Time.deltaTime * 10.0f);
            }
        }
    }
}
