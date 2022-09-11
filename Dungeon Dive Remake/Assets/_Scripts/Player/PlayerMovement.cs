using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BEAN 
{
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField] private float moveSpeed = 8f;
        private float horizontalMove, verticalMove;
        private Vector3 previousPos;

        [Header("Animation")]
        [SerializeField] private Animator animator;


        void Update()
        {
            GetMoveInputs();
            MovePlayer();
            previousPos = transform.position;
        }

        private void GetMoveInputs()
        {
            horizontalMove = Input.GetAxisRaw("Horizontal");
            verticalMove = Input.GetAxisRaw("Vertical");
        }

        private void MovePlayer()
        {
            transform.position += new Vector3(horizontalMove, verticalMove, 0) * Time.deltaTime * moveSpeed;
            // Animate player
            if (previousPos != transform.position)
            {
                animator.SetBool("isMoving", true);
            } else {
                animator.SetBool("isMoving", false);
            }
        }
    }
}
