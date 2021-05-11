using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{

    public GameObject[] trashPrefabs; //MüllPrefab im Inspector reinziehen
    public Transform[] spawnPoints; //Array aus den Spawnpoints, die ich gesetzt habe (auch im Inspector reinziehen)

    //festlegen einer mindest und höchst Wartezeit bis neues Objekt spawnt
    public float minDelay = .1f; 
    public float maxDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTrash()); //hiermit startet SpawnTrash() Methode
    }

    IEnumerator SpawnTrash()
    {
        while (true) //quasi immer, aber Achtung das nicht allein benutzen, sonst stürzt alles ab
        {
            float delay = Random.Range(minDelay, maxDelay); //der delay Wert setzt sich aus einer Random ausgesuchten Zahl zwischen unserem festgelegten min und maxDelay
            yield return new WaitForSeconds(delay); //die Zahl die bei delay rausgekommen ist, wird hier als Zeitangabe genutzt um zu warten

            int spawnIndex = Random.Range(0, spawnPoints.Length); //hier wird eine Random Zahl zwischen 0 und der Länge unseres spawnPoint Arrays(Liste) gezogen (wir haben z.B. 3 Spawnpoints, also wird eine Zahl zwischen 0 und 3 ausgegeben) diese ergibt die Variable spawnIndex
            Transform spawnPoint = spawnPoints[spawnIndex]; //aus unserer spawnPoints Liste/array wird das Element mit der Nummer, die im spawnIndex ermittelt wurde, als spawnPoint festgelegt

            GameObject spawnedTrash= Instantiate(trashPrefabs[Random.Range(0, trashPrefabs.Length)], spawnPoint.position, spawnPoint.rotation); //Es wird ein Objekt Instantiatet (wir nennen es spawnedTrash), das unser festgelegtes TrashPrefab als Vorbild nimmt, und die Position und Rotation des eben ermittelten spawnPoint übernimmt
            Destroy(spawnedTrash, 5f); //nach 5Sekunden wird unser Objekt 
        }
    }
}