using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    Vector2 newPosition;
    float startTime = 2f;
    private void Start()
    {
        newPosition.x = transform.position.x;
        newPosition.y = Random.Range(-2f, 2);
        Instantiate(pipe, newPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime < 0) {

            newPosition.x = transform.position.x;
            newPosition.y = Random.Range(-2f, 2);

            Instantiate(pipe, newPosition, Quaternion.identity);
            startTime = 2f;
        }
        else {
            startTime -= 1f * Time.deltaTime;
        }
    }
}
