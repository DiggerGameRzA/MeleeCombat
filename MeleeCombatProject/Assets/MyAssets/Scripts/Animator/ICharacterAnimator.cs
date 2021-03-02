using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Animators
{
    public interface ICharacterAnimator
    {
        Animator getAnimator();
        void setHorInput(float horInput);
        void setVerInput(float verInput);
        void setInputMagnitude(float inputMagnitude);
        void setRunning(bool running);
        void setComboAttack();
        void setLightAttack(int combo);
        void resetAttacking();
    }
}
