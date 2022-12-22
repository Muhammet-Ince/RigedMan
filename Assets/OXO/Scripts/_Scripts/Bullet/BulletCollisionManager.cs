using System;
using RigMan.Interfaces;
using RigMan.Target;
using UnityEngine;

namespace RigMan.Bullet
{
    public class BulletCollisionManager : MonoBehaviour
    {
        private float _damage;
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.TryGetComponent(out OnDamageable onDamageable))
            {
                onDamageable.GetDamage(_damage);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out TargetManager targetManager))
            {
                _damage = targetManager.damage;
            }
        }
    }
}
