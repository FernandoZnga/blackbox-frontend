using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Blackbox.Server.Prop
{
    public class Handle
    {
        public static string api;

        public static void ReadText(string xmlText)
        {
            //xmlText = xmlText.Substring(0, xmlText.IndexOf("<EOF>", 0));
            XDocument xmlNode = XDocument.Parse(xmlText);
            foreach (var head in xmlNode.Elements())
            {
                api = head.Name.ToString();
                if (api == "GeneralResponse")
                {
                    var generalResponse = Serialization.DeserializeGeneralResponse(xmlText);
                    if (generalResponse.Response == 500)
                    {
                        Main.ShowInvalidCcPinNumberMessage();
                    }
                    else if (generalResponse.Response == 501)
                    {
                        Home.ShowBalanceErrorMessage();
                    }
                }
                else if (api == "CcPinNumberResponse")
                {
                    var ccPinNumberResponse = Serialization.DeserializeCcPinNumberResponse(xmlText);
                    Main.ShowHome(ccPinNumberResponse);
                }
                else if (api == "AccountBalanceResponse")
                {
                    var accountBalanceResponse = Serialization.DeserializeAccountBalanceResponse(xmlText);
                    Home.ShowAccountBalance(accountBalanceResponse);
                }
            }
        }
    }
}
