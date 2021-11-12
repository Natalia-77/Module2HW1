using System;
using System.IO;

namespace Module2HW1
{
    public class Starter
    {
        public void Run()
        {
            var actions = new Actions();
            var rand = new Random();
            var result = new Result();
            var logger = Logger.Instance;
            for (var i = 0; i <= 100; i++)
            {
                var a = rand.Next(1, 4);
                switch (a)
                {
                    case 1:
                        result = actions.InfoMethod();
                        break;
                    case 2:
                        result = actions.WarningMethod();
                        break;
                    case 3:
                        result = actions.ErrorMethod();
                        break;
                }

                if (!result.Status)
                {
                    logger.Error($"Action failed by a reason: {result.Message}");
                }
            }

            File.WriteAllText("log.txt", logger.GetLogger());
        }
    }
}
