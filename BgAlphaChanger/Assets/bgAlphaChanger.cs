using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgAlphaChanger : MonoBehaviour
{
    public SpriteRenderer blue;
    public SpriteRenderer orange;
    private float alphaLevel = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Color blueOrig = new Color(1f, 1f, 1f, 1f);
        Color blueFinal = new Color(1f, 1f, 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
       // alphaLevel -= (Time.deltaTime+0.3f);
       
      //  blue.color = new Color(1f, 1f, 1f, alphaLevel);
    }
}
