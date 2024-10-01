using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject[] obstacles; // Array yang akan diisi dengan gameobject obstacle
    [SerializeField] private float spawnTime; // Waktu obstacle untuk spawn
    [SerializeField] private Transform spawnLocation; // Lokasi spawn obstacle, akan mengambil dari posisi gameobject Spawn Location
    private float timer; // Variabel untuk menampung nilai time

    void Update()
    {
        // Mengisi variabel timer dengan waktu sekarang 
        timer += Time.deltaTime;

        // Mengecek apakah timer >= spawnTime
        if (timer >= spawnTime)
        {
            SpawnObstacle();
            timer = 0;
        }
    }

    void SpawnObstacle()
    {
        // Membuat dan mengisikan variabel index dengan angka random dari 0 sampai berapa banyak obstacle yang ada di array (contoh 0 sampai 3)
        int index = Random.Range(0, obstacles.Length);
        // Membuat dan mengisikan variabel obstacle dengan instantiate (membuat objek baru dari obstacles[index])
        GameObject obstacle = Instantiate(obstacles[index]);

        // Tentukan posisi x dan z obstacle berdasarkan posisi spawner (di depan Player)
        float spawnX = spawnLocation.transform.position.x;
        float spawnZ = spawnLocation.transform.position.z;
        float spawnY = 0.5f; // Default posisi y

        // Atur posisi obstacle
        obstacle.transform.position = new Vector3(spawnX, spawnY, spawnZ);
    }
}
