using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//프로그램 코드의 대가 -> 메모리
//일단 코드가 작성되면 메모리를 무조건 지불함

//프로그램의 구조도
//1.코드:상수,클래스 선언 등.... 수정이 불가
//2.데이터
//3.힙
//4.스택

class Player
{
    int HP;
    int ATT;
}

namespace _10Memory00_Func
{
    internal class Program
    {
        //메인함수
        static void Main(string[] args)
        {
            Player newPlayer = new Player();
        }
    }
}

