using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueMaster : MonoBehaviour
{

    [SerializeField] private bool inMenu = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    public bool isInMenu()
    {
        return inMenu;
    }

    public void MenuOn(bool b)
    {
        inMenu = b;
        transform.parent.GetChild(0).gameObject.SetActive(b);
        transform.parent.GetChild(1).gameObject.SetActive(b);
        transform.parent.GetChild(1).GetChild(0).gameObject.SetActive(true);
        transform.parent.GetChild(2).gameObject.SetActive(b);
        transform.parent.GetChild(2).GetChild(0).gameObject.SetActive(false);
        transform.parent.GetChild(3).gameObject.SetActive(b);
        transform.parent.GetChild(3).GetChild(0).gameObject.SetActive(false);
        transform.parent.GetChild(4).GetChild(0).gameObject.SetActive(false);
        transform.parent.GetChild(4).GetChild(1).gameObject.SetActive(false);
        transform.parent.GetChild(4).GetChild(2).gameObject.SetActive(false);
        beenInMenu = false;
    }

    private bool beenInMenu;

    // Update is called once per frame
    void Update()
    {
        if (inMenu)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                MenuOn(false);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (transform.parent.GetChild(1).GetChild(0).gameObject.activeSelf == true)
                {
                    transform.parent.GetChild(3).GetChild(0).gameObject.SetActive(true);
                    transform.parent.GetChild(1).GetChild(0).gameObject.SetActive(false);
                }
                else if (transform.parent.GetChild(2).GetChild(0).gameObject.activeSelf == true)
                {
                    transform.parent.GetChild(1).GetChild(0).gameObject.SetActive(true);
                    transform.parent.GetChild(2).GetChild(0).gameObject.SetActive(false);
                }
                else if (transform.parent.GetChild(3).GetChild(0).gameObject.activeSelf == true)
                {
                    transform.parent.GetChild(2).GetChild(0).gameObject.SetActive(true);
                    transform.parent.GetChild(3).GetChild(0).gameObject.SetActive(false);
                }
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (transform.parent.GetChild(1).GetChild(0).gameObject.activeSelf == true)
                {
                    transform.parent.GetChild(2).GetChild(0).gameObject.SetActive(true);
                    transform.parent.GetChild(1).GetChild(0).gameObject.SetActive(false);
                }
                else if (transform.parent.GetChild(2).GetChild(0).gameObject.activeSelf == true)
                {
                    transform.parent.GetChild(3).GetChild(0).gameObject.SetActive(true);
                    transform.parent.GetChild(2).GetChild(0).gameObject.SetActive(false);
                }
                else if (transform.parent.GetChild(3).GetChild(0).gameObject.activeSelf == true)
                {
                    transform.parent.GetChild(1).GetChild(0).gameObject.SetActive(true);
                    transform.parent.GetChild(3).GetChild(0).gameObject.SetActive(false);
                }
            }
            if (Input.GetKeyDown(KeyCode.X) && beenInMenu)
            {
                if (transform.parent.GetChild(1).GetChild(0).gameObject.activeSelf == true)
                {
                    transform.parent.GetChild(4).GetChild(0).gameObject.SetActive(true);
                    transform.parent.GetChild(1).GetChild(0).gameObject.SetActive(false);
                    transform.parent.GetChild(1).gameObject.SetActive(false);
                    transform.parent.GetChild(2).gameObject.SetActive(false);
                    transform.parent.GetChild(3).gameObject.SetActive(false);
                }
                else if (transform.parent.GetChild(2).GetChild(0).gameObject.activeSelf == true)
                {
                    transform.parent.GetChild(4).GetChild(1).gameObject.SetActive(true);
                    transform.parent.GetChild(2).GetChild(0).gameObject.SetActive(false);
                    transform.parent.GetChild(1).gameObject.SetActive(false);
                    transform.parent.GetChild(2).gameObject.SetActive(false);
                    transform.parent.GetChild(3).gameObject.SetActive(false);
                }
                else if (transform.parent.GetChild(3).GetChild(0).gameObject.activeSelf == true)
                {
                    transform.parent.GetChild(4).GetChild(2).gameObject.SetActive(true);
                    transform.parent.GetChild(3).GetChild(0).gameObject.SetActive(false);
                    transform.parent.GetChild(1).gameObject.SetActive(false);
                    transform.parent.GetChild(2).gameObject.SetActive(false);
                    transform.parent.GetChild(3).gameObject.SetActive(false);
                }
            }
            beenInMenu = true;
        }
    }
}

//.GetChild(4) is .GetChild(4).GetChild(0)
//.GetChild(5) is .GetChild(4).GetChild(1)
//.GetChild(6) is .GetChild(4).GetChild(2)