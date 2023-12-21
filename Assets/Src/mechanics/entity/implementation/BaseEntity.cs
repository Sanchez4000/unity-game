using UnityEngine;

namespace Assets.Src.mechanics.entity.implementation
{
    public class BaseEntity : MonoBehaviour
    {
        [SerializeField] private EntityAttributes _attributes;

        public EntityAttributes Attributes => _attributes;
    }
}
