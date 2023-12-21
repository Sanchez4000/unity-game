using Src.Interfaces;
using UnityEngine;

namespace Src.Scripts
{
    public class PlayerMove : MonoBehaviour, IDirectionalMovable
    {
        [SerializeField] private float _moveSpeed;

        private CharacterController _characterController;

        private void Start()
        {
            _characterController = GetComponent<CharacterController>();
        }

        public void Move(Vector3 direction)
        {
            _characterController.Move(direction.normalized * _moveSpeed * Time.deltaTime);
        }
    }
}
