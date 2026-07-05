using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject stone;

    public float maxX;

    public Transform spawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnStone", 0.5f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnStone()
    {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range(-maxX, maxX);

        Instantiate(stone, spawnPos, Quaternion.identity);
    }
}
