using System;

namespace CsharpBeginner
{
    /// <summary>
    /// 플레이어의 상태를 열거체형으로 정의한다.
    /// 크게 4가지의 상태가 있다.
    /// </summary>
    public enum PlayerState
    {
        Idle = 0,
        Attack,
        Hit,
        Running
    }

    public class MainApplication()
    {
        public static PlayerState state = PlayerState.Idle;

        /// <summary>
        /// 메인 진입 지점입니다.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Hello, World! 라고 콘솔 창에 써주세요.
            Console.WriteLine("Hello, World!");

            state = PlayerState.Attack;
            Console.WriteLine(state.ToString());
        }
    }
}

