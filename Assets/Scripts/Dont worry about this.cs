using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    private Transform my_transform;
    public float hah;
    int[] bruh = {1,2,3};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerable fun(){

        yield return new WaitForSeconds(2.0f);
    }

    public void func(string x){

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        my_transform = GetComponent<Transform>();

        Vector2 pos = my_transform.position;
        Vector2 pos2 = my_transform.position;
      
        pos.x += h * Time.deltaTime;
        pos.y += v * Time.deltaTime;
       // ArrayList list = new ArrayList();
        //list.Add(5);
        //list.Add("Hi");
        my_transform.position = pos;

        /*Dictionary<string, string> map = new Dictionary<string, string>();
        map.Add("hi","bye");
        foreach(var i in list)
        {
            Debug.Log(i);
        
        }*/
    }
}
