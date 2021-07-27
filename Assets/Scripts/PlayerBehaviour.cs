using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerBehaviour : MonoBehaviour
{
    Animator anim;
    Transform trans;
    bool BodytoRight = true;
    Rigidbody2D RgBody;
    public float HeroSpeed;
    public float JumpForce;
    BoxCollider2D boxCollider2D;
    CircleCollider2D circleCollider2D;
    [SerializeField]   private LayerMask layerMask;
    public Transform startPoint;
    [SerializeField] private EdgeCollider2D swordcollider;
    public PlayerHealthScript healthScript;
   // private int health;
    public bool canJump;
    private float distToGround;
    public float delayInSeconds;
    public float jumpTimer;
    Vector3 staypostion;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        trans = GetComponent<Transform>();
        RgBody = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        circleCollider2D = GetComponent<CircleCollider2D>();
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("dying"))
        {
            RgBody.velocity = Vector2.zero;
            return;
        }

        Debug.Log(canJump);

        if (IsGround() && Input.GetKeyDown(KeyCode.Space) && jumpTimer < 0f)                  // skakanie , jesli wcisniety klawisz spacji ...  i jeśli jest na podłozu
        {
                RgBody.AddForce(new Vector2(0f, JumpForce));    // dodanie sił
                anim.SetTrigger("jump");
            jumpTimer = 0.5f;
        }

        jumpTimer -= Time.fixedDeltaTime;
        if (!this.anim.GetCurrentAnimatorStateInfo(0).IsTag("melee"))
        {
            float horizontalmove;

            horizontalmove = Input.GetAxis("Horizontal"); // wczytanie strzałki w lewo i prawo
            RgBody.velocity = new Vector2(horizontalmove * HeroSpeed, RgBody.velocity.y); // poruszanie sie bohatera predkosc
            anim.SetFloat("speed", Mathf.Abs(horizontalmove)); // przypisanie do wartosci speed wczytanej strzałki aby postać mogła zacząc korzystac z animacji run
            if (horizontalmove < 0 && BodytoRight)
            {
                Flip();
            }
            if (horizontalmove > 0 && !BodytoRight)
            {
                Flip();
            }
            //if(horizontalmove == 0)
           /// {
            //     staypostion = trans.localPosition;
             //   trans.position = new Vector2(staypostion.x, staypostion.y);
           // }
        }
       

        

     
      
        if(Input.GetButtonDown("Fire1") && IsGround())
            {
            KnifeAttack();
            anim.SetTrigger("attack");
            
            RgBody.velocity = Vector2.zero;
            
        } 

        


    }


    void Flip() // metoda do obracania bohatera
    {
        BodytoRight = !BodytoRight;

        Vector3 HeroScale = gameObject.transform.localScale;
        HeroScale.x *= -1;
        gameObject.transform.localScale = HeroScale;

    }

    private bool IsGround() //funkcja wykrywajaca czy postac z czyms koliduje
    {

        RaycastHit2D raycastHit2D = Physics2D.BoxCast(
     circleCollider2D.bounds.min,
     circleCollider2D.bounds.size,
     0f, Vector2.down, .05f, layerMask);
        return raycastHit2D.collider != null;
    }

    public void OnRestart()
    {
        {
            healthScript.UpdateHealth();
            gameObject.transform.position = startPoint.transform.position;
            if (healthScript.playerHealth == 0)
            {
                SceneManager.LoadScene("endScreen");
            }
        }
    }

    public void KnifeAttack()
    {
        swordcollider.enabled = !swordcollider.enabled;
      
    }


   
}

