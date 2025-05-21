using CommandPattern.Receivers;

namespace CommandPattern.Commands;

public class MusicPlayerPlayCommand(MusicPlayer musicPlayer) : ICommand
{
    public void Execute()
    {
        musicPlayer.Play();
    }

    public void Undo()
    {
        musicPlayer.Pause();
    }
}

public class MusicPlayerPauseCommand(MusicPlayer musicPlayer) : ICommand
{
    public void Execute()
    {
        musicPlayer.Pause();
    }

    public void Undo()
    {
        musicPlayer.Play();
    }
}