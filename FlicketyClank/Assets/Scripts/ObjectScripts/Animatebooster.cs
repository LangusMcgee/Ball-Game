using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatebooster : MonoBehaviour
{

    public float speed = 0.4f;
    private float direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = GetComponent<Renderer>().material.mainTextureOffset.x;
    }

    // Update is called once per frame
    void Update()
    {
        direction += Time.deltaTime * speed;
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector3(0, direction));
    }
}
