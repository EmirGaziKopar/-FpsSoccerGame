using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isPassed : MonoBehaviour
{
    public bool isAccess;

    [SerializeField] GoalKeeperEnum goalKeeperEnum;
   

    private void Awake()
    {
        isAccess = false;
    }



    


    private void OnTriggerStay(Collider other)
    {
        if(goalKeeperEnum == GoalKeeperEnum.Left)
        {
            if (other.tag == "Ball")
            {
                isAccess = true;
            }
        }
        else if (goalKeeperEnum == GoalKeeperEnum.Right)
        {
            if (other.tag == "Ball")
            {
                isAccess = true;
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        
        if (goalKeeperEnum == GoalKeeperEnum.Left)
        {
            if (other.tag == "Ball")
            {
                isAccess = false;
            }
        }
        else if (goalKeeperEnum == GoalKeeperEnum.Right)
        {
            if (other.tag == "Ball")
            {
                isAccess = false;
            }
        }
    }


}
