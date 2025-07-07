
namespace ArevaloAgendaContactos.Data
{
    public static class LogService
    {
        static string LogPath =>
            Path.Combine(FileSystem.AppDataDirectory, $"Logs_<<<Arevalo>>>.txt");

        public static async Task AppendAsync(string nombre)
        {
            var registro =
                $"Se incluyó el registro {nombre} el {DateTime.Now:dd/MM/yyyy HH:mm}\n";
            await File.AppendAllTextAsync(LogPath, registro);
        }

        public static async Task<string[]> ReadAllAsync()
        {
            if (!File.Exists(LogPath)) return [];
            return await File.ReadAllLinesAsync(LogPath);
        }
    }
}
