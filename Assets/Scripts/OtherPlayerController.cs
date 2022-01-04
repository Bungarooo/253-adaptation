using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherPlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        dm = FindObjectOfType<DialogueMaster>();
        dm.MenuOn(false);
    }
    public DialogueMaster dm;
    float Movespeed = 5f;

    // Update is called once per frame
    void Update()
    {
        if (dm != null && !dm.isInMenu())
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + (Movespeed * Time.deltaTime), transform.position.z);
                transform.rotation = Quaternion.Euler(0, 0, 180);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - (Movespeed * Time.deltaTime), transform.position.z);
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position = new Vector3(transform.position.x - (Movespeed * Time.deltaTime), transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0, 0, 270);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position = new Vector3(transform.position.x + (Movespeed * Time.deltaTime), transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0, 0, 90);
            }
        }
    }
}
