using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrigger;
    public GameObject HalfLapTrigger;
    public GameObject minDisplay;
    public GameObject secDisplay;
    public GameObject msDisplay;

    public GameObject lapTimeBox;

    public float rawtime;

    private void OnTriggerEnter()
    {
        rawtime = PlayerPrefs.GetFloat("Raw time");
        if(LapTimeManager.rawTime<=rawtime)
        {
            if (LapTimeManager.secCount <= 9)
            {
                secDisplay.GetComponent<Text>().text = "0" + LapTimeManager.secCount + ".";
            }
            else
            {
                secDisplay.GetComponent<Text>().text = "" + LapTimeManager.secCount + ".";
            }
            if (LapTimeManager.minCount <= 9)
            {
                minDisplay.GetComponent<Text>().text = "0" + LapTimeManager.minCount + ".";
            }
            else
            {
                minDisplay.GetComponent<Text>().text = "" + LapTimeManager.minCount + ".";
            }
            msDisplay.GetComponent<Text>().text = "" + LapTimeManager.msCount;
        }

        PlayerPrefs.SetInt("minSave", LapTimeManager.minCount);
        PlayerPrefs.SetInt("secSave", LapTimeManager.secCount);
        PlayerPrefs.SetFloat("msSave", LapTimeManager.msCount);
        PlayerPrefs.SetFloat("Raw time", LapTimeManager.rawTime);
        LapTimeManager.minCount = 0;
        LapTimeManager.secCount = 0;
        LapTimeManager.msCount = 0;
        LapTimeManager.rawTime = 0;

        HalfLapTrigger.SetActive(true);
        LapCompleteTrigger.SetActive(false);
    }
}
