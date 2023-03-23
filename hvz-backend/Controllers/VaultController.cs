using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hvz_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaultController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult> AccessVaultSecret(string secretName)
        {
            var client = new SecretClient(vaultUri: new Uri("https://hvzvault.vault.azure.net/"), credential: new DefaultAzureCredential());
            KeyVaultSecret secret = client.GetSecret(secretName);
            string secretValue = secret.Value;
            return Ok(secretValue);
        }
    }
}
