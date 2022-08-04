namespace WiredBrainCoffee.StorageApp.Repositories
{
    public static class RepositoryExtension
    {
        public static void AddBatch<T>(this IContravariance<T> repository, T[] items)
        {
            foreach (var item in items)
            {
                repository.Add(item);
            }
            repository.Save();
        }
    }
}
