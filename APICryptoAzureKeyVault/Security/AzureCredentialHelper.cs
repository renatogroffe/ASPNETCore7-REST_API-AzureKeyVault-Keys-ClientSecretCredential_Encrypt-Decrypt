using Azure.Identity;

namespace APICryptoAzureKeyVault.Security;

// Informacoes sobre os tipos possiveis de Credentials:
// https://learn.microsoft.com/en-us/dotnet/api/azure.core.tokencredential?view=azure-dotnet

public static class AzureCredentialHelper
{
    public static ClientSecretCredential GetClientSecretCredential(
        IConfiguration configuration) => new ClientSecretCredential(
            tenantId: configuration["AzureSecurity:TenantId"],
            clientId: configuration["AzureSecurity:ClientId"],
            clientSecret: configuration["AzureSecurity:ClientSecret"]);
}
