using System.Configuration;
using System.Diagnostics;

namespace JeraKeyboard
{
    public class JeraKB: IJeraKB
    {
        private static KeyboardHook kh;
        public void Init(string? path)
        {
            kh = new KeyboardHook(true);
            OverridePath(path);
            kh.KeyDown += Kh_KeyDown;

            // Application.Run();
        }

        public bool IsActive()
        {
            if (kh != null)
            {
                return kh.GetState();
            }
            return false;
        }

        public bool IsConfigExists()
        {
            bool isExists = ConfigLoader.IsConfigExists();
            return isExists;
        }

        public void Toggle(bool value)
        {
            if (kh  != null)
            {
                kh.Toggle(value);
            }
        }

        public void OverridePath(string? path)
        {
            if (path != null && path != string.Empty)
            {
                ConfigLoader.OverrideConfigPath(path);
                kh.ReloadKH();
                
            }
        }

        private void Kh_KeyDown(Keys key, bool Shift, bool Ctrl, bool Alt)
        {
        }
    }


}
