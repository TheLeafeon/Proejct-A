using UnityEngine;

namespace ProjectA.Enemy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField]Transform graphicsRoot;

        [SerializeField] EnemyData m_Data;

        [SerializeField] EnemyState m_State;

        public EnemyMovement m_Movement { get; private set; }
        public EnemyAttack m_Attack { get; private set; }
        public EnemyAnimation m_Animation { get; private set; }


        private GameObject graphics;

        public EnemyData Data => m_Data;

        public void Init(EnemyData data)
        {
            graphics = Instantiate(data.graphicsPrefab, graphicsRoot);

            m_Animation = graphics.GetComponent<EnemyAnimation>();

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


            if (transform.position.x > 0)
            {
                Vector3 scale = graphicsRoot.localScale;
                scale.x = -1;
                graphicsRoot.localScale = scale;
            }

            m_Movement = GetComponent<EnemyMovement>();
            m_Attack = GetComponent<EnemyAttack>();

            m_Movement.Init(this, m_State);
            m_Attack.Init(this, m_State);
            m_Animation.Init(this);

        }
    }
}

