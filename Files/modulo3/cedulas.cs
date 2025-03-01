using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("Valor")]
    [SerializeField] public double valor;
    
    private void Awake()
    {
        
    }

    void contaCedulas(double valor)
    {
        double[] arrayCedulas = { 200, 100, 50, 20, 10, 5, 2, 1, 0.50, 0.25, 0.10, 0.05, 0.01 };

        Debug.Log(valor);
        int i,totalCedulas;
        for(i = 0; i < arrayCedulas.Length; i++)
        {
            if(valor <= 1)
            {
                totalCedulas = (int)((valor - valor % arrayCedulas[i]) / arrayCedulas[i]);
                valor = valor % arrayCedulas[i];
                if (totalCedulas == 0) { continue; }
                Debug.Log($"{totalCedulas} moedas(s) de R${arrayCedulas[i]}"); 
            }
            else
            {
                totalCedulas = (int)((valor - valor % arrayCedulas[i]) / arrayCedulas[i]);
                valor = valor % arrayCedulas[i];
                if (totalCedulas == 0) { continue; }
                Debug.Log($"{totalCedulas} notas(s) de R${arrayCedulas[i]}");
            }
            totalCedulas = 0;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        contaCedulas(valor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
