using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombi : MonoBehaviour
{
    public float zombiHP = 20;
    Animator zombianimator;
    bool ZombiDying;
    GameObject hedefOyuncu;
    public float kovalamaMesafesi;
    public float saldirmaMesafesi;
    float mesafe;
    NavMeshAgent zombiNavMesh;
    AudioSource sesKaynagi;
    public AudioClip saldirmaSesi;


    void Start()
    {
        zombianimator = this.GetComponent<Animator>();
        hedefOyuncu = GameObject.Find("Erika");
        zombiNavMesh = this.GetComponent<NavMeshAgent>();
        sesKaynagi = this.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (zombiHP <= 0)
        {
            ZombiDying = true;
        }
        if (ZombiDying == true)
        {
            zombianimator.SetBool("oldu", true);
            StartCoroutine(yokOl());
        }
        else
        {
            mesafe = Vector3.Distance(this.transform.position, hedefOyuncu.transform.position);
            if (mesafe < kovalamaMesafesi)
            {
                zombiNavMesh.isStopped = false;
                zombiNavMesh.SetDestination(hedefOyuncu.transform.position);
                //yürüme animasyonu
                zombianimator.SetBool("yuruyor", true);
                zombianimator.SetBool("saldiriyor", false);
                this.transform.LookAt(hedefOyuncu.transform.position);

            }
            else
            {
                zombiNavMesh.isStopped = true;
                //durma animasyonu
                zombianimator.SetBool("yuruyor", false);
                zombianimator.SetBool("saldiriyor", false);

            }
            if (mesafe < saldirmaMesafesi)
            {
                this.transform.LookAt(hedefOyuncu.transform.position);
                zombiNavMesh.isStopped = true;
                //vurma animasyonu
                zombianimator.SetBool("yuruyor", false);
                zombianimator.SetBool("saldiriyor", true);
            }

        }
    }
    public void HasarVerSes()
    {
        sesKaynagi.PlayOneShot(saldirmaSesi);

    }

    public void HasarVer()
    {
        hedefOyuncu.GetComponent<KarakterKontrol>().HasarAl();
    }
    IEnumerator yokOl()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }

    public void HasarAl()
    {
        zombiHP -= Random.Range(15, 25);
    }
}
