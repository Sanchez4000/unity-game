using System;
using UnityEngine;

namespace Assets.Src.mechanics.entity.implementation
{
    [Serializable]
    public class EntityAttributes
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _sprintSpeed;

        public float MoveSpeed => _moveSpeed;
        public float SprintSpeed => _sprintSpeed;
    }
}
