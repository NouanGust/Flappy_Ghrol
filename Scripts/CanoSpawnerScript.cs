using UnityEngine;

public class CanoSpawnerScript : MonoBehaviour
{
    [SerializeField] private float maxTime = 2.5f;
    [SerializeField] private float heightRange = 0.45f;
    [SerializeField] private GameObject canos;

    private float timer;

    void Start()
    {
        CriarCano();
    }


    void Update()
    {
        if (timer > maxTime)
        {
            CriarCano();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void CriarCano()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject cano = Instantiate(canos, spawnPos, Quaternion.identity);

        Destroy(cano, 10f);
    }
}
