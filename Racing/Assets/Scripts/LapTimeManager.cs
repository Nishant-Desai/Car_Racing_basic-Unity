using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int minCount;
    public static int secCount;
    public static float msCount;
    public static string msDisplay;

    public GameObject minBox;
    public GameObject secBox;
    public GameObject msBox;

    public static float rawTime;

    // Update is called once per frame
    void Update()
    {
        msCount += (Time.deltaTime * 10);
        rawTime += Time.deltaTime;
        msDisplay = msCount.ToString("F0");
        msBox.GetComponent<Text>().text = "" + msDisplay;

        if(msCount>=10)
        {
            msCount = 0;
            secCount += 1;
        }
        if(secCount<=9)
        {
            secBox.GetComponent<Text>().text = "0" + secCount + ".";
        }
        else
        {
            secBox.GetComponent<Text>().text = "" + secCount + ".";
        }
        if(secCount>=60)
        {
            secCount = 0;
            minCount += 1;
        }
        if(minCount<=9)
        {
            minBox.GetComponent<Text>().text = "0" + minCount + ".";
        }
        else
        {
            minBox.GetComponent<Text>().text = "" + minCount + ".";
        }
    }
}
