using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDestroy : MonoBehaviour
{

    float time = 0f;
    

    private void Update()
    {
        time -= Time.deltaTime;


        if (time < 0)
        {
            Destroy(this.gameObject);
        }
    }



}
