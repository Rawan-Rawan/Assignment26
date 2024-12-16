using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment27
{

    public class Assign27 : MonoBehaviour
    {

        void Start()
        {
            int a = 1;
            int b = 2;
            int c;
            IncrementNumber1(a);
            Debug.Log(a);

            IncrementNumber2(ref b);
            Debug.Log(b);

            IncrementNumber3(out a);
            Debug.Log(a);
            IncrementNumber3(out c);
            Debug.Log(c);
            IncrementNumber3(out b);
            Debug.Log(b);
        }

        void IncrementNumber1(int aa)
        {
            aa += 4;
        }
        void IncrementNumber2(ref int bb)
        {
            bb += 5;
        }
        void IncrementNumber3(out int cc)
        {
            cc = 1;
            cc += 1;
        }

    }
}