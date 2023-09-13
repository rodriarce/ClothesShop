using System.Collections;

public interface InpController 
{
    public void OnEnterNpc();
    public UIManager UIManager { get; set; }
    public string TextToShow { get; set; }

}
