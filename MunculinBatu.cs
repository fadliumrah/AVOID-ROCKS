using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculinBatu : MonoBehaviour
{
    public GameObject batu;
    
    public float waktuMinimal, waktuMaximal;
    public float posisiMinimal, posisiMaximal;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MunculBatu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MunculBatu()
    {
        Instantiate(batu, transform.position+ Vector3.right*Random.Range(posisiMinimal,posisiMaximal), Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(waktuMinimal,waktuMaximal));
        StartCoroutine(MunculBatu());
    }
}
