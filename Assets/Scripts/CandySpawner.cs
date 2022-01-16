using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField]
    float Spawnerx;
     public GameObject[] Candies;
    [SerializeField]
    float interval;

    public static CandySpawner instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCandy()
    {
        int randomspawn = Random.Range(0, Candies.Length);
        float random = Random.Range(-Spawnerx, Spawnerx);
        Vector3 randompos = new Vector3(random, transform.position.y, transform.position.z);
        Instantiate(Candies[randomspawn], randompos, transform.rotation);
    }

    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            SpawnCandy();
            yield return new WaitForSeconds(interval);
        }
    }

    public void StartSpawning()
    {
        StartCoroutine("SpawnCandies");
    }

    public void StopSpawning()
    {
        StopCoroutine("SpawnCandies");   
    }
}
