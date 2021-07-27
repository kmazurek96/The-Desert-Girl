using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageScriptController : MonoBehaviour
{
    public PlayerHealthScript healthScript;
   // [SerializeField]  LevelController LC;
    public GameObject startPosition;
    [SerializeField]    private int damage;
    //private int health;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            collision.gameObject.GetComponent<Animator>().SetTrigger("killed");
            //collision.transform.localPosition = new Vector3(startPosition.transform.position.x,startPosition.transform.position.y,startPosition.transform.position.z);
            Damage();
            //Debug.Log("Tak");//
            GetComponent<BoxCollider2D>().enabled = false;
            StartCoroutine(EnableBox(3F));
            

        }
            
    }

    public void Damage()
    {
      
        healthScript.playerHealth = healthScript.playerHealth - damage;
        healthScript.UpdateHealth();
        // this.gameObject.SetActive(false); //

    }
    IEnumerator EnableBox(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        GetComponent<BoxCollider2D>().enabled = true;
        //LC.saveScore();
       // LC.saveHealth();
        //SceneManager.LoadScene("mapa1");
    }

 
    
    
}
