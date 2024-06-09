using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
    Animator animator;
    [SerializeField]
    private float hareketHizi = 5f; // Karakterin normal hareket hızı
    [SerializeField]
    private float kosmaHizi = 10f; // Karakterin koşma hızı

    private float saglik = 100;
    private bool hayattaMi = true;
    private bool kosuyorMu = false; // Karakterin koşup koşmadığını takip etmek için bir değişken

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (saglik <= 0)
        {
            hayattaMi = false;
            animator.SetBool("yasiyorMu", hayattaMi);
        }

        if (hayattaMi)
        {
            HareketKontrol();
        }
    }

    public float GetSaglik()
    {
        return saglik;
    }

    public bool YasiyorMu()
    {
        return hayattaMi;
    }

    public void HasarAl()
    {
        saglik -= Random.Range(5, 10);
    }

    void HareketKontrol()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Space tuşuna basılıysa koşma kontrolü
        kosuyorMu = Input.GetKey(KeyCode.Space); // Space tuşuna basılıysa koşuyorMu true olacak

        float hareketHiziYon = kosuyorMu ? kosmaHizi : hareketHizi; // Koşma durumuna göre hareket hızı belirlenir

        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);

        Vector3 hareket = new Vector3(horizontal, 0f, vertical) * hareketHiziYon * Time.deltaTime;

        transform.Translate(hareket);
    }
}
