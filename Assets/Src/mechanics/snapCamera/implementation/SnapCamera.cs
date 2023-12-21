using System.Collections;
using UnityEngine;

namespace Assets.Src.mechanics.snapCamera.implementation
{
    public class SnapCamera : MonoBehaviour
    {
        [SerializeField] private Transform _startTarget;

        private Transform _transform;
        private Transform _target;
        private Vector3 _offset;

        public void SetTarget(Transform target)
        {
            _target = target;
            _offset = target.position - _transform.position;
        }

        private void Start()
        {
            _transform = GetComponent<Transform>();
            SetTarget(_startTarget);
        }
        private void Update()
        {
            if (_target == null)
                return;

            _transform.position = _target.position - _offset;
        }
    }
}