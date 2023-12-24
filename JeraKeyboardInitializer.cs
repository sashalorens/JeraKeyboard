namespace JeraKeyboard
{
    public class JeraKeyboardInitializer
    {
        public void Init()
        {
            var kh = new KeyboardHook(true);
            kh.KeyDown += Kh_KeyDown;
            // Application.Run();
        }
        private void Kh_KeyDown(Keys key, bool Shift, bool Ctrl, bool Alt)
        {
        }
    }


}
