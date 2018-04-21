using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseballGameEngine 생성하기
            //게임엔진 초기화하기 : Quiz 만들기
            //quiz 중복없는 랜덤한 숫자
            //무한방복해서 사용자 입력 받기
            //게임엔진에 사용자 입력을 넘기고, strike, ball 판정
            //strike의 개수와 quiz 길이가 같으면 끝
            BaseballGameEngine bge = new BaseballGameEngine();
            bge.Init();
            while (true)
            {
                Console.Write("input Number : ");
                String input = Console.ReadLine();
                bge.Play(input);
                Console.WriteLine("input : {0}\tStrike : {1}\tball : {2}",
                    input, bge.GetStrike(), bge.GetBall());
                if (bge.GetStrike()==bge.getQuizLength())
                {
                    Console.WriteLine("축하합니다!!");
                    break;
                }
            }
        }
    }
}
