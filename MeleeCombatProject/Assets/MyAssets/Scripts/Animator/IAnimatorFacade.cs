using UnityEngine;

namespace Animators
{
    public interface IAnimatorFacade
    {
        Animator getAnimator();
        void updateInputs();
        void setInputs(float horInput, float verInput, float inputMagnitude);
        void setRunning(bool running);
        void resetAttack();
        void lightAttack(bool combo);
    }
}
