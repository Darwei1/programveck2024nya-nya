using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject CharacterPrefab;
    public GameObject latestCharacter;

    // Start is called before the first frame update
    void Start()
    {
        latestCharacter = GameObject.Find("Capsule");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Spawn()
    {
        latestCharacter = Instantiate(CharacterPrefab, new Vector3(0, 0.2f, 0), Quaternion.identity);
    }

    public void spawnTimer()
    {
        Invoke("Animation2", 0);
        Invoke("Spawn", 5);
    }
    public void Animation2()
    {
        latestCharacter.GetComponent<Animator>().Play("animation2");
    }

}
