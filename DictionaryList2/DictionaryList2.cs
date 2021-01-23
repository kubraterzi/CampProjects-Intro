using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryList2
{
    public class DictionaryList2<TKey, TValue>
    {
        Dictionary<TKey, TValue> openWith = new Dictionary<TKey, TValue>();
        public void Add(TKey key, TValue value)
        {
            openWith.Add(key, value);
        }
        public void GetAll()
        {
            foreach (var item in openWith)
            {
                Console.WriteLine(" Key :  {0} |    Values : {1}", item.Key, item.Value);
            }
        }
    }
}
