using System;
using RigMan.Bullet;
using UnityEngine;

namespace RigMan.Pooling
{
    public class BulletPooling : MonoBehaviour
    {
        [SerializeField] private BulletSettings bulletSettings;
        [SerializeField] private BulletPoolDataHolder bulletDataHolder;
        
        [SerializeField] private int bulletPoolSize;

        private void Awake()
        {
            BulletPoolInitialize();
        }

        private void BulletPoolInitialize()
        {
            for (int i = 0; i < bulletPoolSize; i++)
            {
                GameObject bullet = Instantiate(bulletSettings.BulletPrefab, transform.position, Quaternion.identity);
                bulletDataHolder.bulletList.Add(bullet);
                bullet.SetActive(false);
            }
        }

        private void OnDisable()
        {
            bulletDataHolder.bulletList.Clear();
        }
    }
}
