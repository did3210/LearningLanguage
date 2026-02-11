using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Result = 0;
            int Left = 10;
            int Right = 3;

            //대입연산자(=) -> 함수에서 리턴된 값, 리터널 값, 연산된 값을 변수(그 값을 받을 수 있는)에 넣어준다.
            Result = 100;
            Result = 0;

            //산술연산자
            //참고로 0을 나눌시 제로디비전이라는 오류가 발생
            //연산자의 우선순위 -> *,/,% > +,- > =
            Result = Left + Right;
            Result = Left - Right;
            Result = Left * Right;
            Result = Left / Right; //나누기
            Result = Left % Right; //나머지

            //비교연산자
            //논리형(bool)으로 리턴
            bool BResult = true;
            BResult = Left > Right;
            BResult = Left < Right;
            BResult = Left >= Right;
            BResult = Left <= Right;
            BResult = Left == Right;
            BResult = Left != Right;

            //bool 논리 연산자
            //참과 거짓을 연산하는 연산자
            BResult = !true; //NOT -> true라면 false, false라면 true
            BResult = true && false; // AND -> 모든 값들이 다(갯수는 상관없음) true 일때만 true
            BResult = true || false; // OR -> 모든 값들 중(갯수는 상관없음) 하나라도 true면 true

            BResult = true ^ true; // XOR -> 양쪽 값들이 다르면 true, 양쪽 값들이 같다면 false
            BResult = false ^ false;
            BResult = true ^ false;

            //축약 연산자
            Result += 10;
            Result -= 10;
            Result *= 10;
            Result /= 10;
            Result %= 10;
        }
    }
}
