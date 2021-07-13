using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] monsters;

    private GameObject spawnedMob;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    IEnumerator SpawnMonsters()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(1,5));

            randomIndex = Random.Range(0, monsters.Length);

            randomSide = Random.Range(0,2);

            spawnedMob = Instantiate(monsters[randomIndex]);

            if(randomSide == 0)
            {
                //left side

                spawnedMob.transform.position = leftPos.transform.position;
                spawnedMob.GetComponent<Monster>().speed = Random.Range(4,10);
            }

            else
            {
                //right side
                spawnedMob.transform.position = rightPos.transform.position;
                spawnedMob.GetComponent<Monster>().speed = -Random.Range(4,10);
                spawnedMob.GetComponent<SpriteRenderer>().flipX = true;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
