using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndLine : MonoBehaviour
{
    public TMP_Text scoreValue;
    private float tempo;
    // Update is called once per frame
    void OnTriggerStay(Collider objeto)
    {
        if (objeto.CompareTag("EndLine"))
        {
            tempo += Time.deltaTime;
            if(tempo > 1)
            {

                SceneManager.LoadScene("GameOver");

            }
        }
    }
}
