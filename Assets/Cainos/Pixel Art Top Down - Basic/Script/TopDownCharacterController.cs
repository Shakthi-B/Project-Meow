using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        public float speed;

        private Animator animator;

        private void Start()
        {
            animator = GetComponent<Animator>();
        }


        private void Update()
        {
            float movX = SimpleInput.GetAxis("Horizontal");
            float movY = SimpleInput.GetAxis("Vertical");
            Vector2 dir = Vector2.zero;
            if (movX < 0)
            {
                dir.x = -1;
                animator.SetInteger("Direction", 3);
            }
            else if (movX > 0)
            {
                dir.x = 1;
                animator.SetInteger("Direction", 2);
            }

            if (movY > 0)
            {
                dir.y = 1;
                animator.SetInteger("Direction", 1);
            }
            else if (movY < 0)
            {
                dir.y = -1;
                animator.SetInteger("Direction", 0);
            }

            dir.Normalize();
            animator.SetBool("IsMoving", dir.magnitude > 0);

            GetComponent<Rigidbody2D>().velocity = speed * dir;
        }
    }
}
