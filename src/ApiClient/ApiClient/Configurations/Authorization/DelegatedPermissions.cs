using System.Linq;

namespace ApiClient.Configurations.Authorization
{
    internal static class DelegatedPermissions
    {
        public const string ScopeRead = "produto.read";
        public const string ScopeCreate = "produto.create";
        public const string ScopeDelete = "produto.delete";
        public const string ScopeUpdate = "produto.update";

        public static string[] All => typeof(DelegatedPermissions)
            .GetFields()
            .Where(f => f.Name != nameof(All))
            .Select(f => f.GetValue(null) as string)
            .ToArray();
    }
}
