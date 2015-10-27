namespace Helpers.InputOutputUtils
{
    public interface IMessageProcessor
    {
        void PrintMessageOnLine(string message);

        string ReadMessageOnLine();
    }
}
