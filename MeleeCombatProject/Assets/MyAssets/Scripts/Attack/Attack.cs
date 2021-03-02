using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;
using Animators;
using Characters.Attack;
using Characters;

public class Attack : MonoBehaviour, IAttack
{
    [SerializeField] int currentCombo;
    IAnimatorFacade animator;
    Stats stats;
    IPlayer player;

    [SerializeField] float lastAction = 0;
    [SerializeField] float tempTime = 0;
    private void Start()
    {
        stats = GetComponent<Stats>();
        player = GetComponent<IPlayer>();
        Invoke("getAnimator", 0.5f);
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
        if (currentCombo != 3)
        {
            if (tempTime <= 0)
            {
                addCombo();
                animator.lightAttack(currentCombo);
                tempTime = 0.2f;
            }
            lastAction = Time.time;
        }
    }
    public void addCombo()
    {
        currentCombo++;
    }
    public void resetCombo()
    {
        currentCombo = 0;
        animator.resetAttack();
    }
    public int getCurrentCombo()
    {
        return currentCombo;
    }
    void getAnimator()
    {
        animator = player.getAnimator();
    }
    public void countdownTime()
    {
        tempTime -= Time.deltaTime;
    }
}
