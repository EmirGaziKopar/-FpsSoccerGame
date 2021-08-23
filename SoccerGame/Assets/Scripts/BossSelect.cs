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
            fabre.gameObject.SetActive(true);
            Instantiate(taraftar1);
            taraftar1.gameObject.SetActive(true);
            Instantiate(taraftar2);
            taraftar2.gameObject.SetActive(true);

            Debug.Log(" fabre üretildi");
            


        }
        else if (PlayerPrefs.GetInt("boss") == 0)
        {
            Instantiate(roy);
            Instantiate(taraftar1);
            roy.gameObject.SetActive(true);
            taraftar1.gameObject.SetActive(true);
            Debug.Log(" roy üretildi");
            

        }
        if (PlayerPrefs.GetInt("boss") == 2)
        {   
            
            
            Instantiate(leon);
            leon.gameObject.SetActive(true);
            Instantiate(taraftar1);
            taraftar1.gameObject.SetActive(true);
            Instantiate(taraftar2);
            taraftar2.gameObject.SetActive(true);
            Instantiate(taraftar3);
            taraftar3.gameObject.SetActive(true);
            Debug.Log(" leon üretildi");
            

        }







    }

    // Update is called once per frame
    void Update()
    {

    }
}
