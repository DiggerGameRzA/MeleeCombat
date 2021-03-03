using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Animators;

public class CharacterAnimator : MonoBehaviour, ICharacterAnimator
{
    Animator anim;

    //Set all values in animator controller to shortcut
    int HorInput = Animator.StringToHash("horInput");
    int VerInput = Animator.StringToHash("verInput");
    int InputMagnitude = Animator.StringToHash("inputMagnitude");
    int IsRunning = Animator.StringToHash("isRunning");
    int LightAttack = Animator.StringToHash("lightAttack");
    private void OnEnable()
    {
        anim = GetComponent<Animator>();
    }
    public Animator getAnimator()
    {
        return anim;
    }

    //Set float of horInput in animator controller
    public void setHorInput(float horInput)
    {
        anim.SetFloat(HorInput, horInput);
    }

    //Set float of verInput in animator controller
    public void setVerInput(float verInput)
    {
        anim.SetFloat(VerInput, verInput);
    }

    //Set float of inputMagnitude in animator controller
    public void setInputMagnitude(float inputMagnitude)
    {
        anim.SetFloat(InputMagnitude, inputMagnitude);
    }

    //Set bool of isRunning in animator controller
    public void setRunning(bool running)
    {
        anim.SetBool(IsRunning, running);
    }

    //Set integer of lightAttack in animator controller
    public void setLightAttack(int combo)
    {
        anim.SetInteger(LightAttack, combo);
    }

    //Set integer of lightAttack in animator controller to 0
    public void resetAttacking()
    {
        anim.SetInteger(LightAttack, 0);
    }
}
