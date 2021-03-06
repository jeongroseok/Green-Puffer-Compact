﻿using UnityEngine;
using System.Collections;

namespace GreenPuffer.Misc
{
    public class ParticleSystemAutoDestroy : MonoBehaviour
    {
        private new ParticleSystem particleSystem;

        public void Start()
        {
            particleSystem = GetComponent<ParticleSystem>();
        }

        public void Update()
        {
            if (!particleSystem.IsAlive())
                Destroy(gameObject);
        }
    }
}