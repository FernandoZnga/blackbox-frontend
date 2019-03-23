using System.Xml.Serialization;
using System.IO;
using Blackbox.Client.Domain;
using Blackbox.Client.Prop;
using System;

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
                CcNumber = GenerateKey.MD5(ccNumber),
                PinNumber = GenerateKey.MD5(pinNumber),
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

        internal static string SerializeChangePinResponse(int accountId, int response)
        {
            ChangePinResponse changePinResponse = new ChangePinResponse
            {
                AccountId = accountId,
                Response = response
            };

            XmlSerializer xml = new XmlSerializer(typeof(ChangePinResponse));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, changePinResponse);
                return stringWriter.ToString();
            };
        }

        internal static PayEneeResponse DeserializePayEneeResponse(string xmlText)
        {
            XmlSerializer xml = new XmlSerializer(typeof(PayEneeResponse));
            using (StringReader stringReader = new StringReader(xmlText))
            {
                return (PayEneeResponse)(xml.Deserialize(stringReader));
            }
        }

        internal static string SerializePayEneeResponse(int accountId, double newBalance, string accountTypeName, int response)
        {
            PayEneeResponse payEneeResponse = new PayEneeResponse
            {
                AccountId = accountId,
                NewBalance = newBalance,
                AccountTypeName = accountTypeName,
                Response = response
            };

            XmlSerializer xml = new XmlSerializer(typeof(PayEneeResponse));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, payEneeResponse);
                return stringWriter.ToString();
            };
        }

        internal static string SerializePaySanaaResponse(int accountId, double newBalance, string accountTypeName, int response)
        {
            PaySanaaResponse paySanaaResponse = new PaySanaaResponse
            {
                AccountId = accountId,
                NewBalance = newBalance,
                AccountTypeName = accountTypeName,
                Response = response
            };

            XmlSerializer xml = new XmlSerializer(typeof(PaySanaaResponse));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, paySanaaResponse);
                return stringWriter.ToString();
            };
        }

        internal static string SerializePayHondutelResponse(int accountId, double newBalance, string accountTypeName, int response)
        {
            PayHondutelResponse payHondutelResponse = new PayHondutelResponse
            {
                AccountId = accountId,
                NewBalance = newBalance,
                AccountTypeName = accountTypeName,
                Response = response
            };

            XmlSerializer xml = new XmlSerializer(typeof(PaySanaaResponse));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, payHondutelResponse);
                return stringWriter.ToString();
            };
        }

        internal static PaySanaaResponse DeserializePaySanaaResponse(string xmlText)
        {
            XmlSerializer xml = new XmlSerializer(typeof(PaySanaaResponse));
            using (StringReader stringReader = new StringReader(xmlText))
            {
                return (PaySanaaResponse)(xml.Deserialize(stringReader));
            }
        }

        internal static PayHondutelResponse DeserializePayHondutelResponse(string xmlText)
        {
            XmlSerializer xml = new XmlSerializer(typeof(PayHondutelResponse));
            using (StringReader stringReader = new StringReader(xmlText))
            {
                return (PayHondutelResponse)(xml.Deserialize(stringReader));
            }
        }

        internal static ChangePinResponse DeserializeChangePinResponse(string xmlText)
        {
            XmlSerializer xml = new XmlSerializer(typeof(ChangePinResponse));
            using (StringReader stringReader = new StringReader(xmlText))
            {
                return (ChangePinResponse)(xml.Deserialize(stringReader));
            }
        }

        internal static MyTransactionsResponse DeserializeMyTransactionsResponse(string xmlText)
        {
            XmlSerializer xml = new XmlSerializer(typeof(MyTransactionsResponse));
            using (StringReader stringReader = new StringReader(xmlText))
            {
                return (MyTransactionsResponse)(xml.Deserialize(stringReader));
            }
        }

        internal static string SerializeMyTransactionsResponse(int accountId, int response)
        {
            MyTransactionsResponse myTransactionsResponse = new MyTransactionsResponse
            {
                AccountId = accountId,
                Response = response
            };

            XmlSerializer xml = new XmlSerializer(typeof(MyTransactionsResponse));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, myTransactionsResponse);
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

        internal static ExchangeViewResponse DeserializeExchangeViewResponse(string xmlText)
        {
            XmlSerializer xml = new XmlSerializer(typeof(ExchangeViewResponse));
            using (StringReader stringReader = new StringReader(xmlText))
            {
                return (ExchangeViewResponse)(xml.Deserialize(stringReader));
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

        internal static string SerializeExchangeViewResponse(string currency, double compra, double venta, int response)
        {
            ExchangeViewResponse exchangeResponse = new ExchangeViewResponse
            {
                Currency = currency,
                Compra = compra,
                Venta = venta,
                Response = response
            };

            XmlSerializer xml = new XmlSerializer(typeof(ExchangeViewResponse));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, exchangeResponse);
                return stringWriter.ToString();
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

        internal static string SerializeChangePin(int account, string currentPin, string newPin)
        {
            ChangePin changePin = new ChangePin
            {
                Account = account,
                CurrentPin = GenerateKey.MD5(currentPin),
                NewPin = GenerateKey.MD5(newPin),
                AtmId = atmId
            };

            XmlSerializer xml = new XmlSerializer(typeof(ChangePin));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, changePin);
                changePin.Key = GenerateKey.MD5(stringWriter.ToString());
                StringWriter stringWriterNew = new StringWriter();
                xml.Serialize(stringWriterNew, changePin);
                return stringWriterNew.ToString();
            };
        }

        internal static string SerializePayEnee(int accountId, int billingId)
        {
            PayEnee payEnee = new PayEnee
            {
                AccountId = accountId,
                BillId = billingId,
                AtmId = atmId
            };

            XmlSerializer xml = new XmlSerializer(typeof(PayEnee));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, payEnee);
                payEnee.Key = GenerateKey.MD5(stringWriter.ToString());
                StringWriter stringWriterNew = new StringWriter();
                xml.Serialize(stringWriterNew, payEnee);
                return stringWriterNew.ToString();
            };
        }

        internal static string SerializePaySanaa(int accountId, int billingId)
        {
            PaySanaa paySanaa = new PaySanaa
            {
                AccountId = accountId,
                BillId = billingId,
                AtmId = atmId
            };

            XmlSerializer xml = new XmlSerializer(typeof(PaySanaa));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, paySanaa);
                paySanaa.Key = GenerateKey.MD5(stringWriter.ToString());
                StringWriter stringWriterNew = new StringWriter();
                xml.Serialize(stringWriterNew, paySanaa);
                return stringWriterNew.ToString();
            };
        }

        internal static string SerializePayHondutel(int accountId, int billingId)
        {
            PayHondutel payHondutel = new PayHondutel
            {
                AccountId = accountId,
                BillId = billingId,
                AtmId = atmId
            };

            XmlSerializer xml = new XmlSerializer(typeof(PayHondutel));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, payHondutel);
                payHondutel.Key = GenerateKey.MD5(stringWriter.ToString());
                StringWriter stringWriterNew = new StringWriter();
                xml.Serialize(stringWriterNew, payHondutel);
                return stringWriterNew.ToString();
            };
        }

        internal static string SerializeMyTransactions(int accountId)
        {
            MyTransactions myTransactions = new MyTransactions
            {
                AccountId = accountId,
                AtmId = atmId
            };

            XmlSerializer xml = new XmlSerializer(typeof(MyTransactions));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, myTransactions);
                myTransactions.Key = GenerateKey.MD5(stringWriter.ToString());
                StringWriter stringWriterNew = new StringWriter();
                xml.Serialize(stringWriterNew, myTransactions);
                return stringWriterNew.ToString();
            };
        }

        internal static string SerializeExchangeView(string currency)
        {
            ExchangeView myTransactions = new ExchangeView
            {
                Currency = currency,
                AtmId = atmId
            };

            XmlSerializer xml = new XmlSerializer(typeof(ExchangeView));
            using (StringWriter stringWriter = new StringWriter())
            {
                xml.Serialize(stringWriter, myTransactions);
                myTransactions.Key = GenerateKey.MD5(stringWriter.ToString());
                StringWriter stringWriterNew = new StringWriter();
                xml.Serialize(stringWriterNew, myTransactions);
                return stringWriterNew.ToString();
            };
        }
    }
}