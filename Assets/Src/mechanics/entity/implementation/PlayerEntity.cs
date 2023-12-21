using Assets.Src.mechanics.entity.implementation;
using Src.mechanics.entity.interfaces;
using UnityEngine;

namespace Src.mechanics.entity.implementation
{
    public class PlayerEntity : BaseEntity, IDirectionalMovable
    {
        private CharacterController _characterController;
        private Transform _transform;

        public void Move(Vector3 direction)
        {
            ReleaseMove(direction, Attributes.MoveSpeed);
        }
        public void MoveSprint(Vector3 direction)
        {
            ReleaseMove(direction, Attributes.SprintSpeed);
        }

        private void ReleaseMove(Vector3 direction, float speed)
        {
            var motion = speed * Time.deltaTime * direction.normalized;
            var newPosition = motion + _transform.position;
            var lookTarget = new Vector3(newPosition.x, _transform.position.y, newPosition.z);

            _transform.LookAt(lookTarget);
            _characterController.Move(speed * Time.deltaTime * _transform.forward);
        }

        private void Start()
        {
            _characterController = GetComponent<CharacterController>();
            _transform = GetComponent<Transform>();
        }
    }
}
