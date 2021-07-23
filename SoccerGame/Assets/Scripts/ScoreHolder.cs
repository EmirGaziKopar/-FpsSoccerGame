using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHolder : MonoBehaviour
{

    Text scoretext;

    // Start is called before the first frame update

    private void Awake()
    {
        scoretext = GetComponent<Text>();
        GoalHolder.golsayaci = 0;

    }
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text ="Atýlan Gol:" + GoalHolder.golsayaci;
    }
}
