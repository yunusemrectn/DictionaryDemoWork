using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class cMyDictionary<K,V>
    {
        K[] nKey;
        V[] nValue;
        public cMyDictionary()
        {
            nKey = new K[0];
            nValue = new V[0];
        }
        public void Add(K gKey, V gValue)
        {
            K[] kArray = nKey;
            V[] vArray = nValue;
            nKey = new K[nKey.Length+1];
            nValue = new V[nValue.Length + 1];
            for (int i = 0; i < kArray.Length; i++)
            {
                nKey[i] = kArray[i];
                nValue[i] = vArray[i];
            }
            nKey[nKey.Length - 1] = gKey;
            nValue[nValue.Length - 1] = gValue;
        }
        public int Length
        {
            get { return nKey.Length; }
        }
        public K[] NKey
        {
            get { return nKey; }
        }
        public V[] NValue
        {
            get { return nValue; }
        }
    }
}
