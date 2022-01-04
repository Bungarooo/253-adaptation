using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowTextTimed());
    }

    IEnumerator ShowTextTimed()
    {
        yield return new WaitForSeconds(3f);
        FindObjectOfType<DialogueMaster>().MenuOn(false);
        transform.root.GetChild(1).gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
