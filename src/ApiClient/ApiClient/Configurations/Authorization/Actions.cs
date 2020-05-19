using System.Linq;

namespace ApiClient.Configurations.Authorization
{
    internal static class Actions
    {
        public const string ProdutoRead = "Produto/Read";
        public const string ProdutoCreate = "Produto/Create";
        public const string ProdutoDelete = "Produto/Delete";
        public const string ProdutoUpdate = "Produto/Update";

        public static string[] All => typeof(Actions)
            .GetFields()
            .Where(f => f.Name != nameof(All))
            .Select(f => f.GetValue(null) as string)
            .ToArray();
    }
}
