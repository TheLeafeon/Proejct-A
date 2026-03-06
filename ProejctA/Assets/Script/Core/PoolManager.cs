using ProjectA.Enemy;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectA.Core
{
    public class PoolManager : MonoBehaviour
    {
        //우선은 몬스터 종류가 여럿이 될 수 있으므로 일단 퉁
        public GameObject[] prefabs;

        List<GameObject>[] pools;

        private void Awake()
        {
            pools = new List<GameObject>[prefabs.Length];

            for (int idx = 0; idx < pools.Length; idx++)
            {
                pools[idx] = new List<GameObject>();
            }
        }

        public GameObject Get(int idx)
        {
            GameObject select = null;

            foreach (GameObject item in pools[idx])
            {
                if (!item.activeSelf)
                {
                    select = item;

                    select.SetActive(true);
                    break;
                }
            }

            if (select == null)
            {
                select = Instantiate(prefabs[idx], transform);
                pools[idx].Add(select);
            }


            return select;
        }
    }
}

