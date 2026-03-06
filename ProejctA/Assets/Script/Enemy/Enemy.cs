using UnityEngine;

namespace ProjectA.Enemy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField]
        EnemyState m_State;

        [SerializeField]
        private EnemyData m_Data;

        EnemyMovement m_Movement;
        EnemyAttack m_Attack;

        public void Init(EnemyData data)
        {
            m_Data = data;
            m_State = new EnemyState
            {
                enemyName = data.enemyName,
                maxHealth = data.maxHealth,
                currentHealth = data.maxHealth,
                moveSpeed = data.moveSpeed,
                attackRange = data.attackRange,
                attackPower = data.attackPower,
                attackRate = data.attackRate,
                attackSpeed = data.attackSpeed,
            };

            m_Movement = GetComponent<EnemyMovement>();
            m_Movement.MovementInit(m_State);

            m_Attack = GetComponent<EnemyAttack>();
            m_Attack.AttackInit(m_State);

        }
    }
}

