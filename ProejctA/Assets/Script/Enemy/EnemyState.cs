using System;
using UnityEngine;

namespace ProjectA.Enemy
{
    [Serializable]
    public class EnemyState
    {
        [Header("# 몬스터 기본 정보")]
        public string enemyName;

        [Header("# 몬스터 체력 정보")]
        public float maxHealth;
        public float currentHealth;

        [Header("# 몬스터 이동 정보")]
        public float moveSpeed;

        [Header("# 몬스터 공격 정보")]
        public float attackRange;
        public float attackPower;
        public float attackRate;
        public float attackSpeed;


    }

}

