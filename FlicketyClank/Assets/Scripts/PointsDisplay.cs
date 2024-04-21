using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsDisplay : MonoBehaviour
{
    int points = 0;
    public Text pointsText;

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "points: " + points;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            points++;
        }
    }
}
