using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player 
{
    //멤버변수 -> 클래스 내부에 있기에 멤버변수(전역변수?)
    int Att = 10;
    int Hp;

    void Fight()
    {
        Console.WriteLine("플레이어는 싸운다 지랄한다.");
    }
}//클래스란 게임에서 사용하기 위한 설계도 이걸 완성한다고 게임상에서 실행 되는 것이 아님

class Bounce
{
    int bounce = 10;
    float back = 100.17f;
    bool isBounce = false;

    void Bouncing()
    {
        Console.WriteLine("heart is bounce bounce");
    }
}

namespace _06LocalVar
{
    //C#은 클래스 그 자체이다.
    //프로그램 시작도 클래스로 시작!
    class Program
    {
        static void Main(string[] args)
        {
            //C#에서 객체화는 중요!
            //게임 상에서 실행이 되기 위해선 이 함수 안에 있어야 함.

            Player NewPlayer = new Player();    //되게 중요한 구조!
            //Player라는 설계대로 플레이어를 Main에 만듦(소환)
            //그 소환된 클래스의 이름을 NewPlayer라고 지정
            //참조할 클래스 타입(Player) + 참조 변수(NewPlayer) = 객체 생성(new) + 생성자 호출(Player)
            //왜 클래스 타입을 저렇게 하는지는 몰루? Player NewBounce = new Bounce; 같은게 왜 안되는지 설명좀.


            int Att = 10;
            int Def = 0;
            //함수 안에 선언된 변수 -> 지역변수


        }
    }
    
}
