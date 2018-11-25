using UnityEngine;
using UnityEngine.UI;

public class motivational : MonoBehaviour
{
    //public float speed = 2f;
    public Rigidbody2D rb2D;
    public System.Random ran = new System.Random();
    //private float thrust = 1.0f;
    public float jumpForce = 20f;
    public float wd = Screen.width;
    public float ht = Screen.height;
    uiManager ui = new uiManager();
 


    // Use this for initialization
    void Start()
    {


        Debug.Log(wd);
        Debug.Log(ht);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0, 5);
        //rb2D.AddForce(0, 1 * Time.deltaTime);
        rb2D.velocity = Vector2.up * jumpForce * Random.Range(0.5f, 2.0f) * Time.deltaTime;
    }
    void Update()
    {
        if (transform.position.y > 12.0f)
        {
            Destroy(gameObject);
        }


        if (Input.touchCount > 0)
        {
            Vector2 touch = Input.GetTouch(0).position;
            Vector2 touch2 = Input.GetTouch(0).rawPosition;
            double x = touch.x / Screen.width * 7;
            double y = touch.y / Screen.height * 12.2;

            //double x2 = touch2.x / wd * 9.1;
            //double y2 = touch2.y / ht * 12.2;

            Vector2 touchControl1 = new Vector2((float)x, (float)y);
            //Vector2 touchControl2 = new Vector2 ((float) x2, (float) y2);

            //Vector2 currentPos = transform.position;
            float dist = Vector2.Distance(transform.position, touchControl1);
            //float dist2 = Vector2.Distance(transform.position, touchControl2);
            if (dist < 0.53)
            {
      
                Destroy(gameObject);   
				ui.ScoreUpdate();

            }

            //if (dist2 < 1){
            //	Destroy(gameObject);
            //}
        }
        else if (Input.GetButtonDown("Fire1"))
        {
            Vector2 click = Input.mousePosition;
            //Debug.Log(dist);
            //Debug.Log (click.y);
            //Debug.Log (transform.position.x);
            //Debug.Log (transform.position.y);
            //Debug.Log (click.x);
            //Debug.Log (click.y);
            double x = click.x;
            double y = click.y;
            Vector2 clicknew = new Vector2((float)x, (float)y);
            float dist = Vector2.Distance(transform.position, click);
            if (dist < 1)
            {
                Destroy(gameObject);
            }
        }

    }
}
