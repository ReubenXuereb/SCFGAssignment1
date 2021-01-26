using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationOfObstacles : MonoBehaviour
{

    //The AI has a coroutine that always scans ther Game World in order to keep up to date on what obsatcles there may be blocking its path. 
    //For this the obsatcles have a Obstacle Layer added to them so that when the AI scans it automaticaly knows that that gameobject is an obstacle.

    public List<Vector3> allObstaclePositions;
    [SerializeField] GameObject Obstacle;

    // Start is called before the first frame update
    void Start()
    {
        generateFiveObstacles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 randomGenerator()
    {
        Vector3 positions;
        int x, y;
        do
        {
            x = Random.Range(-49, 49);
            y = Random.Range(-49, 49);
            positions = new Vector3(x, y);
        }
        while (allObstaclePositions.Contains(positions));

        return positions;
    }

    private void generateFiveObstacles()
    {
        for (int i = 0; i <= 4; i++)
        {
            Vector3 positions = randomGenerator();
            allObstaclePositions.Add(positions);
            GameObject obstacles = Instantiate(Obstacle, positions, Quaternion.identity);
        }
    }
}
