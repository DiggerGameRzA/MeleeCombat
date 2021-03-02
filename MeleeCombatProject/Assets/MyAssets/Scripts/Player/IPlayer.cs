using UnityEngine;
using Characters;
using Characters.Attack;
using Animators;

namespace Player
{
    public interface IPlayer
    {
        Rigidbody getRigidbody();
        Transform getTransform();
        Stats getStats();
        IAnimatorFacade getAnimator();
        IAttack getAttackManager();
        bool IsRunning { get; set; }
    }
}