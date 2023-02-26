using UnityEngine;

namespace Mirea.Maslennikov
{
    [RequireComponent(typeof(Rigidbody))]
    public class SnakeMover : MonoBehaviour
    {
        private Rigidbody rb;
        private Vector3 moveDirection;
        private SnakeController controller;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            controller = GetComponent<SnakeController>();
        }

        private void FixedUpdate()
        {
            Move(moveDirection);
        }

        public void SetDirection(Vector3 dir)
        {
            moveDirection = dir;
        }

        private void Move(Vector3 dir) {
            rb.MovePosition((transform.position + dir));
        }

    }
}