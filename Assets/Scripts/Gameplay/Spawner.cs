using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public string Round;

    public Transform TargetSpawn1;
    public Transform TargetSpawn2;
    public Transform TargetSpawn3;
    public Transform TargetSpawn4;
    public Transform TargetSpawn5;
    public Transform TargetSpawn6;
    public Transform TargetSpawn7;
    public Transform TargetSpawn8;

    public GameObject blueTargetPrefab;
    public GameObject greenTargetPrefab;
    public GameObject redTargetPrefab;
    public GameObject violetTargetPrefab;
    public GameObject yellowTargetPrefab;

    private GameObject cloneBlock;

    private Transform[] targetSpawns = new Transform[8];
    private GameObject[] targetPrefabs = new GameObject[5];

    // Start is called before the first frame update
    void Start()
    {
        targetSpawns[0] = TargetSpawn1;
        targetSpawns[1] = TargetSpawn2;
        targetSpawns[2] = TargetSpawn3;
        targetSpawns[3] = TargetSpawn4;
        targetSpawns[4] = TargetSpawn5;
        targetSpawns[5] = TargetSpawn6;
        targetSpawns[6] = TargetSpawn7;
        targetSpawns[7] = TargetSpawn8;

        targetPrefabs[0] = blueTargetPrefab;
        targetPrefabs[1] = greenTargetPrefab;
        targetPrefabs[2] = redTargetPrefab;
        targetPrefabs[3] = violetTargetPrefab;
        targetPrefabs[4] = yellowTargetPrefab;

        spawnBlock(blueTargetPrefab, TargetSpawn1);
    }

    // Update is called once per frame
    private bool debounce = false;
    void Update()
    {
        if (Round == "Round1")
            doRound1();
        else if (Round == "Round2")
            doRound2();
        else
            doRound3();
    }

    private void spawnBlock(GameObject TargetBlockPrefab, Transform SpawnPoint)
    {
        cloneBlock = Instantiate(TargetBlockPrefab, SpawnPoint.position, Quaternion.identity);
    }

    private void doRound1() // Easy Round
    {
        int randomIndex_Spawn = Random.Range(0, targetSpawns.Length);
        Transform randomTargetSpawn = targetSpawns[randomIndex_Spawn];
        int randomIndex_Target = Random.Range(0, targetPrefabs.Length-3); // Only use the first two easy blocks (Blue and Green)
        GameObject randomTargetBlock = targetPrefabs[randomIndex_Target];

        if (cloneBlock.IsDestroyed())
        {
            spawnBlock(randomTargetBlock, randomTargetSpawn);
        }
    }

    private void doRound2() // Normal Round
    {
        int randomIndex_Spawn = Random.Range(0, targetSpawns.Length);
        Transform randomTargetSpawn = targetSpawns[randomIndex_Spawn];
        int randomIndex_Target = Random.Range(0, targetPrefabs.Length-2); // Only use the first three easy blocks (Blue, Green, and Red)
        GameObject randomTargetBlock = targetPrefabs[randomIndex_Target];

        if (cloneBlock.IsDestroyed())
        {
            spawnBlock(randomTargetBlock, randomTargetSpawn);
        }
    }

    private void doRound3() // Hard Round
    {
        int randomIndex_Spawn = Random.Range(0, targetSpawns.Length);
        Transform randomTargetSpawn = targetSpawns[randomIndex_Spawn];
        int randomIndex_Target = Random.Range(0, targetPrefabs.Length); // Use all blocks
        GameObject randomTargetBlock = targetPrefabs[randomIndex_Target];

        if (cloneBlock.IsDestroyed())
        {
            spawnBlock(randomTargetBlock, randomTargetSpawn);
        }
    }
}
