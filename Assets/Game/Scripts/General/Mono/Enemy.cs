using System;
using UnityEngine;


public class Enemy : Character
{
    [SerializeField] EnemyStats enemyStats;
    public override CharacterStats Stats => enemyStats;
    [SerializeField] DisplayController displayController;
    public override DisplayController DisplayController => displayController;

}
