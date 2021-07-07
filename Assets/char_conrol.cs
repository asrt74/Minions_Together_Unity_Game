using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class char_conrol : MonoBehaviour
{
    //public AudioSource audios;
    public float speed;
    public float rotate_speed;
    public Rigidbody rb;
    public ParticleSystem death_effect;
    //private Scene scene;
    //public Camera camera;

    void Start()
    {
        //audios = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float hori = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 player_movement = new Vector3(hori, 0f, ver);
        
        //transform.Translate(player_movement, Space.Self);
        //rb.MovePosition(player_movement);
        var move_speed = speed * Time.deltaTime;

        //player_movement = Quaternion.Euler(0, camera.gameObject.transform.eulerAngles.y, 0) * player_movement;
        var target_pos = transform.position + player_movement * move_speed;
        transform.position = target_pos;
        //transform.Translate(player_movement);

        
        rotate_towards_move(player_movement);

        
    }
    void rotate_towards_move(Vector3 movement_pos)
    {
        if(movement_pos.magnitude == 0)
        {
            return;
        }
        var rotation = Quaternion.LookRotation(movement_pos);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, rotate_speed);
    }
    public void death()
    {
        
        Instantiate(death_effect, transform.position, Quaternion.identity);
        //audios.Play();
        Destroy(gameObject);

        if (gameObject.CompareTag("leader"))
        {

            //StartCoroutine(wait_for_death());

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
    


}
