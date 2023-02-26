using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mirea.Maslennikov
{
    public class SnakeController : MonoBehaviour
    {
        [Range(0.01f, 1)]
        [SerializeField] private float moveSpeed;

        private SnakeMover mover;
        private Vector3 moveDirection = Vector3.forward;

        public float MoveSpeed
        {
            get { return moveSpeed; }
            set
            {
                if (value < 0)
                    Debug.LogError("Скорость не может быть отрицательной.");
                else
                    moveSpeed = value;
            }
        }

        private void Awake()
        {
            mover = GetComponent<SnakeMover>();
        }

        private void Update()
        {
            var axisX = Input.GetAxisRaw("Horizontal");
            var axisZ = Input.GetAxisRaw("Vertical");
            if (axisX != 0 || axisZ != 0)
            {
                moveDirection.Set(axisX, moveDirection.y, axisZ);
                mover.SetDirection(moveDirection);
            }            
        }
    }
}
