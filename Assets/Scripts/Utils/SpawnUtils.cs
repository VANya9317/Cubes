﻿using UnityEngine;

namespace Scripts.Utils
{
    public class SpawnUtils
    {
        private const string ContainerName = "###SPAWNED###";

        public static GameObject Spawn(GameObject prefab, Vector2 position)
        {
            var container = GameObject.Find(ContainerName);
            if (container == null)
                    container = new GameObject(ContainerName);

            return Object.Instantiate(prefab, position, Quaternion.identity, container.transform);
        }
    }
}