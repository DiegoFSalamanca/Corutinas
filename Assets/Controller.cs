using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{

    public GameObject pelota;

    public Transform pos1, pos2;

    public float speed;

    public Text texto;


    IEnumerator micorutina;

    public IEnumerator CorutinaMover()
    {       
       float t = 0;              

       while (t< 1)
       {
         t += speed * Time.deltaTime;        
         pelota.transform.position = Vector3.Lerp(pos1.position, pos2.position, t);
         texto.text = (t *10).ToString();
         yield return null;
       }
    
    }

    public void EjecutarCorutinas()
    {              
        StartCoroutine(micorutina);       
    }

    public void StopCorutine()
    {
        StopCoroutine(micorutina);
    }

    // Start is called before the first frame update
    void Start()
    {
         micorutina = CorutinaMover(); 
    }

   
}
