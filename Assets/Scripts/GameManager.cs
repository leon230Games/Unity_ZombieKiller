using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager {

    #region Singleton
    private GameObject gameObject;

    //TODO rework singletonPattern
    private static GameManager mInstance;
    public static GameManager instance
    {
        get
        {
            if(mInstance == null)
            {
                Debug.Log("Assigning GameManager");
                mInstance = new GameManager();
                mInstance.gameObject = new GameObject(gameConstants.gameManager);
                mInstance.gameObject.AddComponent<InputController>();
                mInstance.gameObject.AddComponent<Timer>();
            }
            else
            {
                //Debug.Log("GameManager already defined");
            }
            
            return mInstance;
        }

    }
    #endregion

    private InputController mInputController;
    public InputController inputController
    {
        get
        {
            if (mInputController == null)
            {
                mInputController = gameObject.GetComponent<InputController>();
            }
            return mInputController;
        }
    }

    private Timer mTimer;
    public Timer timer
    {
        get
        {
            if (mTimer == null)
            {
                mTimer = gameObject.GetComponent<Timer>();
            }
            return mTimer;
        }

    }

    //public void MouseCursorEnabled(bool enabled)
    //{
    //    Cursor.visible = enabled;
    //    if(enabled == true)
    //    {
    //        Cursor.lockState = CursorLockMode.None;
    //    }
    //    else
    //    {
    //        Cursor.lockState = CursorLockMode.Locked;
    //    }

    //}

}
