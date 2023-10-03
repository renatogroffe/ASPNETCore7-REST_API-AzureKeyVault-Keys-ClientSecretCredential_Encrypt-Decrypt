using Azure.Identity;

namespace APICryptoAzureKeyVault.Security;

// Informacoes sobre os tipos possiveis de Credentials:
// 

public static class AzureCredentialHelper
{
    public static ClientSecretCredential GetClientSecretCredential(
        IConfiguration configuration) => new ClientSecretCredential(
            tenantId: configuration["AzureSecurity:TenantId"],
            clientId: configuration["AzureSecurity:ClientId"],
            clientSecret: configuration["AzureSecurity:ClientSecret"]);
}