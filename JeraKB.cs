using System.Configuration;
using System.Diagnostics;

namespace JeraKeyboard
{
    public class JeraKB: IJeraKB
    {
        public void Init()
        {
            var kh = new KeyboardHook(true);
            kh.KeyDown += Kh_KeyDown;

            string userPath = ConfigurationManager.AppSettings["configPath"] ?? String.Empty;

            // Application.Run();
        }

        public bool IsConfigExists()
        {
            bool isExists = ConfigLoader.IsConfigExists();
            Debug.WriteLine($"config!, {isExists}");
            return isExists;
        }

        private void Kh_KeyDown(Keys key, bool Shift, bool Ctrl, bool Alt)
        {
        }
    }


}
