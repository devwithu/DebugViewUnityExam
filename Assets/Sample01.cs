     using UnityEngine; 
     using System.Collections;
     using System.Runtime.InteropServices;

public class Sample01 : MonoBehaviour {

         [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
         public static extern void OutputDebugString(string message);
         void Start() 
         {
             OutputDebugString("started...");
         }
}
