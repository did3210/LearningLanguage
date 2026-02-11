using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//03.디버깅 방법 강의

namespace _03CodeStartAndReading
{
    internal class Program
    {
        /*  static void Main(string[] args)
            위 문단이 등장할시 이 문단부터
            {
                이 사이의 문장을 위에서 아래로 한줄씩 읽음.
            }
        */
        static void Main(string[] args)
        {
            int a = 100;
            //f10(Visual Studio IDE 기준)을 누를시 디버그 모드로 진입 -> 한줄씩 코드를 실행
            //f10을 누르면 계속 다음줄로 이동 및 이전줄 코드 실행
            Console.WriteLine("하하");
            Console.WriteLine("ㅇㅇ");
            Console.WriteLine("ㄴㄴ");
            Console.WriteLine("하하222");
        }
    }
}
