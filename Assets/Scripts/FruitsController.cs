using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (((GameManager.Instance.player.transform.position.z)-(gameObject.transform.position.z)) >15)
            DeleteCombination();

    }
    private void DeleteCombination()
    {
        
            Destroy(gameObject);
    }
}
