using System;

namespace DefaultImplementation
{
    interface ILogger
    {
        void WriteLog(string message);

        // 새로운 메소드 추가
        void WriteError(string error)
        {
            WriteLog($"Error : {error}");
        }
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }

    class MainApp
    {
        static void Main()
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("System Up");
            logger.WriteError("System Fail");

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("System Up");

            // clogger.WriteError("System Fail");
            // 컴파일 에러
            // ConsoleLogger 클래스 내에 WriteError 함수 구현이 존재하지 않기 때문
        }
    }
}