using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RingsDisplay : MonoBehaviour
{
    public CollectableRings CollectableRings;
    public Text pointsText;

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "rings: " + CollectableRings.rings;
    }
}
