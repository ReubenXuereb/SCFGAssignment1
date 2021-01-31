using System.Collections;
using System.Collections.Generic;
using UnityEngine;




//TASK 2 2nd bullet
//A * pathfinding pro has a feature called Local Avoidance. It is a feature were it handles agents at different floors/layers to not collide with each other




public class GenerattionOfAI : MonoBehaviour
{



    public List<Vector3> allObstaclePositions;
    [SerializeField] GameObject AI;

    // Start is called before the first frame update
    void Start()
    {
        generateTenAI();
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

    public void generateTenAI()
    {
        for (int i = 0; i <= 9; i++)
        {
            Vector3 positions = randomGenerator();
            allObstaclePositions.Add(positions);
            GameObject obstacles = Instantiate(AI, positions, Quaternion.identity);
        }
    }
}
