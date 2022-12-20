using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RigMan.Pooling
{
    [CreateAssetMenu(menuName = "RigMan/Bullet/BulletPoolDataHolder")]
    public class BulletPoolDataHolder : ScriptableObject
    {
        public List<GameObject> bulletList;
    }
}
