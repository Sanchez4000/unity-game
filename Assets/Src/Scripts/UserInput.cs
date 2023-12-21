using Src.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Src.Scripts
{
    public class UserInput : MonoBehaviour
    {
        private IDirectionalMovable _moveComponent;
        private Transform _transform;

        private bool MoveForward => Input.GetKey(KeyCode.W);
        private bool MoveBackward => Input.GetKey(KeyCode.S);
        private bool MoveLeft => Input.GetKey(KeyCode.A);
        private bool MoveRight => Input.GetKey(KeyCode.D);

        private void Start()
        {
            _moveComponent = GetComponent<IDirectionalMovable>();
            _transform = GetComponent<Transform>();
        }

        private void Update()
        {
            var direction = Vector3.zero;

            if (MoveForward)
                direction += _transform.forward;
            else if (MoveBackward)
                direction -= _transform.forward;

            if (MoveRight)
                direction += _transform.right;
            else if (MoveLeft)
                direction -= _transform.right;

            _moveComponent.Move(direction);
        }
    }
}
