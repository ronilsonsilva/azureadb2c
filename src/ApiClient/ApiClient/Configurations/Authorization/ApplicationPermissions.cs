using System.Linq;

namespace ApiClient.Configurations.Authorization
{
    internal static class ApplicationPermissions
    {
        public const string ReadAllProduto = "produto.read.all";
        public const string CreateAllProduto = "produto.create.all";
        public const string UpdateAllProduto = "produto.update.all";
        public const string DeleteAllProduto = "produto.delete.all";

        public static string[] All => typeof(ApplicationPermissions)
            .GetFields()
            .Where(f => f.Name != nameof(All))
            .Select(f => f.GetValue(null) as string)
            .ToArray();
    }
}
