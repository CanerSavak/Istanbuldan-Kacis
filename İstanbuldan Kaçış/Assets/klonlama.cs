using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klonlama : MonoBehaviour
{
    public GameObject tlcoin;
    public GameObject araba;
    public GameObject bariyer;
    public GameObject bariyer2;
    public GameObject cöpkutusu;
    public GameObject kamyon;
    public GameObject lastikengel;
    public GameObject miknatis;

    public Transform player;
    float silinme_zamanı = 7.0f;
    float sağ_z_koordinat = 3.0f;
    float sol_z_koordinat = -3.0f;
    float orta_koordinat = 0.0f;
    int sayi = 0 ;
    void Start()
    {
        InvokeRepeating("sayac", 0, 1.0f);
        
         InvokeRepeating("nesne_klonla", 2, 4.0f);
         InvokeRepeating("nesne_klonla2", 2, 10.0f);
         InvokeRepeating("nesne_klonla", 120, 7.0f);
        InvokeRepeating("nesne_klonla2", 180, 16.0f);






    }
    void sayac()
    {
        sayi++;
    }

    void nesne_klonla()
    {
        int rastsayi = Random.Range(0, 100);
        
        
        if (rastsayi >0 && rastsayi < 40)
        {
            klonla(bariyer, 0f);
        }
        if (rastsayi > 40 && rastsayi < 70)
        {
            klonla(bariyer2, 0f);
        }
        if (rastsayi > 70 && rastsayi < 100)
        {
            klonla(cöpkutusu, 1.0f);
        }
        
        
    }
    void nesne_klonla2()
    {
        int rastsayi2 = Random.Range(0, 100);
      
        if (rastsayi2 > 0 && rastsayi2 < 40)
        {
            klonla2(araba, 1.0f);
        }
       
        if (rastsayi2 > 40 && rastsayi2 < 80)
        {
            klonla2(kamyon, 1.0f);
        }
        if (rastsayi2 > 80 && rastsayi2 < 100)
        {
            if (player.gameObject.GetComponent<player>().miknatis_alindi == false)
            {
                klonla2(miknatis, 1.0f);
            }
        }

    }
    void klonla2(GameObject nesne2, float Y_koordinat2)
    {
        GameObject y_klon = Instantiate(nesne2);
        GameObject y_klon2 = Instantiate(nesne2);

        int rast = Random.Range(0,100);
        if(rast < 25)
        {
            y_klon.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat2, orta_koordinat);
        }
        if (rast > 25 && rast < 50)
        {
            y_klon.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat2, sol_z_koordinat);            
        }
        if (rast > 50 && rast < 70)
        {
            y_klon.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat2, sağ_z_koordinat);
        }
        if (rast > 70 && rast < 80)
        {
            y_klon.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat2, sol_z_koordinat);
            y_klon2.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat2, sağ_z_koordinat);
        }
        if (rast > 80 && rast < 90)
        {
            y_klon.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat2, orta_koordinat);
            y_klon2.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat2, sol_z_koordinat);
        }
        if (rast > 90 && rast < 100)
        {
            y_klon.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat2, orta_koordinat);
            y_klon2.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat2, sağ_z_koordinat);
        }
        Destroy(y_klon, silinme_zamanı);
        Destroy(y_klon2, silinme_zamanı);

    }

    void klonla(GameObject nesne, float Y_koordinat)
    {
        GameObject yeni_klon = Instantiate(nesne);
        GameObject yeni_klon2 = Instantiate(nesne);
        GameObject yeni_klon3 = Instantiate(nesne);
        GameObject yeni_klon4 = Instantiate(nesne);
        GameObject yeni_klon5 = Instantiate(nesne);
        GameObject yeni_klon6 = Instantiate(nesne);
        GameObject yeni_klon7 = Instantiate(tlcoin);
        GameObject yeni_klon8 = Instantiate(tlcoin);
        GameObject yeni_klon9 = Instantiate(tlcoin);
        GameObject yeni_klon10 = Instantiate(tlcoin);
        GameObject yeni_klon11 = Instantiate(tlcoin);
        GameObject yeni_klon12 = Instantiate(tlcoin);


        int rastsayi3 = Random.Range(0, 100);
        int durum = Random.Range(0, 100);
        if (durum < 40)
        {
            if (rastsayi3 < 25)
            {

                yeni_klon.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat, orta_koordinat);
                yeni_klon2.transform.position = new Vector3(player.position.x - 22.0f, Y_koordinat, orta_koordinat);
                yeni_klon3.transform.position = new Vector3(player.position.x - 24.0f, Y_koordinat, orta_koordinat);
                yeni_klon7.transform.position = new Vector3(player.position.x - 20.0f, 1, sol_z_koordinat);
                yeni_klon8.transform.position = new Vector3(player.position.x - 22.0f, 1, sol_z_koordinat);
                yeni_klon9.transform.position = new Vector3(player.position.x - 24.0f, 1, sol_z_koordinat);
                yeni_klon10.transform.position = new Vector3(player.position.x - 20.0f, 1, sağ_z_koordinat);
                yeni_klon11.transform.position = new Vector3(player.position.x - 22.0f, 1, sağ_z_koordinat);
                yeni_klon12.transform.position = new Vector3(player.position.x - 24.0f, 1, sağ_z_koordinat);

            }
            if (25 < rastsayi3 && rastsayi3 < 50)
            {
                yeni_klon.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat, sol_z_koordinat);
                yeni_klon2.transform.position = new Vector3(player.position.x - 22.0f, Y_koordinat, sol_z_koordinat);
                yeni_klon3.transform.position = new Vector3(player.position.x - 24.0f, Y_koordinat, sol_z_koordinat);
                yeni_klon4.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat, sağ_z_koordinat);
                yeni_klon5.transform.position = new Vector3(player.position.x - 22.0f, Y_koordinat, sağ_z_koordinat);
                yeni_klon6.transform.position = new Vector3(player.position.x - 24.0f, Y_koordinat, sağ_z_koordinat);
                yeni_klon7.transform.position = new Vector3(player.position.x - 20.0f, 1, orta_koordinat);
                yeni_klon8.transform.position = new Vector3(player.position.x - 22.0f, 1, orta_koordinat);
                yeni_klon9.transform.position = new Vector3(player.position.x - 24.0f, 1, orta_koordinat);
            }
            if (rastsayi3 > 50 && rastsayi3 < 75)
            {
                yeni_klon.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat, orta_koordinat);
                yeni_klon2.transform.position = new Vector3(player.position.x - 22.0f, Y_koordinat, orta_koordinat);
                yeni_klon3.transform.position = new Vector3(player.position.x - 24.0f, Y_koordinat, orta_koordinat);
                yeni_klon4.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat, sol_z_koordinat);
                yeni_klon5.transform.position = new Vector3(player.position.x - 22.0f, Y_koordinat, sol_z_koordinat);
                yeni_klon6.transform.position = new Vector3(player.position.x - 24.0f, Y_koordinat, sol_z_koordinat);
                yeni_klon7.transform.position = new Vector3(player.position.x - 20.0f, 1, sağ_z_koordinat);
                yeni_klon8.transform.position = new Vector3(player.position.x - 22.0f, 1, sağ_z_koordinat);
                yeni_klon9.transform.position = new Vector3(player.position.x - 24.0f, 1, sağ_z_koordinat);
            }
            if (rastsayi3 > 75 && rastsayi3 < 100)
            {
                yeni_klon.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat, orta_koordinat);
                yeni_klon2.transform.position = new Vector3(player.position.x - 22.0f, Y_koordinat, orta_koordinat);
                yeni_klon3.transform.position = new Vector3(player.position.x - 24.0f, Y_koordinat, orta_koordinat);
                yeni_klon4.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat, sağ_z_koordinat);
                yeni_klon5.transform.position = new Vector3(player.position.x - 22.0f, Y_koordinat, sağ_z_koordinat);
                yeni_klon6.transform.position = new Vector3(player.position.x - 24.0f, Y_koordinat, sağ_z_koordinat);
                yeni_klon7.transform.position = new Vector3(player.position.x - 20.0f, 1, sol_z_koordinat);
                yeni_klon8.transform.position = new Vector3(player.position.x - 22.0f, 1, sol_z_koordinat);
                yeni_klon9.transform.position = new Vector3(player.position.x - 24.0f, 1, sol_z_koordinat);

            }
            Destroy(yeni_klon, silinme_zamanı);
            Destroy(yeni_klon2, silinme_zamanı);
            Destroy(yeni_klon3, silinme_zamanı);
            Destroy(yeni_klon4, silinme_zamanı);
            Destroy(yeni_klon5, silinme_zamanı);
            Destroy(yeni_klon6, silinme_zamanı);
            Destroy(yeni_klon7, silinme_zamanı);
            Destroy(yeni_klon8, silinme_zamanı);
            Destroy(yeni_klon9, silinme_zamanı);
            Destroy(yeni_klon10, silinme_zamanı);
            Destroy(yeni_klon11, silinme_zamanı);
            Destroy(yeni_klon12, silinme_zamanı);
        }
        if(durum > 40)
        {
            if (rastsayi3 < 25)
            {
                yeni_klon.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat, orta_koordinat);
                yeni_klon7.transform.position = new Vector3(player.position.x - 20.0f, 1, sol_z_koordinat);
                yeni_klon8.transform.position = new Vector3(player.position.x - 20.0f, 1, sağ_z_koordinat);
            }
            if (rastsayi3 > 25 && rastsayi3 < 50)
            {
                yeni_klon.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat, orta_koordinat);
                yeni_klon2.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat, sol_z_koordinat);
                yeni_klon8.transform.position = new Vector3(player.position.x - 20.0f, 1, sağ_z_koordinat);
            }
            if (rastsayi3 > 50 && rastsayi3 < 75)
            {
                yeni_klon.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat, sol_z_koordinat);
                yeni_klon2.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat, sağ_z_koordinat);
                yeni_klon8.transform.position = new Vector3(player.position.x - 20.0f, 1, orta_koordinat);
            }
            if (rastsayi3 > 75 && rastsayi3 < 100)
            {
                yeni_klon.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat, orta_koordinat);
                yeni_klon2.transform.position = new Vector3(player.position.x - 20.0f, Y_koordinat, sağ_z_koordinat);
                yeni_klon8.transform.position = new Vector3(player.position.x - 20.0f, 1, sol_z_koordinat);
            }

            Destroy(yeni_klon, silinme_zamanı);
            Destroy(yeni_klon2, silinme_zamanı);
            Destroy(yeni_klon7, silinme_zamanı);
            Destroy(yeni_klon8, silinme_zamanı);

        }
            
        
    }
    
    void Update()
    {

    }
}
