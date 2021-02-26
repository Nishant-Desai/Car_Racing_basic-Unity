using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfLapTrigger : MonoBehaviour
{
    public GameObject LapFinishTrigger;
    public GameObject LapHalfTrigger;

    private void OnTriggerEnter()
    {
        LapFinishTrigger.SetActive(true);
        LapHalfTrigger.SetActive(false);
    }

}
