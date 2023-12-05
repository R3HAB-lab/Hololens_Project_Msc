using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundingLeft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector2[] uvs = new Vector2[vertices.Length];
        List<Vector2> uvs_old = new List<Vector2>();

        mesh.GetUVs(0, uvs_old);


        for (int i = 0; i < uvs.Length; i++)
        {
            uvs[i] = new Vector2(uvs_old[i].x, uvs_old[i].y * 0.5f+0.5f);
        }

        mesh.uv = uvs;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
