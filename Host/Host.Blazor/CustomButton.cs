namespace Host.Blazor;
public class CustomButton : ButtonComponentBase
{
    public override string BackColor => cc.LightGray.ToWebColor();
    public override string TextColor => cc.Black.ToWebColor();
    public override string DisabledColor => cc.Gray.ToWebColor();
}