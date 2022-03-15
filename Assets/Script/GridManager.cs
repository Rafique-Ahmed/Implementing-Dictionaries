using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GridManager : MonoBehaviour
{
    public int[,] Grid = new int[3, 3];
    public GameObject cubeprefab;

    IDictionary<int, string> birds = new Dictionary<int, string>();
        
    //public GameObject listText;
    
    public Text listText;
     
    // Start is called before the first frame update
    void Start(){
        SpawnCube();
        birds.Add(0,"Mahesh Chand");
        birds.Add(1,"Chris Love");  
        birds.Add(2,"Allen O'neill");

            
    }

    void SpawnCube(){
        //This is how you create a list. Notice how the type
        //is specified in the angle brackets (< >).
        //List<BadGuy> badguys = new List<BadGuy>();

        //Here you add 3 BadGuys to the List
        //badguys.Add( new BadGuy("Harvey", 50));
        //badguys.Add( new BadGuy("Magneto", 100));
        //badguys.Add( new BadGuy("Pip", 5));

        //Here you add 3 BadGuys to the List
        //badguys.Add( new BadGuy("Harvey1", 51));
        //badguys.Add( new BadGuy("Magneto1", 101));
        //badguys.Add( new BadGuy("Pip1", 6));

        //Here you add 3 BadGuys to the List
       //badguys.Add( new BadGuy("Harvey2", 52));
       // badguys.Add( new BadGuy("Magneto2", 102));
       // badguys.Add( new BadGuy("Pip2", 7));

       // badguys.Sort();

      //  foreach(BadGuy guy in badguys)
       // {
          //  listText.text = guy.name + " " + guy.power.ToString();
          //  print (guy.name + " " + guy.power);
       // }
        //This clears out the list so that it is
        //empty.
        //badguys.Clear();   
        for(int i=0; i<=Grid.GetLength(0);i++){
            for(int j=0; j<=Grid.GetLength(1);j++){
                listText.text="QWE";
                Instantiate(cubeprefab, new Vector3(j*2,0,i*2), cubeprefab.transform.rotation);
                Instantiate(listText, new Vector3(j*2,0,i*2), listText.transform.rotation);
            }
        }
    }
}