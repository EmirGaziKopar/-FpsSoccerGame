using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSelect : MonoBehaviour
{


    public GameObject fabre, destroyFabre;
    public GameObject roy, destroyRoy;
    public GameObject leon, destroyLeon;
    public GameObject taraftar1, taraftar2, taraftar3;
    // Start is called before the first frame update
    void Start()
    {




        if (PlayerPrefs.GetInt("boss") == 1)
        {
            Instantiate(fabre);
            Instantiate(taraftar1);
            Instantiate(taraftar2);
            Debug.Log(" fabre üretildi");
            Destroy(destroyFabre);

        }

        if (PlayerPrefs.GetInt("boss") == 0)
        {
            Instantiate(roy);
            Instantiate(taraftar1);
            Debug.Log(" roy üretildi");
            Destroy(destroyRoy);

        }


        if (PlayerPrefs.GetInt("boss") == 2)
        {
            Instantiate(leon);
            Instantiate(taraftar1);
            Instantiate(taraftar2);
            Instantiate(taraftar3);
            Debug.Log(" leon üretildi");
            Destroy(destroyLeon);

        }







    }

    // Update is called once per frame
    void Update()
    {

    }
}
