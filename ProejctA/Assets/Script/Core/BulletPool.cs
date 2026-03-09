using System.Collections.Generic;
using UnityEngine;


namespace ProjectA.Core
{
    public class BulletPool : MonoBehaviour
    {
        Dictionary<GameObject, Queue<GameObject>> pool
       = new Dictionary<GameObject, Queue<GameObject>>();

        public GameObject Get(GameObject prefab)
        {
            if (!pool.ContainsKey(prefab))
            {
                pool[prefab] = new Queue<GameObject>();
            }

            if(pool[prefab].Count > 0)
            {
                GameObject obj = pool[prefab].Dequeue();
                obj.SetActive(true);
                return obj;
            }

            return Instantiate(prefab);
        }

        public void Return(GameObject prefab, GameObject obj)
        {
            obj.SetActive(false);
            pool[prefab].Enqueue(obj);
        }
    }
}

