using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PortableHotspotWindows
{
    class SerialKeyIOClass
    {
        SerialOperations.Operations opr = new SerialOperations.Operations();
        public static String LicencePath = Application.StartupPath + @"\licence.key";
        private String EncryptionKey = @"YKP9J76DEM";
        public void WriteLicence(String Key)
        {
            if (File.Exists(LicencePath) == true)
            {
                LoggerClass.WriteLog("Licence Deleted");
                File.Delete(LicencePath);
            }
            File.WriteAllText(LicencePath, CryptographyClass.Encrypt(Key, EncryptionKey));
        }

        public Boolean ReadLicence()
        {
            try
            {
                String Key = CryptographyClass.Decrypt(File.ReadAllText(LicencePath), EncryptionKey);
                if (Key != "")
                {
                    if (opr.VerifyCode(Key) == true)
                    {
                        return true;
                    }
                    else
                    {
                        LoggerClass.WriteLog("Non Valid Licence");
                        File.Delete(LicencePath);
                        return false;
                    }
                }
                else
                {
                    LoggerClass.WriteLog("Non Valid Licence");
                    File.Delete(LicencePath);
                    return false;
                }
            }
            catch (Exception ex)
            {
                LoggerClass.WriteLog(ex.Message);
                return false;
            }

        }
    }
}
