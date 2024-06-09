using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesSistemi : MonoBehaviour
{

    Camera kamera;
    public LayerMask zombiKatman;
    KarakterKontrol hpKontrol;
    public ParticleSystem Dust_v1;
    Animator anim;

    private float sarjor = 5;
    private float cephane = 20;
    private float sarjorKapasitesi = 5;
    AudioSource sesKaynagi;
    public AudioClip atesSes;
    public AudioClip reloadSes;

    public float GetSarjor()
    {
        return sarjor;
    }
    public float GetCephane()
    {
        return cephane;
    }
    void Start()
    {
        if (zombiKatman.value == 0)
        {
            Debug.LogError("Zombi katmanı atanmamış.");
            // Ya atanmalı ya da bir hata mesajı verilmeli.
        }
        kamera = Camera.main;
        hpKontrol = this.gameObject.GetComponent<KarakterKontrol>();
        anim = this.gameObject.GetComponent<Animator>();
        sesKaynagi = this.gameObject.GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (hpKontrol.YasiyorMu() == true)
        {
            if (Input.GetMouseButton(0))
            {
                if (sarjor > 0)
                {
                    anim.SetBool("atesEt", true);
                }
                if (sarjor < 0)
                {
                    anim.SetBool("atesEt", false);
                }
                if (sarjor <= 0 && cephane > 0)
                {
                    anim.SetBool("sarjorDegistirme", true);

                }
            }
            else if (Input.GetMouseButtonUp(0))
            {
                anim.SetBool("atesEt", false);
            }
        }
    }

    public void SarjorDegistirmeSes()
    {
        sesKaynagi.PlayOneShot(reloadSes);
        sesKaynagi.volume = 0.4f;

    }
    public void SarjorDegistirme()
    {
        sesKaynagi.volume = 1f;
        cephane -= sarjorKapasitesi - sarjor;
        sarjor = sarjorKapasitesi;
        anim.SetBool("sarjorDegistirme", false);
    }
    public void AtesEtme()
    {
        if (sarjor > 0)
        {
            Dust_v1.Play();
            sesKaynagi.PlayOneShot(atesSes);
            Ray ray = kamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, zombiKatman))
            {
                hit.collider.gameObject.GetComponent<Zombi>().HasarAl();
            }
            sarjor--;

        }

    }
}
