using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStabliser : MonoBehaviour {

    public GameObject carCube;
    float carX, carY, carZ;
    void Update() {
        carX = carCube.transform.eulerAngles.x;
        carY = carCube.transform.eulerAngles.y;
        carZ = carCube.transform.eulerAngles.z;
        transform.eulerAngles = new Vector3(carX - carX, carY, carZ - carZ);
    }
}
