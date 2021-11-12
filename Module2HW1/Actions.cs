namespace Module2HW1
{
    public class Actions
    {
        private Logger _logger = Logger.Instance;
        public Result InfoMethod()
        {
            _logger.Info($"Start method: {nameof(Actions.InfoMethod)}");
            return new Result { Status = true };
        }

        public Result ErrorMethod()
        {
            return new Result { Message = "I broke a logic" };
        }

        public Result WarningMethod()
        {
            _logger.Warning($"Skipped logic in method: {nameof(Actions.WarningMethod)}");
            return new Result { Status = true };
        }
    }
}
