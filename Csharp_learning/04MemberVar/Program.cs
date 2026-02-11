using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//04.멤버변수에 대한 강의
//이번 예제는 클래스나 함수내에 들어갈 내용에 관한 예제이다.

//개념: 플레이어가 존재한다.
class Player
{
    //개념 : 플레이어는 골드를 가진다.
    int Gold;
    int Exp;
    int Att;
    int Def;
    int Hp;
    bool IsFight;

    //맴버변수 구조:
    //int(자료형) 이름(식별자)

    //자료형의 의미:
    //크기: bit -> byte(8bit) -> KB(1024byte) -> MB(1024kb) -> GB(1024mb) -> TB(1024gb) -> PB(1024tb)
    //형태:정수,실수,char,string,bool ....
    //이름의 의미
    //위치
    //내가 사용하기 위한 별명

    //초기값 설정도 가능, 이걸 '리터럴값'이라 부른다.
    int HPP = 10;
}
