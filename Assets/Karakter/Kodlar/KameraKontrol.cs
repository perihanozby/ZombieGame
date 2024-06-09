using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public Transform hedef;
    public Vector3 hedefMesafe; //kameranın hedefe olan mesafesini tanımlar.
    [SerializeField]
    private float fareHassasiyeti;
    float fareX, fareY;

    Vector3 objRot; //karakterin rotasyonunu tutar.
    public Transform karakterVucut;

    KarakterKontrol karakterHp;
    void Start()
    {
        karakterHp = GameObject.Find("Erika").GetComponent<KarakterKontrol>();
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {

    }

    private void LateUpdate() //kameranın hedefi takip etmesi 
    {
        if (karakterHp.YasiyorMu() == true)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, hedef.position + hedefMesafe, Time.deltaTime * 10);
            fareX += Input.GetAxis("Mouse X") * fareHassasiyeti;
            fareY += Input.GetAxis("Mouse Y") * fareHassasiyeti;
            if (fareY >= 25)
            {
                fareY = 25;
            }
            if (fareY <= -40)
            {
                fareY = -40;
            }
            this.transform.eulerAngles = new Vector3(fareY, fareX, 0);
            hedef.transform.eulerAngles = new Vector3(0, fareX, 0);

            Vector3 gecici = this.transform.eulerAngles;
            gecici = this.transform.eulerAngles;//Kameranın yerel açılarını bir geçici Vector3 değişkenine kopyalar. 
            gecici.z = 0;
            gecici.y = this.transform.localEulerAngles.y;// karakterin yönüyle aynı yöne bakmasını sağlar.
            gecici.x = this.transform.localEulerAngles.x + 10;
            objRot = gecici;
            karakterVucut.transform.eulerAngles = objRot; //kamera hareket ettiğinde karakterin vücudu uygun şekilde döner.



        }

    }
}
