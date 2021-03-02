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
    public void setInputs(float horInput, float verInput, float inputMagnitude)
    {
        characterAnimator.setHorInput(horInput);
        characterAnimator.setVerInput(verInput);
        characterAnimator.setInputMagnitude(inputMagnitude);
    }
    public void updateInputs()
    {
        setInputs(InputManager.getHorInput(), InputManager.getVerInput(), InputManager.getMagnitude());
    }
    public void lightAttack(bool combo)
    {

    }
    public void setRunning(bool running)
    {
        characterAnimator.setRunning(running);
    }
}
