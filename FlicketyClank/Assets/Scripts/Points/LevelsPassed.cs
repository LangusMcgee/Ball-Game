using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsPassed : MonoBehaviour
{
    // Start is called before the first frame update
    public marballcontroller marball;
    public Text tptext;
    // Update is called once per frame
    void Update()
    {
        tptext.text = "sections passed: " + marball.teleports;
    }
}
