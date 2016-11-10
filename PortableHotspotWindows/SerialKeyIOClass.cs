using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortableHotspotWindows
{
    class SerialKeyIOClass
    {
        SerialOperations.Operations opr = new SerialOperations.Operations();
        public void WriteLicence(String Key)
        {
            System.IO.File.WriteAllText(Application.StartupPath + @"\licence.key", Key);
        }

        public Boolean ReadLicence()
        {
            try
            {
                String Key = System.IO.File.ReadAllText(Application.StartupPath + @"\licence.key");
                if(Key != "")
                {
                    if(opr.VerifyCode(Key) == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch(Exception)
            {
                return false;
            }
            
        }
    }
}
