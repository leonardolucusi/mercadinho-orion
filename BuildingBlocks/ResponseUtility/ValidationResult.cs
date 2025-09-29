namespace BuildingBlocks.ResponseUtility;

public class ValidationResult
{
    public ValidationResult(){}
    public List<string> Messages { get; set; } = [];
    public List<ValidationCode.Code> Codes { get; set; } = [];
    public bool Validity { get; private set; } = true;
    public ValidationResult(ValidationCode.Code code, string message, bool isValid) =>
        Add(code, message, isValid);
    public void ApplyFluentValidationResult(
        FluentValidation.Results.ValidationResult? fluentValidationResult)
    {
        fluentValidationResult?.Errors?.ForEach(x =>
        {
            Messages.Add($"{x.PropertyName}: {x.ErrorMessage}");
            Codes.Add(ValidationCode.CodesDictionary[x.ErrorCode]);
            Validity = fluentValidationResult.IsValid;
        });
    }

    public void Add(ValidationCode.Code code, string message, bool isValid)
    {
        Messages.Add(message);
        Codes.Add(code);
        Validity = isValid;   
    }
}
