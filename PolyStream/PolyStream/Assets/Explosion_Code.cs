using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_Code : MonoBehaviour
{
    public float cubeSize = 0.2f;
    public int cubesInRow = 5;

    public float explosionRadius;
    public float explosionUpForce;
    public float explosionForce;
    public Material material;

    public float cubesPivotDistance;
    Vector3 cubesPivot;

    void Start()
    {
        //Calculate the pivot distance of this mass of object
        cubesPivotDistance = cubeSize * cubesInRow / 2;
        //Use this value to create the pivot Vector(distance)
        cubesPivot = new Vector3(cubesPivotDistance, cubesPivotDistance, cubesPivotDistance);
    }

    public void Explode() //Makes it public so it can be called by other class. 
    {
        //This will deactivate the current gameObject.
        gameObject.SetActive(false);
        //Runs the FX code.
        for (int x = 0; x < cubesInRow; x++)
        {
            for (int y = 0; y < cubesInRow; y++)
            {
                for (int z = 0; z < cubesInRow; z++)
                {
                    creatAfterFXPiece(x, y, z);
                }
            }
        }

        //gets the explosion distance
        Vector3 explosionPos = transform.position;
        //gets colliders in that position and radius 
        Collider[] colliders = Physics.OverlapSphere(explosionPos, explosionRadius);
        //add explosion force to all colliders in that overlap sphere
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, explosionPos, explosionRadius, explosionUpForce, ForceMode.Impulse);
            }
        }
    }
    void creatAfterFXPiece(int x, int y, int z)
    {
        //Creates gameObject piece, type cube. 
        GameObject piece; //Creates a gameObject named Piece.
        piece = GameObject.CreatePrimitive(PrimitiveType.Cube); //Creates it as a cube, through CreatePrimitive which is a function part of "GameObject".
        Renderer thisRend;
        thisRend = piece.GetComponent<Renderer>();
        thisRend.enabled = true;
        thisRend.sharedMaterial = material;

        //Sets piece position as the current object position but by multiplying the small bits to the size of the original cube it will spawn it like bits
        //of the original cube. So if the cube is 3x3 and you want to make 1x1 bits of it by doing 0.33 * 3, you get 9 1x1 bits filling the 3x3 original space.
        piece.transform.position = transform.position + new Vector3(cubeSize * x, cubeSize * y, cubeSize * z) - cubesPivot;

        //Sets the size/scale of the piece, by passing its current scale and making a new Vector3 out of it with the new measurements.
        piece.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);

        //add rigidBody and set Mass to the piece | Since its a gameObject now, which means its an "Object", so you can Add Components to it among other things.
        piece.AddComponent<Rigidbody>();
        piece.GetComponent<Rigidbody>().mass = 0.1f;

    }
}

