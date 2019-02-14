using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Transform _object1;
    public Transform _object2;
    public Transform _object3;
    public Transform _object4;
    float x;
    float r = 10;
    float alpha = -90;
    // Start is called before the first frame update
    void Start()
    {
        this.x = r * Mathf.Sqrt(2 - 2 * Mathf.Cos(alpha));
    }

    // Update is called once per frame
    void Update()
    {
        float a = this.transform.position.x;
        float b = this.transform.position.z;
        _object1.transform.position = new Vector3(a, this.transform.position.y, r + b);
        //X’ = a + (x – a) cos al – (y-b) sin al
        float cosa = Mathf.Cos(alpha * (Mathf.PI / 180));
        float sina = Mathf.Sin(alpha * (Mathf.PI / 180));
        _object2.transform.position = new Vector3(
            a + (_object1.transform.position.x - a) * cosa - (_object1.transform.position.z - b) * sina,
            this.transform.position.y,
            b + (_object1.transform.position.x - a) * sina + (_object1.transform.position.z - b) * cosa);
        _object3.transform.position = new Vector3(
            a + (_object2.transform.position.x - a) * cosa - (_object2.transform.position.z - b) * sina,
            this.transform.position.y,
            b + (_object2.transform.position.x - a) * sina + (_object2.transform.position.z - b) * cosa);
        _object4.transform.position = new Vector3(
            a + (_object3.transform.position.x - a) * cosa - (_object3.transform.position.z - b) * sina,
            this.transform.position.y,
            b + (_object3.transform.position.x - a) * sina + (_object3.transform.position.z - b) * cosa);
    }
}
