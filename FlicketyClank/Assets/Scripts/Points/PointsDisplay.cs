using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsDisplay : MonoBehaviour
{
    public CollectableRings CollectableRings;
    public Text pointsText;

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "points: " + CollectableRings.rings;
    }
}
