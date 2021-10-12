using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxObject : MonoBehaviour
{
    public GameObject Kotak;
    public float xMin, xMax;
    public float yMin, yMax;
    public float randomX, randomY;

    // Function untuk melakukan Spawn Kotak secara Random
    void SpawnBox()
    {
        int count = Random.Range(5, 10);

        for (int i = 0; i < count; i++)
        {
            randomX = Random.Range(xMin, xMax);
            randomY = Random.Range(yMin, yMax);
            Instantiate(Kotak, new Vector2(randomX, randomY), Quaternion.identity);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        SpawnBox();
    }

}
