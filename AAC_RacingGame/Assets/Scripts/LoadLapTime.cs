using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
    public int MinCount, SecCount;
    public float MilliCount;
    public GameObject MinuteDisplay, SecondDisplay, MilliDisplay;

    void Start() {
        MinCount = PlayerPrefs.GetInt("MinSave");
        SecCount = PlayerPrefs.GetInt("SecSave");
        MilliCount = PlayerPrefs.GetFloat("MilliSave");

        MinuteDisplay.GetComponent<Text>().text = "" + MinCount + ":";
        SecondDisplay.GetComponent<Text>().text = "" + SecCount + ".";
        MilliDisplay.GetComponent<Text>().text = "" + MilliCount;
    }
}
