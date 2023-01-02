using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhettosFirearmSDKv2
{
    public class BoltBase : MonoBehaviour
    {
        public FirearmBase firearm;
        public bool fireOnTriggerPress = true;
        [HideInInspector]
        public BoltState state = BoltState.Locked;
        public BoltState laststate = BoltState.Locked;

        public virtual void TryFire()
        {
            
        }

        public delegate void OnReachedEndDelegate();
        public event OnReachedEndDelegate OnReachedEndEvent;

        public delegate void OnLockedDelegate();
        public event OnLockedDelegate OnLockedEvent;

        public enum BoltState
        {
            Locked,
            Front,
            Moving,
            Back,
            LockedBack
        }
    }
}
