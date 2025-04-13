using UnityEngine;

public class TreeSpawnScript : MonoBehaviour
{

    public GameObject tree;
    public float spawRate = 2;
    private float timer = 0;
    public float heightOffset = 6;

    void Start()
    {
        spawnTree();
    }

    void Update()
    {
        if (timer < spawRate)
        {
            timer += Time.deltaTime;
        } else
        {
            spawnTree();
            timer = 0;
        }
    }
    void spawnTree()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(tree, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
