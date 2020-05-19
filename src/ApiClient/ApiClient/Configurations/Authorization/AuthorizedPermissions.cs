using System.Collections.Generic;

namespace ApiClient.Configurations.Authorization
{
    internal static class AuthorizedPermissions
    {
        /// <summary>
        /// Contains the allowed delegated permissions for each action.
        /// If the caller has one of the allowed ones, they should be allowed
        /// to perform the action.
        /// </summary>
        public static IReadOnlyDictionary<string, string[]> DelegatedPermissionsForActions = new Dictionary<string, string[]>
        {
            [Actions.ProdutoCreate] = new[] { DelegatedPermissions.ScopeCreate },
            [Actions.ProdutoDelete] = new[] { DelegatedPermissions.ScopeDelete },
            [Actions.ProdutoRead] = new[] { DelegatedPermissions.ScopeRead },
            [Actions.ProdutoUpdate] = new[] { DelegatedPermissions.ScopeUpdate }
        };

        /// <summary>
        /// Contains the allowed application permissions for each action.
        /// If the caller has one of the allowed ones, they should be allowed
        /// to perform the action.
        /// </summary>
        public static IReadOnlyDictionary<string, string[]> ApplicationPermissionsForActions = new Dictionary<string, string[]>
        {
            [Actions.ProdutoRead] = new[] { ApplicationPermissions.ReadAllProduto },
            [Actions.ProdutoCreate] = new[] { ApplicationPermissions.CreateAllProduto },
            [Actions.ProdutoUpdate] = new[] { ApplicationPermissions.UpdateAllProduto },
            [Actions.ProdutoDelete] = new[] { ApplicationPermissions.DeleteAllProduto }
        };
    }
}
