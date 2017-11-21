using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjectScript : MonoBehaviour
{

    // Prefaby do wystąpienia
    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5, prefab6, prefab7, prefab8, prefab9, prefab10, prefab11, prefab12, prefab13, prefab14, prefab15, prefab16;

    // Spawn rate
    public float spawnRate = 2f;
    
    // Zmienna ustawiająca kolejny czas spawnu
    private float nextSpawn = 0f;

    // Zmienna zawierająca losowy numer
    private int whatToSpawn;

    void Update ()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 17);
            Debug.Log(whatToSpawn);

            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(prefab1, transform.position + new Vector3(11f, 11f, 11f), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
                case 2:
                    Instantiate(prefab2, transform.position + new Vector3(0, 1.1f, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
                case 3:
                    Instantiate(prefab3, transform.position + new Vector3(0, 1.1f, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
                case 4:
                    Instantiate(prefab4, transform.position + new Vector3(0, 1.1f, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
                case 5:
                    Instantiate(prefab5, transform.position + new Vector3(0, 1.1f, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
                case 6:
                    Instantiate(prefab6, transform.position + new Vector3(0, 1.1f, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
                case 7:
                    Instantiate(prefab7, transform.position + new Vector3(0, 1.1f, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
                case 8:
                    Instantiate(prefab8, transform.position + new Vector3(0, 1.1f, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
                case 9:
                    Instantiate(prefab9, transform.position + new Vector3(0, 1.1f, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
                case 10:
                    Instantiate(prefab10, transform.position + new Vector3(0, 1.1f, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
                case 11:
                    Instantiate(prefab11, transform.position + new Vector3(0, 1.1f, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
                case 12:
                    Instantiate(prefab12, transform.position + new Vector3(0, 1.1f, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
                case 13:
                    Instantiate(prefab13, transform.position + new Vector3(0, 1.1f, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
                case 14:
                    Instantiate(prefab14, transform.position + new Vector3(0, 1.1f, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
                case 15:
                    Instantiate(prefab15, transform.position + new Vector3(0, 1.1f, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
                case 16:
                    Instantiate(prefab16, transform.position + new Vector3(0, 1.1f, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                    break;
            }

            nextSpawn = Time.time + spawnRate;

        }


    }
}
