using UnityEngine;

namespace Src.mechanics.entity.interfaces
{
    public interface IDirectionalMovable
    {
        public void Move(Vector3 direction);
        public void MoveSprint(Vector3 direction);
    }
}
