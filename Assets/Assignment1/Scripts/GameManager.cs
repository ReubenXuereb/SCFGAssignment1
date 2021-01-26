using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Vector3> allObstaclePositions;
    //[SerializeField] GameObject AI;
    [SerializeField] GameObject Obstacle;
    [SerializeField] GameObject AI;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Scan()
    {
        GameObject.Find("AStarGrid").GetComponent<AstarPath>().Scan();
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

    public void addObstacles()
    {
        print("working");
        Vector3 positions = randomGenerator();
        allObstaclePositions.Add(positions);
        GameObject obstacles = Instantiate(Obstacle, positions, Quaternion.identity);
    }

    public void addAI()
    {
        
        Vector3 positions = randomGenerator();
        allObstaclePositions.Add(positions);
        GameObject obstacles = Instantiate(AI, positions, Quaternion.identity);
    }

    public void startAI()
    {
        GameObject[] artificial = GameObject.FindGameObjectsWithTag("AI");
    
        foreach(GameObject ai in artificial)
        {
            ai.GetComponent<customAIMoveScriptGrid>().enabled = true;
        }
    }
}
