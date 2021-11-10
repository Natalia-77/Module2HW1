using System;

namespace Module2HW1
{
    internal class Starter
    {
        private readonly Actions _actions = new ();
        public void Run()
        {
            Random rand = new ();
            for (int i = 0; i <= 100; i++)
            {
                int a = rand.Next(1, 4);
                switch (a)
                {
                    case 1:
                        _actions.InfoMethod();
                        break;
                    case 2:
                        _actions.WarningMethod();
                        break;
                    case 3:
                        _actions.ErrorMethod();
                        Logger.Instance.Error($"Action failed by a reason: {_actions.ErrorMethod().ResultMessage}");
                        break;
                }
            }
        }
    }
}
