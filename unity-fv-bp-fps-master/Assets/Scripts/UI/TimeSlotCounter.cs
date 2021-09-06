using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeSlotCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI rewindSlotsText = null;
    [SerializeField] private TextMeshProUGUI slowMoSlotsText = null;
    [SerializeField] private TimeRewind timeRewind = null;
    [SerializeField] private SlowMotion slowMotion = null;


    void Update()
    {
        rewindSlotsText.text = timeRewind.rewindSlots.ToString();
        slowMoSlotsText.text = slowMotion.slowMoSlots.ToString();
    }
}
