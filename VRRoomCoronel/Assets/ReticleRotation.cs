using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleRotation : MonoBehaviour
{
     void Update()
    {
        transform.Rotate(0, 3, 0, Space.World);
    }
}
