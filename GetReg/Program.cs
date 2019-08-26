using Microsoft.Win32;

namespace GetReg
{
    class Program
    {
        static void Main(string[] args)
        {
            // The name of the key must include a valid root.
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = "RegistrySetValueExample";
            const string keyName = userRoot + "\\" + subkey;
            
            Registry.SetValue(keyName, "TesteWod_Registro", 1234, RegistryValueKind.QWord);

           var value =  Registry.GetValue(keyName,"TesteWod_Registro", null).ToString();
        }
    }
}
