using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isPassed : MonoBehaviour
{
    public bool isAccess;

   

    private void Awake()
    {
        isAccess = false;
    }



    


    private void OnTriggerStay(Collider other)
    {

        
        if (other.tag == "Ball")
        {
            isAccess = true;
        }
        
        

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball")
        {
            isAccess = false;
        }
    }


}
