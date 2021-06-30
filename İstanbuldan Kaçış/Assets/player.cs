using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject Bitti_pnl;
    public Animator animasyon;

    public TMPro.TextMeshProUGUI puan_txt;
    public TMPro.TextMeshProUGUI coin_txt;

    public Transform yol1;
    public Transform yol2;

    int puan = 0;
    int toplam_coin = 0;
    int x = 0;

    public bool miknatis_alindi = false;
    public Rigidbody rigi;

    public AudioSource ses_dosyasi;
    public AudioSource kosma_ses_dosyasi;
    public AudioClip araba_sesi;
    public AudioClip coin_sesi;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "SON_1")
        {
            yol2.position = new Vector3(yol1.position.x - 0.4f, yol1.position.y, yol1.position.z);
        }
        if (other.gameObject.name == "SON_2")
        {
            yol1.position = new Vector3(yol2.position.x - 377.0f, yol2.position.y, yol2.position.z);
        }
        
        if (other.gameObject.tag == "enemy")
        {
            animasyon.SetBool("killed1", true);
            Bitti_pnl.SetActive(true);
            kosma_ses_dosyasi.enabled = false;
            Time.timeScale = 0.0f;
        }
        if (other.gameObject.tag == "coin")
        {
            ses_dosyasi.PlayOneShot(coin_sesi);
            Destroy(other.gameObject);
            toplam_coin++;
            puan += 5;
            puan_txt.text = puan.ToString("00000");
            coin_txt.text = toplam_coin.ToString();
        }
        if (other.gameObject.tag == "miknatis")
        {
            GameObject[] tum_miknatislar = GameObject.FindGameObjectsWithTag("miknatis");
            foreach (GameObject miknatis in tum_miknatislar)
            {
                Destroy(miknatis);
            }
            miknatis_alindi = true;
            Invoke("miknatisi_resetle", 10.0f);
        }
    }
    void miknatisi_resetle()
    {
        miknatis_alindi = false;
    }

    private void OnCollisionStay(Collision collision)
    {
        kosma_ses_dosyasi.enabled = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        kosma_ses_dosyasi.enabled = false;
    }
    void Update()
    {
        
    }
    
    void Start()
    {
        InvokeRepeating("puanartisi", 0, 1);
        

    }
    void puanartisi()
    {
        puan++;
        puan_txt.text = puan.ToString("00000");
    }
   void bitti()
    {
        Bitti_pnl.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
