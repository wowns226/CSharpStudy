using System;

namespace ReadonlyStruct
{
    readonly struct RGB
    {
        public readonly byte R;
        public readonly byte G;
        public readonly byte B;
        public RGB(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
    }

    class MainApp
    {
        static void Main()
        {
            RGB Red = new RGB(255, 0, 0);
            // Red.G = 100; 
            // 위 주석된 코드 실행시 컴파일에러
        }
    }
}