using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Characters;
using Characters.Movement;
using Characters.Attack;
using Player.MoveDirection;
using Animators;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Stats))]
    public class Player : MonoBehaviour, IPlayer
    {
        Stats stats;
        IMovement movement;
        IMovementDirection movementDirection;
        IAttack attackManager;
        Rigidbody rbd;

        IAnimatorFacade animator;
        public bool IsRunning { get; set; }

        //public Transform camPivot;
        //public Animator anim;
        //public float damageMultiply = 1f;
        //public Collider axeBoundingBox;
        private void Start()
        {
            //camPivot = GameObject.FindGameObjectWithTag("CamPivot").transform;
            //anim = GetComponent<Animator>();
            IsRunning = false;
            rbd = GetComponent<Rigidbody>();
            stats = GetComponent<Stats>();
            animator = new AnimatorFacade(GetComponent<ICharacterAnimator>());
            movement = new GroundMovement(this);
            attackManager = GetComponent<IAttack>();
            movementDirection = new ThridPersonCamera();
        }
        private void FixedUpdate()
        {
            if (IsRunning)
                movement.run(movementDirection.getDirection());
            else
                movement.walk(movementDirection.getDirection());
        }
        public Rigidbody getRigidbody()     //return Rigidbody
        {
            return rbd;
        }
        public Transform getTransform()     //return transform
        {
            return transform;
        }
        public Stats getStats()             //return stats
        {
            return stats;
        }
        public IAnimatorFacade getAnimator()    //return animator
        {
            return animator;
        }
        public IAttack getAttackManager()       //return attack manager
        {
            return attackManager;
        }

    }
}
