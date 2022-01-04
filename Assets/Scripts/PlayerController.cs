using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float Movespeed = 5f;

    public DialogueMaster dm;

    [HideInInspector] public bool TheEnd = false;

    void Start()
    {
        dm = FindObjectOfType<DialogueMaster>();
    }

    float xAnchor = 6.38f;
    float yAnchor = 1.85f;

    float yShake = 0f;
    //bool incrXShake = true;
    bool incrYShake = true;

    int dir = 0; //0==up, 1==down, 2==left, 3==right


    // Update is called once per frame
    void Update()
    {
        if (dm != null && !dm.isInMenu() && TheEnd == false)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + (Movespeed * Time.deltaTime), transform.position.z);
                transform.rotation = Quaternion.Euler(0, 0, 180);
                if (transform.childCount > 0)
                {
                    transform.GetChild(0).localRotation = Quaternion.Euler(0, 0, 180);
                    dir = 0;
                }
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - (Movespeed * Time.deltaTime), transform.position.z);
                transform.rotation = Quaternion.Euler(0, 0, 0);
                if (transform.childCount > 0)
                {
                    transform.GetChild(0).localRotation = Quaternion.Euler(0, 0, 0);
                    dir = 1;
                }
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position = new Vector3(transform.position.x - (Movespeed * Time.deltaTime), transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0, 0, 270);
                if (transform.childCount > 0)
                {
                    transform.GetChild(0).localRotation = Quaternion.Euler(0, 0, 90);
                    dir = 2;
                }
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position = new Vector3(transform.position.x + (Movespeed * Time.deltaTime), transform.position.y, transform.position.z);
                transform.rotation = Quaternion.Euler(0, 0, 90);
                if (transform.childCount > 0)
                {
                    transform.GetChild(0).localRotation = Quaternion.Euler(0, 0, 270);
                    dir = 3;
                }
            }
        }

        if (!(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)))
        {
            if (incrYShake)
            {
                yShake += .1f * Time.deltaTime;
            }
            else
            {
                yShake -= .1f * Time.deltaTime;
            }
            if (yShake > .1)
                incrYShake = false;
            if (yShake < -.1)
                incrYShake = true;
        }
        if (dir == 0)
        {
            transform.GetChild(0).localPosition = new Vector3(-xAnchor, -yAnchor - yShake, -10f);
        }
        else if (dir == 1)
        {
            transform.GetChild(0).localPosition = new Vector3(xAnchor, yAnchor + yShake, -10f);
        }
        else if (dir == 2)
        {
            transform.GetChild(0).localPosition = new Vector3(-yAnchor - yShake, xAnchor, -10f);
        }
        else if (dir == 3)
        {
            transform.GetChild(0).localPosition = new Vector3(yAnchor + yShake, -xAnchor, -10f);
        }
    }
}
