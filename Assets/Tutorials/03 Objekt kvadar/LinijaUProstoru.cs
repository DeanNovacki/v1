using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinijaUProstoru : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Material mat;

    void OnPostRender() {
       // if (!mat) {
       //     Debug.LogError("Please Assign a material on the inspector");
       //     return;
       //  }

        GL.PushMatrix();
        // GL.LoadProjectionMatrix(GetComponent<camera>().projectionMatrix);
        GL.LoadOrtho();

        GL.Begin(GL.LINES);
            // LineMat.SetPass(0);
            GL.Color(new Color(1f, 0f, 0f, 1f));
            GL.Vertex3(0f, 0f, 0f);
            GL.Vertex3(0.1f, 0.1f, 0.1f);
        GL.End();
        GL.PopMatrix();
    }
}
