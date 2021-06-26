using UnityEngine;

namespace Game.Interfaces
{
    public interface IPooledObject
    {
        void OnObjectSpawn();

        void OnObjectSpawn(Transform transform);
    }
}