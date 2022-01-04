using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLogic : MonoBehaviour
{
    bool canDialogue = false;
    Collider2D col;

    public DialogueMaster dm;

    void Start()
    {
        dm = FindObjectOfType<DialogueMaster>();
    }

    void Update()
    {
        if (canDialogue == true)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                col.GetComponent<CharDialogue>().SetTexts();
                if (!dm.isInMenu())
                {
                    dm.MenuOn(true);
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.GetComponent<CharDialogue>() != null)
        {
            canDialogue = true;
            col = c;
        }
    }

    void OnTriggerExit2D(Collider2D c)
    {
        canDialogue = false;
        col = null;
    }
}
