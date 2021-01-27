using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDia : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-4, 4), 0.25f, Random.Range(-4, 4));
            Dia dia = Instantiate(Resources.Load<Dia>("吃豆豆/Dia"), pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
