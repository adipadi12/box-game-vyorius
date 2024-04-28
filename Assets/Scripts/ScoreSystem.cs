using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreSystem : MonoBehaviour
{
    public ParticleSystem particleSystemPrefab; // Particle system prefab to instantiate
    public Text scoreIni;
    public int score = 0;
    public int maxScore = 8;

    private void Start()
    {
        score = 0;
    }

    public void AddScore(int newScore)
    {
        score += newScore;
    }

    public void UpdateScore()
    {
        scoreIni.text = "Score: " + score;
    }

    

    // Update is called once per frame
    void Update()
    {
        

        // Check if the mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            
            // Cast a ray from the camera through the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits any colliders
            if (Physics.Raycast(ray, out hit))
            {
                AddScore(1);
                Debug.Log("Added 1 to score");
                UpdateScore();
                // Check if the collider belongs to the object with this script
                if (hit.collider == GetComponent<BoxCollider>())
                {
                    // Destroy the object
                    Destroy(hit.collider.gameObject);
                    

                    //Debug.Log("Score: " + currentScore);

                    Instantiate(particleSystemPrefab, transform.position, Quaternion.identity);

                    
                }
            }
        }
        if(score == 8)
        {
            SceneManager.LoadScene("WinnerScene");
        }
    }
    
}
