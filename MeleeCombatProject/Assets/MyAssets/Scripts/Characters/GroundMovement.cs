using UnityEngine;
using Player;
using Animators;

namespace Characters.Movement
{
    public class GroundMovement : IMovement
    {
        IPlayer character;
        Transform transform;
        Rigidbody rbd;
        Stats stats;
        IAnimatorFacade animator;
        public GroundMovement(IPlayer character)    //setup all values
        {
            this.character = character;
            transform = character.getTransform();
            rbd = character.getRigidbody();
            stats = character.getStats();
            animator = character.getAnimator();
        }

        public void walk(Vector3 direction)     //method to make character walk
        {
            rbd.velocity = direction * stats.walkSpeed;

            rotate(direction);
            animator.updateInputs();
            animator.setRunning(false);
        }
        public void run(Vector3 direction)     //method to make character run
        {
            rbd.velocity = direction * stats.runSpeed;

            rotate(direction);
            animator.updateInputs();
            animator.setRunning(true);
        }
        void rotate(Vector3 direction)          //method for rotating character to camera direction
        {
            if (direction != Vector3.zero)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), stats.rotationSpeed);
            }
        }

    }
}
