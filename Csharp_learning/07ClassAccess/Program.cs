using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{

    //객체지향의 캡슐화 은닉화를 대표하는 문법        ->         보안,실수방지
    //접근제한 지정자!
 
    int ATT;
    int HP;

    public int Gold; // 공개
    protected int Damage; // 자식에게만 공개
    private int Def; // 내부에만 공개

    public void Fight()
    {
        Console.WriteLine("your fight because you can fight.");
    }

    //클래스 설계시 상대방이 잘못 쓰기도 힘들게 하라.
}



namespace _07ClassAccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            //만들어진 객체의 내용을 사용 -> 객체의 이름.을 사용한다.
            //NewPlayer.Gold

            NewPlayer.Gold = 1;
            NewPlayer.Fight();
        }
    }
}

//7-1.1월 21일 추가
//객체지향 프로그래밍에서 가장 처음 할 일
//1.무엇을 만들것인가
//2.클래스 선언
//3.함수 선언
//4.변수 선언....
