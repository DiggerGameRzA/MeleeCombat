using UnityEngine;
using Characters;
using Animators;

namespace Player
{
    public interface IPlayer
    {
        Rigidbody getRigidbody();
        Transform getTransform();
        Stats getStats();
        IAnimatorFacade getAnimator();
        bool IsRunning { get; set; }
    }
}