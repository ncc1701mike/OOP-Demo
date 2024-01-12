using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
   public void StartDemo()
   {
      SceneManager.LoadScene(1);
   }
}
