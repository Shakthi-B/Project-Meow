using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeditateTriggerManager : MonoBehaviour
{
    [SerializeField] public GameObject interactionCanvas;
    [SerializeField] public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        interactionCanvas.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactionCanvas.SetActive(false);
    }

}
