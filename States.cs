using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "States")]
public class States : ScriptableObject {

  [TextArea(10,14)] [SerializeField] string storyText;
}
     