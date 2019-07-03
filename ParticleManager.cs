using System;
using UnityEngine;
namespace Assets.Scripts
{
    public class ParticleManager: MonoBehaviour
    {
        
        public ParticleEffect[] particles;

        public void PlayEffectFromTransform(string name, Transform _transform)
        {
            var particle = Array.Find(particles, particles => particles.name == name);
            Instantiate(particle.particle, _transform.position, Quaternion.identity);
        }
        
        public void PlayEffect(string name)
        {
            var particle = Array.Find(particles, particles => particles.name == name);
            if (particle.InstantiatPosition != null)
                Instantiate(particle.particle, particle.InstantiatPosition.position, Quaternion.identity);
            else
            {
                throw new Exception("Transform not found for particle");
            }
        }
    }
}