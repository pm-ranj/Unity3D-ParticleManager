using UnityEngine;

namespace Assets.Scripts
{
    [System.Serializable]
    public class ParticleEffect
    {
        public Transform InstantiatPosition;
        public ParticleSystem particle;
        public string name;
        
    }
}