using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] bool LeftDoor = true;

    [HideInInspector] public GameObject player;
    public void Start()
    {
        player = GameObject.Find("Player");
    }
    public void OnTriggerEnter2D(Collider2D c)
    {
        if (LeftDoor)
        {
            player.transform.position = new Vector3(player.transform.position.x + 6f, player.transform.position.y, player.transform.position.z);
        }
        else
        {
            player.transform.position = new Vector3(player.transform.position.x - 6f, player.transform.position.y, player.transform.position.z);
        }
    }
}
