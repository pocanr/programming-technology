using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.Exceptions
{
    public class ValidatorNullException(string paramName) : ArgumentNullException(paramName, $"Validator \"{paramName}\" must be specified for type.");
}
