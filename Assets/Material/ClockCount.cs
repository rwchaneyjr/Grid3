using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class ClockCount : MonoBehaviour
{

    public TextMeshProUGUI timeText;
    private float timer = 100f;

    void Update()
    {
        if (timer > 0)
        {
            timer -= 1 * Time.deltaTime;


            timeText.text = (timer).ToString();
        }
    }
}

