using UnityEngine;

namespace ProjectA.Enemy
{
    public class EnemyAttack : MonoBehaviour
    {
        Enemy m_Enemy;
        EnemyState m_State;
        EnemyMovement m_Movement;

        public LayerMask WallLayer;

        bool isAttack;

        public void Init(Enemy m_Enemy, EnemyState m_State)
        {
            this.m_Enemy = m_Enemy;
            this.m_State = m_State;

            m_Movement = GetComponent<EnemyMovement>();
        
        }

        private void FixedUpdate()
        {

            CheckWall();

        }

        void CheckWall()
        {
            RaycastHit2D hit = Physics2D.Raycast(
                transform.position,
                Vector2.down,
                (m_State.attackRange * 0.01f),
                WallLayer
            );

            Debug.DrawRay(
                transform.position,
                Vector2.down * (m_State.attackRange * 0.01f),
                Color.red
            );

            if (hit.collider != null)
            {
                if(!isAttack)
                {
                    StartAttack();

                }
            }
            else
            {
                if(isAttack)
                {
                    StopAttack();
                }
            }
        }

        void StartAttack()
        {
            Debug.Log("Start Attack!");
            isAttack = true;
            m_Enemy.m_Animation.PlayAttack();
            m_Movement.StopMove();
        }

        void StopAttack()
        {
            Debug.Log("Stop Attack!");
            isAttack = false;
            m_Movement.ResumeMove();
        }

        public void AttackHit()
        {
            GameManager.instance.m_Wall.TakeDamage(m_State.attackPower);
        }

        public void Shootting()
        {
            GameObject bullet = GameManager.instance.BulletPool.Get(m_Enemy.Data.bulletPrefab);

            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;

            bullet.GetComponent<EnemyBullet>().Init(m_State.attackPower, m_State.attackSpeed);
        }
    }
}

