using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class RaceFinish : MonoBehaviour {
    public GameObject car, finishCam, CompleteTrig, Canvas;

    void OnTriggerEnter() {
        this.GetComponent<BoxCollider>().enabled = false;
        Canvas.SetActive(false);
        car.SetActive(false);
        CompleteTrig.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        car.GetComponent<CarController>().enabled = false;
        car.GetComponent<CarUserControl>().enabled = false;
        car.SetActive(true);
        finishCam.SetActive(true);
    }
}
