using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RigMan.Target
{
    public class TargetManager : MonoBehaviour
    {
        [SerializeField] private TargetDamageSettings damageSettings;
        
        [SerializeField] private int targetLevel;
        
        public float damage;

        private void Awake()
        {
            damage = damageSettings.DamageList[targetLevel];
        }

        [Button]
        public void UpgradeTarget()
        {
            if(targetLevel == damageSettings.DamageList.Count - 1) return;
            
            targetLevel++;
            damage = damageSettings.DamageList[targetLevel];
        }
    }
}
