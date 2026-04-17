using System.Collections;

namespace ch5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열 선언 방법
            int[] array1 = new int[3];
            array1[0] = 1;
            array1[1] = 2;
            array1[2] = 3;

            int[] array2 = new int[] { 1, 2, 3 };
            int[] array3 = { 1, 2, 3 };

            Console.WriteLine(array1);
            Console.WriteLine(array2);
            Console.WriteLine(array3);

            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

            foreach (int i in array3)
            {
                Console.WriteLine(i);
            }


            ArrayList arr = new ArrayList();

            arr.Add(1);
            arr.Add("Hello");
            arr.Add(3.3);
            arr.Add(true);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            arr.Remove("Hello");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Queue: 입력한 값이 먼저 출력되는 자료 구조
            Queue qu = new Queue();

            //Enqueue: 큐에 아이템 추가
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);

            // Dequeue: 큐에서 아이템 제거 및 반환
            while (qu.Count > 0)
            {
                Console.WriteLine(qu.Dequeue());
            }
            Console.WriteLine();
            // Stack: 먼저 입력한 값이 맨 마지막에 출력
            Stack st = new Stack();

            //push: 스텍에 아이템 추가
            st.Push(1);
            st.Push(2);
            st.Push(3);

            //pop: 스택에서 아이템 제거 및 반환
            while(st.Count > 0)
            {
                Console.WriteLine(st.Pop());
            }

            // HashTable: 키와 값으로 저장하는 자료 구조
            Hashtable ht = new Hashtable();
            ht["apple"] = "사과";
            ht["banana"] = "바나나";
            ht["Orange"] = "오렌지";

            Console.WriteLine(ht["apple"]);
            Console.WriteLine(ht["banana"]);
            Console.WriteLine(ht["Orange"]);

            Except ex = new Except();
            ex.divide();
        }
    }
}
