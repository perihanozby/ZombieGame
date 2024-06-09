using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArayüzKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public Text mermiText;
    public Text saglikText;
    public GameObject sahteMenu;
    bool oyunDurdu;
    GameObject oyuncu;

    void Start()
    {
        oyuncu = GameObject.Find("Erika");
    }

    // Update is called once per frame
    void Update()
    {
        mermiText.text = oyuncu.GetComponent<AtesSistemi>().GetSarjor().ToString() + "/" + oyuncu.GetComponent<AtesSistemi>().GetCephane().ToString();
        saglikText.text = "HP:" + oyuncu.GetComponent<KarakterKontrol>().GetSaglik();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (oyunDurdu == true)
            {
                OyunuDevamEttir();
            }
            else if (oyunDurdu == false)
            {
                Oyunudurdur();
            }
        }

    }
    public void OyunuDevamEttir()
    {
        sahteMenu.SetActive(false);
        Time.timeScale = 1;
        oyunDurdu = false;
    }
    public void Oyunudurdur()
    {
        sahteMenu.SetActive(true);
        Time.timeScale = 0;
        oyunDurdu = true;
    }
}
