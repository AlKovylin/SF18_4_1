namespace SF18_4_1
{
    /// <summary>
    /// Класс команды на загрузку видео.
    /// </summary>
    class CommandDownload : Command
    {
        FileOperations reseiver;

        public CommandDownload(FileOperations reseiver)
        {
            this.reseiver = reseiver;
        }

        public override void Run()
        {
            reseiver.DownloadFile();
        }
    }
}
