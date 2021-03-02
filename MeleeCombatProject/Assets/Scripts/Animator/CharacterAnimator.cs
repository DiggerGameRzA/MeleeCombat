﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Animators;

public class CharacterAnimator : MonoBehaviour, ICharacterAnimator
{
    Animator anim;
    int HorInput = Animator.StringToHash("horInput");
    int VerInput = Animator.StringToHash("verInput");
    int InputMagnitude = Animator.StringToHash("inputMagnitude");
    int IsRunning = Animator.StringToHash("isRunning");
    private void OnEnable()
    {
        anim = GetComponent<Animator>();
    }
    public Animator getAnimator()
    {
        return anim;
    }
    public void setHorInput(float horInput)
    {
        anim.SetFloat(HorInput, horInput);
    }
    public void setVerInput(float verInput)
    {
        anim.SetFloat(VerInput, verInput);
    }
    public void setInputMagnitude(float inputMagnitude)
    {
        anim.SetFloat(InputMagnitude, inputMagnitude);
    }
    public void setRunning(bool running)
    {
        anim.SetBool(IsRunning, running);
    }
}
