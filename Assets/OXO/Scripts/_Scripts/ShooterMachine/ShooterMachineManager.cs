using System.Collections.Generic;
using DG.Tweening;
using Redcode.Extensions;
using RigMan.Bullet;
using UnityEngine;

namespace RigMan.ShooterMachine
{
    public class ShooterMachineManager : MonoBehaviour
    {
        [SerializeField] private BulletSettings bulletSettings;
        [SerializeField] private Transform firePointTransform;
        
        
        [SerializeField] private List<GameObject> targetList;
        
        public void Shoot()
        {
            GameObject bullet = Instantiate(bulletSettings.BulletPrefab, firePointTransform.position, Quaternion.identity);

            bullet.transform.DOJump(targetList.GetRandomElement().transform.position, bulletSettings.ShootForce, 1,
                    1 / bulletSettings.BulletSpeed)
                .SetEase(bulletSettings.shootEase);
        }
    }
}
