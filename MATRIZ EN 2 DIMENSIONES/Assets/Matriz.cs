using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matriz : MonoBehaviour
{
    public int[,] matriz;
    public int fila, columna;
    public int Numeros0, Numeros1;
    private string Str;
    
    void Start()
    {
        matriz = new int[fila, columna];
        for (int i = 0; i < fila; i++ )
        {
            for (int j= 0; j < columna; j++)
            {
                matriz[i, j] = Random.Range(0, 2);
                Str += matriz[i, j] + " , ";   
            }
            Debug.Log(Str);
            Str = null;
;       }

        for (int i = 0; i < fila; i++)
        {
            for (int j = 0; j < columna; j++)
            {
                if (j < columna - 1 && matriz[i, j] == matriz[i, j + 1])
                {
                    if (matriz[i, j]==0)
                    {
                        Numeros0++;
                    }
                    else
                    {
                        Numeros1++;
                    }
                }
            }
        }
    }

    void Update()
    {
        
    }
}
