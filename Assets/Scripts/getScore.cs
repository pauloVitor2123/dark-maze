using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class getScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("Score") == 0)
        {
            scoreText.text = "Game Over";
        }
        else
        {
            scoreText.text += PlayerPrefs.GetInt("Score");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
