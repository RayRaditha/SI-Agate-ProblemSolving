using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxObject : MonoBehaviour
{
    public GameObject Kotak;
    public float xMin, xMax;
    public float yMin, yMax;
    public float randomX, randomY;
    public static float prevX, prevY = 0;

    // Function untuk melakukan Spawn Kotak secara Random
    void SpawnBox()
    {
        int count = Random.Range(5, 10);

        for (int i = 0; i < count; i++)
        {
            float randomX = Random.Range(xMin, xMax);
            float randomY = Random.Range(yMin, yMax);

            if (prevX < 0 && randomX < 0)
            {
                randomX = Mathf.Abs(randomX);
                prevX = 0 - randomX;
                prevY = randomY;
            }

            if (prevY < 0 && randomY < 0)
            {
                randomY = Mathf.Abs(randomY);
                prevX = randomX;
                prevY = 0 - randomY;
            }

            if (prevY > 0 && randomY > 0)
            {
                randomY = 0 - randomY;
                prevX = randomX;
                prevY = Mathf.Abs(randomY);
            }

            if (prevX > 0 && randomX > 0)
            {
                randomX = 0 - randomX;
                prevX = Mathf.Abs(randomX);
                prevY = randomY;
            }
            Instantiate(Kotak, new Vector2(randomX, randomY), Quaternion.identity);
        }

    }

    IEnumerator SpawnKotak()
    {
        while (true)
        {
            if (transform.childCount < 10)
            {
                float randomX = Random.Range(xMin, xMax);
                float randomY = Random.Range(yMin, yMax);

                Instantiate(Kotak, new Vector2(randomX, randomY), Quaternion.identity);

            }
            yield return new WaitForSeconds(3);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SpawnBox();
        StartCoroutine(SpawnKotak());
    }

}
