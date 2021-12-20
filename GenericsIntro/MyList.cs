using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        //constructor new yazdığımız zaman otomatik olarak çalışıyor ctor tab tab
        public MyList()
        {
                items = new T[0];
        }
        //eleman sayısını +1 arttırmak length eleman sayısı demek.
        //yeni new tanımlamadıgım için referans numarasını siler bunu görmez o yüzden yeni gecici bir eleman acıyoruz new ile bunu burda tutuyoruz
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                items [items.Length - 1]=item;
            }
        }
    }
}
