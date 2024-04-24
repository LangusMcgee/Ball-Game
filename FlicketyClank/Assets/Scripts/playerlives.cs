using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerlives : MonoBehaviour
{
    public int health = 1;

    public Sprite fullHeart;
    public Sprite emptyHeart;
    public GameObject gameOverScreen;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            health--;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            gameOverScreen.SetActive(true);
        }
    }
}
