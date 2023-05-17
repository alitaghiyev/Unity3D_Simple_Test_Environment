using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AzeriPatates
{
    public class refout : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

    static void Kare(int sayi) {
        sayi = sayi * sayi;
        }

    static void Kare2(ref int sayi) {
        sayi = sayi * sayi;
    }

    
    }
}
