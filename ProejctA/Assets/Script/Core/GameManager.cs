using ProjectA.Core;
using System.Xml;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Manager")]
    public PoolManager enemyPool;

    private void Awake()
    {
        instance = this;

        
    }
}
