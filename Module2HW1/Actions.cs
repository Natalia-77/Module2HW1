namespace Module2HW1
{
    internal class Actions
    {
        public Result InfoMethod()
        {
            Result result = new ();
            result.Status = true;
            Logger.Instance.Info("Start method: InfoMethod()");
            return result;
        }

        public Result ErrorMethod()
        {
            Result result = new ();
            result.Status = false;
            result.ResultMessage = "I broke a logic";
            return result;
        }

        public Result WarningMethod()
        {
            Result result = new ();
            result.Status = true;
            Logger.Instance.Warning("Skipped logic in method: WarningMethod()");
            return result;
        }
    }
}
