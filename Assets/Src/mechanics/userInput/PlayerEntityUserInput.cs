using Src.mechanics.entity.interfaces;
using UnityEngine;

namespace Assets.Src.mechanics.userInput
{
    public class PlayerEntityUserInput : MonoBehaviour
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
                direction += Vector3.forward;
            else if (MoveBackward)
                direction += Vector3.back;

            if (MoveRight)
                direction += Vector3.right;
            else if (MoveLeft)
                direction += Vector3.left;

            if (direction != Vector3.zero)
                _moveComponent.Move(direction);
        }
    }
}