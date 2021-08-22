using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    public Text botShoot, charShoot;
    public Text botDrippling, charDrippling;
    // Start is called before the first frame update
    void Start()
    {

        botShoot.text = "Computer Shoots:" + PlayerPrefs.GetInt("shootValue");
        charShoot.text = "Your Shoots:" + PlayerPrefs.GetInt("ShootValueChar");
        botDrippling.text = "Computer Drippling Rating:" + PlayerPrefs.GetInt("dripplingValue");
        charDrippling.text = "Your Drippling Rating:" + PlayerPrefs.GetInt("dripplingValueChar");








    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
