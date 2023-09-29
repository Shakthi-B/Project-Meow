using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//when something get into the alta, make the runes glow
namespace Cainos.PixelArtTopDown_Basic
{

    public class PropsAltar : MonoBehaviour
    {
        public List<SpriteRenderer> runes;
        public float lerpSpeed;

        public TextMeshProUGUI timeText;

        private Color curColor;
        private Color targetColor;

        public GameObject interactionCanvas;
        public GameObject player;

        private void OnTriggerEnter2D(Collider2D other)
        {
            targetColor = new Color(1, 1, 1, 1);
            timeText.text = "MEDITATE \n NOW";
        }
        private void OnTriggerStay2D(Collider2D collider)
        {
            interactionCanvas.SetActive(true);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            targetColor = new Color(1, 1, 1, 0);
            interactionCanvas.SetActive(false);
        }

        private void Update()
        {
            curColor = Color.Lerp(curColor, targetColor, lerpSpeed * Time.deltaTime);

            foreach (var r in runes)
            {
                r.color = curColor;
            }
        }
    }
}
