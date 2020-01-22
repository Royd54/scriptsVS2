using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{

    [SerializeField] private Camera camera;
    [SerializeField] private GameObject beginObject;
    [SerializeField] private Transform beginPos;
    [SerializeField] private GameObject[] enemys;
    private sceneManager sm;

    // Start is called before the first frame update
    void Start()
    {
        beginPos = beginObject.transform;
        Scene sceneLoaded = SceneManager.GetActiveScene();
        if (sceneLoaded.buildIndex == 0)
        {
            loadNewLevelEffect();
        }
        loadNewLevelEffect();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadNewLevelEffect()
    {
        camera.cullingMask = 9 << 9;
    }

    public void resetCullingMask()
    {
        camera.cullingMask = -1;
    }
    public void nextLevel()
    {
        Scene sceneLoaded = SceneManager.GetActiveScene();
        SceneManager.LoadScene(sceneLoaded.buildIndex);
        // if (sceneLoaded.buildIndex == 1)
        // {
        //     SceneManager.LoadScene(sceneBuildIndex: 0);
        // }
        // else
        // {
        //     SceneManager.LoadScene(sceneBuildIndex: 1);
        //}

    }

    public void Death()
    {
            SceneManager.LoadScene(sceneBuildIndex: 0);
    }

}
