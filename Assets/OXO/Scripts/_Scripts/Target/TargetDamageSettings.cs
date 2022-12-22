using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RigMan.Target
{
    [CreateAssetMenu(menuName = "RigMan/Target/DamageSettings")]
    public class TargetDamageSettings : ScriptableObject
    {
        [SerializeField] private List<float> damageList;
        public List<float> DamageList => damageList;
    }
}
