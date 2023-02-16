using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BallController : MonoBehaviour
{
    
    public GameObject bowlingPin;
    int force = 13;
    public void Start()
    {
        
    }

    public void LaunchMe()
    {   
        GetComponent<Rigidbody>().AddForce(GetLaunchDirection() * force , ForceMode.Impulse);
    }

    public Vector3 GetLaunchDirection()
    {
        return bowlingPin.transform.position - transform.position;
    }
}
