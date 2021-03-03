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
            rbd.velocity = direction * stats.walkSpeed; //Set velocity equal to player's walk speed

            rotate(direction);                          //Rotate player
            animator.updateInputs();                    //Update all input values
            animator.setRunning(false);                 //Stop play run animation
        }
        public void run(Vector3 direction)     //method to make character run
        {
            rbd.velocity = direction * stats.runSpeed;  //Set velocity equal to player's walk speed

            rotate(direction);                          //Rotate player
            animator.updateInputs();                    //Update all input values
            animator.setRunning(true);                  //Play run animation
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
