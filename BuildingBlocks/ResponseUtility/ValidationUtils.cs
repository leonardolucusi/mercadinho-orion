namespace BuildingBlocks.ResponseUtility;

public static class ValidationUtils
{
    public static string ValidOperation_Created(Type type) =>
        $"Objeto: '{type.Name}' criado com sucesso!";
    
    public static string ValidOperation_Ok() =>
        "Operação realizada com sucesso!";

    public static string ValidOperation_NoContent() =>
        "Operação realizada com sucesso!";
    
    public static string InvalidOperation_NotFound() =>
        "Objeto procurado não encontrado!";
    
    public static string InvalidOperation_WrongCredentials() =>
        "Credencial inválida!";
}