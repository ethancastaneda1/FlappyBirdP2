using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControll : MonoBehaviour
{
    public static GameControll instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BirdDied()
    {
        gameOverText.SetActive (true);
        gameOver = true;
    }
}
