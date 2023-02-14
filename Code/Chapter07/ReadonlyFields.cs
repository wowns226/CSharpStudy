using System;

namespace ReadonlyFields
{
    class Configuration
    {
        private readonly int min;
        private readonly int max;

        public Configuration(int v1, int v2)
        {
            min = v1;
            max = v2;
        }

        // 해당 함수를 호출하면 컴파일 에러가 발생한다
        // 읽기 전용 필드인 max의 값을 수정하려고 하였기 때문
        public void ChangeMax(int newMax)
        {
            max = newMax;
        }
    }

    class MainApp
    {
        static void Main()
        {
            Configuration c = new Configuration(100, 10);
        }
    }
}