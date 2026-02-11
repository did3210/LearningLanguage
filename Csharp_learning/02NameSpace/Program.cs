using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// 02.네임스페이스에 대한 강의
// 문법을 공부시 개념에 집중



// 개념의 분류, 기능들의 묶음
namespace MyNamespace1
{
    class /*MyNamespace1.*/ Potion
    {

    }
}
namespace MyNamespace2
{
    class /*MyNamespace2.*/ Potion
    {

    }
}


namespace MyNamespace3
{
    class ProNo
    {
        static void Main(string[] args)
        {
            MyNamespace1.Potion;
        }

    }
}


