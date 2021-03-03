using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using General;
using Animators;

public class AnimatorFacade : IAnimatorFacade
{
    ICharacterAnimator characterAnimator;
    public AnimatorFacade(ICharacterAnimator characterAnimator)
    {
        this.characterAnimator = characterAnimator;
    }
    public Animator getAnimator()
    {
        return characterAnimator.getAnimator();
    }

    //Set all input values
    public void setInputs(float horInput, float verInput, float inputMagnitude)
    {
        characterAnimator.setHorInput(horInput);
        characterAnimator.setVerInput(verInput);
        characterAnimator.setInputMagnitude(inputMagnitude);
    }

    //Update input values
    public void updateInputs()
    {
        setInputs(InputManager.getHorInput(), InputManager.getVerInput(), InputManager.getMagnitude());
    }

    //Set integer of lightAttack in animator controller
    public void lightAttack(int combo)
    {
        characterAnimator.setLightAttack(combo);
    }

    //Set bool of isRunning in animator controller
    public void setRunning(bool running)
    {
        characterAnimator.setRunning(running);
    }

    //Set integer of lightAttack in animator controller to 0
    public void resetAttack()
    {
        characterAnimator.resetAttacking();
    }
}
