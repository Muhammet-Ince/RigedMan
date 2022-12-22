using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using Redcode.Extensions;
using RigMan.Bullet;
using RigMan.Pooling;
using UnityEngine;

namespace RigMan.ShooterMachine
{
    public class ShooterMachineManager : MonoBehaviour
    {
        [SerializeField] private BulletSettings bulletSettings;
        [SerializeField] private BulletPoolDataHolder bulletDataHolder;
        [SerializeField] private Transform firePointTransform;

        [SerializeField] private List<GameObject> targetList;


        public void Shoot()
        {
            GameObject bullet = bulletDataHolder.bulletList.FirstOrDefault(m => !m.activeInHierarchy);

            if (bullet == null) return;

            bulletDataHolder.UseCase(bullet);
            bullet.transform.position = firePointTransform.position;

            Sequence bulletJumpSequence = bullet.transform.DOJump(targetList.GetRandomElement().transform.position,
                    bulletSettings.ShootForce, 1,
                    1 / bulletSettings.BulletSpeed)
                .SetEase(bulletSettings.shootEase);

            bulletJumpSequence.Append(DOVirtual.DelayedCall(bulletSettings.BulletBackDelay, () => bulletDataHolder.BackPoolCase(bullet)));

        }
    }
}