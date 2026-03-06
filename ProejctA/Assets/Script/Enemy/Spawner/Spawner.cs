using UnityEditor.Overlays;
using UnityEngine;

namespace ProjectA.Enemy
{
    public class Spawner : MonoBehaviour
    {
        public Transform[] m_spawnPoint;
        public EnemyData m_data;


        float timer;

        private void Start()
        {
            m_spawnPoint = GetComponentsInChildren<Transform>();
        }

        private void Update()
        {
            timer += Time.deltaTime;

            if (timer >= 2f)
            {
                timer -= 2f;
                Spawn();
            }
        }

        void Spawn()
        {

            GameObject enemy = GameManager.instance.enemyPool.Get(0);

            enemy.transform.position = m_spawnPoint[Random.Range(1, m_spawnPoint.Length)].position;

            if (enemy.GetComponent<Enemy>() != null)
            {
                Enemy enemyComp = enemy.GetComponent<Enemy>();
                enemyComp.Init(m_data);
            }
        }

    }
}

