using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // to have access to text

public class BlockSpawner : MonoBehaviour
{
    public GameObject blockPrefab;
    public Text scoreText;
    int currentScore = 0;
    [HideInInspector]
    public bool hasLost;

    public void SpawnBlock()
    {
       
            Invoke("InstantiateBlock", 1.5f);
       
    }

    void InstantiateBlock() 
    {
        if (!hasLost)
        {
            float xSpawnPosition = Random.Range(-8, 8);
            Vector3 spawnPosition = new Vector3(xSpawnPosition, 5.5f, 0);
            Instantiate(blockPrefab, spawnPosition, Quaternion.identity);
            currentScore += 1;
            scoreText.text = currentScore.ToString(); // accessing text component
        }
        
    }
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
