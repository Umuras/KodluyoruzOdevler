using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItemController : MonoBehaviour
{
    PlayerController _player; // PlayerController için yeni bir player objesi oluşturduk.


        private void Start()
    {
        _player = FindObjectOfType<PlayerController>(); // PlayerController Objesini yükledik ve bu sayede hem scripte hem Player karakterine eriştik.
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {


            //collision.gameObject.GetComponent<PlayerController>().ScalePlayer(); // PlayerController compenentine erişip ScalePlayer fonksiyonunu çalıştırdık.
           
            if(collision.gameObject.tag == "food")
            {
                _player.ScalePlayer(); // Yukarıda oluşturduğumuz obje sayesinde ScalePlayer fonksiyonuna erişerek Player karakterimize obje çarpınca büyümesini sağladık.
            }
            

            //else if (collision.gameObject.tag == "bomb")
            //{
            //    _player.ScaleDecrease();
            //}
            
            Destroy(gameObject);

        }

        Destroy(this.gameObject);
    }

}


    


