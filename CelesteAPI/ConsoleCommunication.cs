using StudioCommunication;

namespace CelesteAPI
{
    class ConsoleCommunication : StudioCommunicationBase, IDisposable
    {
        public void Run()
        {
            UpdateLoop();
        }

        protected override void ReadData(Message message)
        {
            switch (message.Id)
            {
                case MessageID.SendState:
                    ProcessSendState(message.Data);
                    break;
                default:
                    base.ReadData(message);
                    break;
            }
        }

        private void ProcessSendState(byte[] data)
        {
            StudioInfo studioInfo = StudioInfo.FromByteArray(data);
            Console.WriteLine($"Current Line: {studioInfo.CurrentLine}");
            Console.WriteLine($"Current Frame in TAS: {studioInfo.CurrentFrameInTas}");
            Console.WriteLine($"Total Frames: {studioInfo.TotalFrames}");
            Console.WriteLine($"Save State Line: {studioInfo.SaveStateLine}");
            Console.WriteLine($"Game Info: {studioInfo.GameInfo}");
            Console.WriteLine($"Level Name: {studioInfo.LevelName}");
            Console.WriteLine($"Chapter Time: {studioInfo.ChapterTime}");
        }

        public void Dispose()
        {
            // Add any necessary cleanup code here
        }
    }
}
