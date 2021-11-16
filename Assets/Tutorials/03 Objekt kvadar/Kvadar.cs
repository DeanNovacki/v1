using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Kvadar {

    public int kvID;
    public string kvName;
    public float kvX;
    public float kvY;
    public float kvZ;
    public float kvVisina;
    public float kvSirina;
    public float kvDubina;

    // Constructors
    public Kvadar(int id, string name) {
        this.kvID = id;
        this.kvName = name;
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Debug.Log("Kreirao sam objekt '"+name+"' s/n:"+id);
    }
    public Kvadar(int id, string name, float x, float y, float z) {
        this.kvID = id;
        this.kvName = name;
        this.kvX = x;
        this.kvY = y;
        this.kvZ = z;
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(x, y, z);

        
        //Get the Renderer component from the new cube
        var cubeRenderer = cube.GetComponent<Renderer>();

        // promjena ashadera da bi se mogla napraviti transparencija
        Shader shaderTD;
        shaderTD = Shader.Find("Transparent/Diffuse");
        cubeRenderer.material.shader = shaderTD;

        // promjena boje i prozirnosti
        //Call SetColor using the shader property name "_Color" and setting the color to red
        Color boja = new Color (1.0f, 0f, 0f, 0.1f);
        cubeRenderer.material.SetColor("_Color", boja);

        


        


        

        // var col = cube.GetComponent<Renderer>().material.color;
        // col = Color.red;

        Debug.Log("Kreirao sam objekt '" + name + "' s/n:" + id+" na poziciji x:"+x+" y: "+y+" z: "+z);
    }

}