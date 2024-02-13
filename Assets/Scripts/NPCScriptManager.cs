using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScriptManager : MonoBehaviour
{
    public GameObject NPCTextbox;

    // Start is called before the first frame update
    void Awake()
    {
        NPCTextbox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            NPCTextbox.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            NPCTextbox.SetActive(false);
        }
    }
}
