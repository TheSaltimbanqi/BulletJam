using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarScript : MonoBehaviour
{
    public float radio = 5f;
    public int numObjects = 10;
    public float distancia = 1.5f;
    public GameObject prefab;
    List<GameObject> enemiesInstantiated = new List<GameObject>();

    void Start()
    {
        Vector3 center = transform.position;
        for (int i = 0; i < numObjects; i++)
        {
            Vector3 pos = RandomCircle(center, radio);
            //Quaternion rot = Quaternion.FromToRotation(Vector3.forward, center - pos);
            while (isNear(pos))
            {
                pos = RandomCircle(center, radio);
            }
            enemiesInstantiated.Add(Instantiate(prefab, pos, Quaternion.Euler(Vector3.zero)));
        }
    }


    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }

    bool isNear(Vector3 posi)
    {
        if(enemiesInstantiated.Count == 0)
        {
            return false;
        }
        else
        {
            foreach (GameObject prefabposi in enemiesInstantiated)
            {
                float dist = Vector3.Distance(prefabposi.transform.position, posi);
                if (dist < distancia)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
