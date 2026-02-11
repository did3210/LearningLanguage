using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    //접근제한 지정자를 입력하지 않을시(default) -> private
    //대부분의 경우 외부에서 클래스나 함수의 속성(변수)에 접근하지 않아야 함.
    //이유 -> 해킹에 취약

    public int Lv;
    public int HP;
    public int AT;

    public void SetHP(int _HP)
    {
        HP = _HP;
        //이 방식으로 설정시 디버깅에 큰 도움이 됨.
        //반복수정 작업을 줄여줌
    }

    // 함수는 보통 선언과 내용으로 나뉜다.
    // void[리턴값] Func[이름 혹은 식별자] ()[인자값]
    // 함수란 보통 클래스 외부와의 소통을 위해서 만든다.
    public void Func(int _Dmg /*한개의 int값을 넣어서 플레이어에게 전달하겠다.*/)
    {

    }
    public void Damage(int _Dmg, int _SubDmg)
    {
        HP = HP - _Dmg;
        HP = HP - _SubDmg;
    }
    

    //리턴값이란 객체가 자신의 상태를 외부에 알려주는 용도
    //외부에 알릴시 -> 함수가 끝남
    //리턴값이 넣어질 시 함수에 표시되는 값이 리턴값이 된다.
    //리턴값은 자신이 리턴해주려는 자료형과 같은 자료형이어야 한다.
    public int GetLv()
    {
        return Lv;
    }

    public void DamageToHPReturn(int _Dmg)
    {
        HP = HP - _Dmg;
        return HP; //함수의 자료형이 달라서 오류가 뜬다.
    }
    public int DamageToHPReturn2(int _Dmg)
    {
        HP = HP - _Dmg;
        return HP;
    }
}



namespace _08FuncEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();

            //newPlayer.HP = 0;
            //newPlayer.HP = 0;
            //newPlayer.HP = 0;
            //newPlayer.HP = 0;
            //-> 이 방식의 경우 수정 사항이 생길시 값이 변경되는 부분을 직접 찾아, 다 수정 시켜야 함.



            newPlayer.SetHP(0);
            //이 함수 방식의 장점:
            //중간점을 걸어 들어온 값을 알수 있음
        }


    }


}

