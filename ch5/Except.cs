using System;
using System.Collections.Generic;
using System.Text;

namespace ch5
{
    public class Except
    {
        public Except() {
        }

        public void divide()
        {
            Console.Write("나눌 숫자를 입력하세요");
            int divider = int.Parse(Console.ReadLine());

            try
            {
                int result = 10 / divider;
                Console.WriteLine(result);
            } catch(Exception e)
            {
                Console.WriteLine("에러메시지 : " + e.Message);
            }
        }
    }
}
