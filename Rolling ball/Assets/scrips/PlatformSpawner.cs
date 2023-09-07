using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    public GameObject diamonds;
    Vector3 lastpos;
    float size;
    public bool gameOver;
    void Start()
    {
        lastpos=platform.transform.position;
        size=platform.transform.localScale.x;
        for(int i=1;i<=15;i++)
        {
            SpawnPlatform();
        }
        
    }
    public void StartSpawn()
    {
        InvokeRepeating("SpawnPlatform",0.1f,0.2f);
    }
    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.gameOver==true)
        {
            CancelInvoke("SpawnPlatform");
        }
    }
    void SpawnPlatform()
    {
        int rand= Random.Range(0,6);
        if(rand<3)
        {
            Spawnx();
        }
        else if(rand>3)
        {
            Spawnz();
        }
    }
    void Spawnx()
    {
        Vector3 pos =lastpos;
        pos.x +=size;
        lastpos=pos;
        Instantiate(platform, pos, Quaternion.identity);

        int rand=Random.Range(0,4);
        if(rand<1)
        {
            Instantiate(diamonds, new Vector3(pos.x,pos.y + 1,pos.z), diamonds.transform.rotation);
        }
    }
    void Spawnz()
    {
        Vector3 pos =lastpos;
        pos.z +=size;
        lastpos=pos;
        Instantiate(platform, pos, Quaternion.identity);

        int rand=Random.Range(0,4);
        if(rand<1)
        {
            Instantiate(diamonds,  new Vector3(pos.x,pos.y + 1,pos.z), diamonds.transform.rotation);
        }
    }
}
