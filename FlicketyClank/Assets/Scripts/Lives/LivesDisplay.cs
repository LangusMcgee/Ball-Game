using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    public playerlives Lives;
    public Text livesText;

    // Update is called once per frame
    void Update()
    {
        livesText.text = "x" + Lives.health;
    }
}
