using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;
using Animators;
using Characters.Attack;
using Characters;

public class Attack : MonoBehaviour, IAttack
{
    int currentCombo;
    IAnimatorFacade animator;
    Stats stats;
    IPlayer player;

    float lastAction = 0;
    float tempTime = 0;
    private void Start()
    {
        stats = GetComponent<Stats>();
        player = GetComponent<IPlayer>();
        Invoke("getAnimator", 0.5f);
    }
    private void Update()
    {
        //When finished countdown delay reset combo
        if(Time.time - lastAction > stats.attackDelay)
        {
            resetCombo();
        }
    }

    public void lightAttack()
    {
        //When current combo is not equal to 3
        if (currentCombo != 3)
        {
            if (tempTime <= 0)
            {
                addCombo();
                animator.lightAttack(currentCombo);
                tempTime = 0.2f;                //Delay between action
            }
            lastAction = Time.time;             //Reset lastAction value
        }
    }

    //Increase current combo
    public void addCombo()
    {
        currentCombo++;
    }

    //Set current combo to 0
    public void resetCombo()
    {
        currentCombo = 0;
        animator.resetAttack();
    }

    //Return current combo value
    public int getCurrentCombo()
    {
        return currentCombo;
    }

    //Return animator
    void getAnimator()
    {
        animator = player.getAnimator();
    }

    //Countdown time
    public void countdownTime()
    {
        tempTime -= Time.deltaTime;
    }
}
