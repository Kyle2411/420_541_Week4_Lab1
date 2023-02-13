using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void ReleaseBall()
    {   
        BallController ball = GetComponentInChildren<BallController>();
        if (ball != null)
        {
            ball.transform.parent = null;
            ball.LaunchMe();
        };
    }
}
