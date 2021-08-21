using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSelect : MonoBehaviour
{


    public GameObject fabre,öldürfabre;
    // Start is called before the first frame update
    void Start()
    {



        
        if (PlayerPrefs.GetInt("boss") == 0)
        {
            Instantiate(fabre);
            
            Debug.Log(" bu kod çalýþýyor");
            Destroy(öldürfabre);

        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
