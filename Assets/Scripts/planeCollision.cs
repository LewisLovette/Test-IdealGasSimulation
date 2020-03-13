using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeCollision : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("hit"+other.name);

    }
}
