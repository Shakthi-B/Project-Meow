using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RiversideValley : MonoBehaviour
{
    public GameObject interactionCanvas;
    public GameObject player;

    public TextMeshProUGUI timeText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        timeText.text = "CHAT \n NOW";
    }
    private void OnTriggerStay2D(Collider2D collider)
    {
        interactionCanvas.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        interactionCanvas.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
