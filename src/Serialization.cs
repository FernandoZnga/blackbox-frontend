using System.Xml.Serialization;
using System.IO;
using Blackbox.Server.Prop;
using Blackbox.Client.src;
using System;

namespace Blackbox.Server
{
    public class Serialization
    {
        public static string SerializeCcPinNumber(string ccNumber, string pinNumber)
        {
            CcPinNumber CardInfo = new CcPinNumber
            {
                CcNumber = ccNumber,
                PinNumber = pinNumber
            };

            XmlSerializer xml = new XmlSerializer(typeof(CcPinNumber));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, CardInfo);
                CardInfo.Key = GenerateKey.MD5(stringWriter.ToString());
                StringWriter stringWriterNew = new StringWriter();
                xml.Serialize(stringWriterNew, CardInfo);
                return stringWriterNew.ToString();
            };
        }

        public static string SerializeGeneralResponse(int response)
        {
            GeneralResponse generalResponse = new GeneralResponse
            {
                Response = response
            };

            XmlSerializer xml = new XmlSerializer(typeof(GeneralResponse));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, generalResponse);
                return stringWriter.ToString();
            };
        }

        public static void DeserializeCcPinNumber(string CardInfo)
        {
            XmlSerializer xml = new XmlSerializer(typeof(CcPinNumber));
            using (StringReader stringReader = new StringReader(CardInfo))
            {
                CcPinNumber ccPinNUmber = (CcPinNumber)(xml.Deserialize(stringReader));
            }
        }
        public static string SerializeAccountBalance(int account)
        {
            AccountBalance accountInfo = new AccountBalance
            {
                AccountId = account
            };

            XmlSerializer xml = new XmlSerializer(typeof(AccountBalance));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, accountInfo);
                accountInfo.Key = GenerateKey.MD5(stringWriter.ToString());
                StringWriter stringWriterNew = new StringWriter();
                xml.Serialize(stringWriterNew, accountInfo);
                return stringWriterNew.ToString();
            };
        }

        public static string SerializeCcPinNumberResponse(int account, int response)
        {
            CcPinNumberResponse ccPinNumberResponse = new CcPinNumberResponse
            {
                Account = account,
                Response = response
            };

            XmlSerializer xml = new XmlSerializer(typeof(CcPinNumberResponse));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, ccPinNumberResponse);
                return stringWriter.ToString();
            };
        }

        internal static string SerializeAccountBalanceResponse(int accountId, double balance, int response)
        {
            AccountBalanceResponse accountBalanceResponse = new AccountBalanceResponse
            {
                AccountId = accountId,
                Balance = balance,
                Response = response
            };

            XmlSerializer xml = new XmlSerializer(typeof(AccountBalanceResponse));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, accountBalanceResponse);
                return stringWriter.ToString();
            };
        }

        public static CcPinNumberResponse DeserializeCcPinNumberResponse(string accountInfo)
        {
            XmlSerializer xml = new XmlSerializer(typeof(CcPinNumberResponse));
            using (StringReader stringReader = new StringReader(accountInfo))
            {
                return (CcPinNumberResponse)(xml.Deserialize(stringReader));
            }
        }
        public static AccountBalanceResponse DeserializeAccountBalanceResponse(string accountInfo)
        {
            XmlSerializer xml = new XmlSerializer(typeof(AccountBalanceResponse));
            using (StringReader stringReader = new StringReader(accountInfo))
            {
                return (AccountBalanceResponse)(xml.Deserialize(stringReader));
            }
        }
        public static GeneralResponse DeserializeGeneralResponse(string response)
        {
            XmlSerializer xml = new XmlSerializer(typeof(GeneralResponse));
            using (StringReader stringReader = new StringReader(response))
            {
                GeneralResponse generalResponse = (GeneralResponse)xml.Deserialize(stringReader);
                return generalResponse;
            }
        }
    }
}