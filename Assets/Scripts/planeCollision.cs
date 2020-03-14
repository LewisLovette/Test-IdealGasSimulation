using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeCollision : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        if(other.name == "Particle System")
        {
            Debug.Log("SELF HIT");
            
            other.transform.position = new Vector3(0, 0, 0);
        }
        Debug.Log(name+" hit "+other.name);

    }
}
