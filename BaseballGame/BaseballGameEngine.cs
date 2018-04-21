using System;

namespace BaseballGame
{
    internal class BaseballGameEngine
    {
        int[] quiz = new int[3];
        int strike = 0;
        int ball = 0;

        internal void Init()
        {
            //중복 없는 랜덤
            //quiz 배열에 넣기
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random rand = new Random();
            for (int n = 0; n < 100; n++)
            {

                int i = rand.Next(0, temp.Length);
                int j = rand.Next(0, temp.Length);
                int sum = temp[i];
                temp[i] = temp[j];
                temp[j] = sum;
            }
            
           for(int n = 0; n < quiz.Length; n++)
            {
                quiz[n] = temp[n];
            }
            
            return;
        }

        internal void Play(string input)
        {
            //quiz랑 input이랑 비교해서 strike, ball 판정하기
            strike = 0;
            ball = 0;
            int[] inputArray = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                inputArray[i] = input[i] - '0';  //==atoi함수
            }
            for(int i = 0; i < quiz.Length; i++) { 
                for(int j = 0; j < inputArray.Length; j++)
                {
                    if (quiz[i] == inputArray[j])
                    {
                        if (i == j)
                        {
                            strike++;
                        }
                        else
                        {
                            ball++;
                        }
                    }
                }
            }
            return;
        }

        internal int getQuizLength()
        {
            return quiz.Length;
        }

        internal int GetStrike()
        {
          return strike;
        }

        internal int GetBall()
        {
           return ball;
        }
       
    }
}