using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mirea.Maslennikov
{
    [RequireComponent(typeof(SnakeHead))]
    [RequireComponent(typeof(SnakeController))]
    [RequireComponent(typeof(SnakeMover))]
    public class Snake : MonoBehaviour
    {
        public SnakeHead Head { get; private set; }
        public SnakeController Controller { get; private set; }
        public SnakeMover Mover { get; private set; }


        private void Awake()
        {
            Head = GetComponent<SnakeHead>();
            Controller = GetComponent<SnakeController>();
            Mover= GetComponent<SnakeMover>();
        }
    }
}

