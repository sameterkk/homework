using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public int oyuncupuani;
    public float benzin;
    public string nitro;
    void ifelse(int oyuncupauni)
    {
        int oyuncupuani = 80;
        if (oyuncupuani > 75)
            Debug.Log("S�persin!");
        else if (oyuncupuani > 50)
            Debug.Log("Fena De�ilsin!");
        else
            Debug.Log("Sana Al��t�rma Gerekeiyor!");
    }
    void switchcase(float benzin)
    {
        switch (benzin)
        {
            case 0.75f:
                Debug.Log("Depo Full!");
                break;
            case 0.5f:
                Debug.Log("Dikkat et!");
                break;
            case 0.1f:
                Debug.Log("Benzinlik Bulman Laz�m!");
                break;
        }
    }
    void dowhile(string nitro)
    {
        int sayac = 1;
        while (sayac < 5)
        {
            if (nitro == "Aktif")
                Debug.Log("Nitro �zelli�i Al�nd�!");
            else
                Debug.Log("Nitro yok!");
            sayac++;
        }

    }


    void Start()
    {
        oyuncupuani = 80;
        ifelse(oyuncupuani);
        benzin = 0.1f;
        switchcase(benzin);
        nitro = "Aktif";
        dowhile(nitro);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
