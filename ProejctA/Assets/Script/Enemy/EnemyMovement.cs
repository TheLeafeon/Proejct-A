using UnityEngine;

namespace ProjectA.Enemy
{
    public class EnemyMovement : MonoBehaviour
    {
        Enemy m_Enemy;
        EnemyState m_State;

        bool isStop;

        public void Init(Enemy m_Enemy, EnemyState m_State)
        {
            this.m_Enemy = m_Enemy;
            this.m_State = m_State;
        }

        private void FixedUpdate()
        {
            if (isStop) return;

            Move();
        }

        void Move()
        {
            transform.position += Vector3.down * m_State.moveSpeed * Time.deltaTime;

            m_Enemy.m_Animation.PlayMove();
        }

        public void StopMove()
        {
            isStop = true;
        }
        public void ResumeMove()
        {
            isStop = false;
            m_Enemy.m_Animation.PlayMove();
        }
    }
}

