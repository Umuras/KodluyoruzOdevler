using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance : MonoBehaviour
{
    FuelIncearase fl = new FuelIncearase();
    SpeedIncrease sp = new SpeedIncrease();
    void Start()
    {
        Debug.Log(fl.brand);
        Debug.Log(fl.modelName);
        Debug.Log("Horse Power " + fl.horsePower);
        
        


    }

   
    void Update()
    {


        

        fl.BenzinArtırımı();

        sp.HızArtıırımı();
    }

    public void EngineStart()
    {
        Debug.Log(fl.engine);
        Debug.Log("If increase fuel press A or increase speed press S");
        GetComponent<Inheritance>().enabled = true;
    }

    public void EngineStop()
    {
        Debug.Log(fl.engineStop);
        GetComponent<Inheritance>().enabled = false;
    }
   

    
}


public class Vehicle
{
    public string brand = "Skoda";
    public string modelName = "Fabia";
    public int horsePower = 75;

}


public class CarFeatures : Vehicle
{
    public int fuel = 0;
    public int speed = 0;
    public string engine = "Engine Start";
    public string engineStop = "Engine Stop";


    
   
	

	

   
}


public class FuelIncearase : CarFeatures
{
    
    public void BenzinArtırımı()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            fuel = fuel + 10;
            Debug.Log("New Fuel value is = " + fuel);

            if (fuel == 100)
            {
                Debug.Log("Fuel is full");
                Debug.Log("Fuel is reset");
                fuel = 0;
            }
        }

       

 
    }

}

public class SpeedIncrease : CarFeatures
{
    public void HızArtıırımı()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
           
            speed = speed + 10;
            Debug.Log("Speed is " + speed);
           

             if (speed > 0 && speed <= 50)
            {
                Debug.Log("Car is too slow " + speed);
            }

            else if (speed >= 60 && speed <= 80)
            {
                Debug.Log("Car speed is normal " + speed);
            }

            else if (speed >= 90)
            {
                Debug.Log("Car is too fast " + speed);
            }
             if (speed == 120)
            {
                Debug.Log("Danger of accident " + speed);
                Debug.Log("Speed is reset");
                speed = 0;
            }
        }
       
        
    }
}


