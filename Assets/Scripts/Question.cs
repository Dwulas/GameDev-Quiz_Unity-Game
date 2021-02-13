
using System;
using UnityEngine;

[System.Serializable]
public class Question
{
    public string fact;
    public bool isTrue;

    public object Info { get; internal set; }

    public static explicit operator Question(UnityEngine.Object v)
    {
        throw new NotImplementedException();
    }
}
