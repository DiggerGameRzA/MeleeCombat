using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;
using Animators;
using Characters.Attack;
using Characters;

public class Attack : MonoBehaviour, IAttack
{
    bool combo;
    int currentCombo;
    IAnimatorFacade animator;
    Stats stats;
    IPlayer player;

    float lastAction = 0;
    float tempTime = 0;
    public Attack(IAnimatorFacade animator, IPlayer player)
    {
        this.animator = animator;
        this.player = player;
        stats = player.getStats();
    }

    private void Update()
    {
        if(Time.time - lastAction > stats.attackDelay)
        {
            resetCombo();
        }
    }

    public void lightAttack()
    {
        addCombo();
        animator.lightAttack(combo);
    }
    public void addCombo()
    {
        combo = true;
        currentCombo++;
        Debug.Log("added combo");
    }
    public void resetCombo()
    {
        combo = false;
        currentCombo = 0;
        animator.resetAttack();
    }
    public int getCurrentCombo()
    {
        return currentCombo;
    }
}
