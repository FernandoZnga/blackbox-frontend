using System.Xml.Serialization;
using System.IO;
using Blackbox.Client.Domain;
using Blackbox.Client.Prop;

namespace Blackbox.Client.src
{
    public class Serialization
    {
        public static string atmId = "ATM-0001";

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
            }
        }

        public static string SerializeCcPinNumber(string ccNumber, string pinNumber)
        {
            CcPinNumber CardInfo = new CcPinNumber
            {
                CcNumber = ccNumber,
                PinNumber = pinNumber,
                AtmId = atmId
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

        public static void DeserializeCcPinNumber(string CardInfo)
        {
            XmlSerializer xml = new XmlSerializer(typeof(CcPinNumber));
            using (StringReader stringReader = new StringReader(CardInfo))
            {
                CcPinNumber ccPinNUmber = (CcPinNumber)(xml.Deserialize(stringReader));
            }
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

        public static string SerializeAccountBalance(int account)
        {
            AccountBalance accountInfo = new AccountBalance
            {
                AccountId = account,
                AtmId = atmId
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

        internal static string SerializeAccountBalanceResponse(int accountId, double balance, int response)
        {
            AccountBalanceResponse accountInfo = new AccountBalanceResponse
            {
                AccountId = accountId,
                Balance = balance,
                Response = response
            };

            XmlSerializer xml = new XmlSerializer(typeof(AccountBalanceResponse));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, accountInfo);
                return stringWriter.ToString();
            };
        }

        internal static WithdrawResponse DeserializeWithdrawResponse(string accountInfo)
        {
            XmlSerializer xml = new XmlSerializer(typeof(WithdrawResponse));
            using (StringReader stringReader = new StringReader(accountInfo))
            {
                return (WithdrawResponse)(xml.Deserialize(stringReader));
            }
        }

        internal static string SerializeWithdrawResponse(int accountId, double newBalance, string accountTypeName, int response)
        {
            WithdrawResponse accountInfo = new WithdrawResponse
            {
                AccountId = accountId,
                NewBalance = newBalance,
                AccountTypeName = accountTypeName,
                Response = response
            };

            XmlSerializer xml = new XmlSerializer(typeof(WithdrawResponse));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, accountInfo);
                return stringWriter.ToString();
            };
        }

        internal static DepositResponse DeserializeDepositResponse(string accountInfo)
        {
            XmlSerializer xml = new XmlSerializer(typeof(DepositResponse));
            using (StringReader stringReader = new StringReader(accountInfo))
            {
                return (DepositResponse)xml.Deserialize(stringReader);
            }
        }

        internal static string SerializeDepositResponse(int accountId, double newBalance, string accountTypeName, int response)
        {
            DepositResponse accountInfo = new DepositResponse
            {
                AccountId = accountId,
                NewBalance = newBalance,
                AccountTypeName = accountTypeName,
                Response = response
            };

            XmlSerializer xml = new XmlSerializer(typeof(DepositResponse));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, accountInfo);
                return stringWriter.ToString();
            };
        }

        internal static TransferResponse DeserializeTransferResponse(string accountInfo)
        {
            XmlSerializer xml = new XmlSerializer(typeof(TransferResponse));
            using (StringReader stringReader = new StringReader(accountInfo))
            {
                return (TransferResponse)(xml.Deserialize(stringReader));
            }
        }

        internal static string SerializeTransferResponse(int accountId, double newBalance, string accountTypeName, int accountIdDestiny, int response)
        {
            TransferResponse accountInfo = new TransferResponse
            {
                AccountId = accountId,
                NewBalance = newBalance,
                AccountTypeName = accountTypeName,
                AccountIdDestiny = accountIdDestiny,
                Response = response
            };

            XmlSerializer xml = new XmlSerializer(typeof(TransferResponse));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, accountInfo);
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

        public static string SerializeWithdraw(int accountId, double amount)
        {
            Withdraw accountInfo = new Withdraw
            {
                AccountId = accountId,
                Amount = amount,
                AtmId = atmId
            };

            XmlSerializer xml = new XmlSerializer(typeof(Withdraw));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, accountInfo);
                accountInfo.Key = GenerateKey.MD5(stringWriter.ToString());
                StringWriter stringWriterNew = new StringWriter();
                xml.Serialize(stringWriterNew, accountInfo);
                return stringWriterNew.ToString();
            };
        }

        internal static string SerializeDeposit(int accountId, double amount)
        {
            Deposit accountInfo = new Deposit
            {
                AccountId = accountId,
                Amount = amount,
                AtmId = atmId
            };

            XmlSerializer xml = new XmlSerializer(typeof(Deposit));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, accountInfo);
                accountInfo.Key = GenerateKey.MD5(stringWriter.ToString());
                StringWriter stringWriterNew = new StringWriter();
                xml.Serialize(stringWriterNew, accountInfo);
                return stringWriterNew.ToString();
            };
        }

        internal static string SerializeTransfer(int accountId, double transferAmount, int transferAccount)
        {
            Transfer accountInfo = new Transfer
            {
                AccountId = accountId,
                Amount = transferAmount,
                AccountIdDestiny = transferAccount,
                AtmId = atmId
            };

            XmlSerializer xml = new XmlSerializer(typeof(Transfer));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, accountInfo);
                accountInfo.Key = GenerateKey.MD5(stringWriter.ToString());
                StringWriter stringWriterNew = new StringWriter();
                xml.Serialize(stringWriterNew, accountInfo);
                return stringWriterNew.ToString();
            };
        }
    }
}