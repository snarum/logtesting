using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogTesting
{
    public interface IValidatorService
    {
        bool Validate(int x, int y, int anwser);
    }
    public class ValidatorService:IValidatorService
    {
        private ILogger<ValidatorService> _logger;

        public ValidatorService(ILogger<ValidatorService> logger)
        {
            _logger = logger;
        }

        public bool Validate(int x, int y, int answer)
        {
            _logger.LogInformation("tutu");
            return x + y == answer;
        }
    }
}
