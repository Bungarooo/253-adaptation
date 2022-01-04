using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterTrain : MonoBehaviour
{
    GameObject player;

    public void Start()
    {
        player = GameObject.Find("Player");
    }
    public void OnTriggerEnter2D(Collider2D c)
    {
        if (c.name == player.name)
        {
            SceneManager.LoadScene(2);
        }
    }
}
