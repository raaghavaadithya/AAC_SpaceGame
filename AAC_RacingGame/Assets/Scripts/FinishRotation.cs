using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishRotation : MonoBehaviour
{
    void Update() {
        transform.Rotate(0, 0.3f, 0, Space.World);
    }
}
