﻿using Blackbox.Client.src;
using System;
using System.Xml.Linq;

namespace Blackbox.Client.Prop
{
    public class Handle
    {
        public static string api;

        public static void ReadText(string xmlText)
        {
            if (xmlText == "999")
            {
                Main.ShowInvalidTokenMessage();
            }
            else
            {
                //xmlText = xmlText.Substring(0, xmlText.IndexOf("<EOF>", 0));
                XDocument xmlNode = XDocument.Parse(xmlText);
                foreach (var head in xmlNode.Elements())
                {
                    api = head.Name.ToString();
                    if (api == "GeneralResponse")
                    {
                        var generalResponse = Serialization.DeserializeGeneralResponse(xmlText);
                        GeneralResponse response = new GeneralResponse
                        {
                            Response = generalResponse.Response
                        };
                        if (GenerateKey.MD5(Serialization.
                            SerializeGeneralResponse(response.Response)) != generalResponse.Key ||
                            generalResponse.Response == 601)
                        {
                            Main.ShowInvalidTokenMessage();
                        }
                        else if (generalResponse.Response == 500)
                        {
                            Main.ShowInvalidCcPinNumberMessage();
                        }
                        else if (generalResponse.Response == 501)
                        {
                            Home.ShowBalanceErrorMessage();
                        }
                        else if (generalResponse.Response == 701)
                        {
                            Home.ShowCheckAmount();
                        }
                        else if (generalResponse.Response == 801)
                        {
                            Home.ShowErrorChangePin();
                        }
                        else if (generalResponse.Response == 901)
                        {
                            Home.ShowAccountInvalid();
                        }
                        else if (generalResponse.Response == 902)
                        {
                            Home.ShowBillingIdInvalid(generalResponse);
                        }
                        else if (generalResponse.Response == 903)
                        {
                            Home.ShowNotEnoughBalance(generalResponse);
                        }
                        else if (generalResponse.Response == 904)
                        {
                            Home.ShowBillAlreadyPayed(generalResponse);
                        }
                        else if (generalResponse.Response == 999)
                        {
                            Home.ShowNoTransactionsMsg();
                        }
                    }
                    else if (api == "CcPinNumberResponse")
                    {
                        CcPinNumberResponse ccPinNumberResponse = Serialization.DeserializeCcPinNumberResponse(xmlText);
                        CcPinNumberResponse ccPinNumber = new CcPinNumberResponse
                        {
                            Account = ccPinNumberResponse.Account,
                            Response = ccPinNumberResponse.Response
                        };
                        if (GenerateKey.MD5(Serialization.SerializeCcPinNumberResponse(ccPinNumber.Account, ccPinNumber.Response)) != ccPinNumberResponse.Key)
                        {
                            Main.ShowInvalidTokenMessage();
                        }
                        else
                        {
                            Main.ShowHome(ccPinNumberResponse);
                        }
                    }
                    else if (api == "AccountBalanceResponse")
                    {
                        var accountBalanceResponse = Serialization.DeserializeAccountBalanceResponse(xmlText);
                        AccountBalanceResponse accountBalance = new AccountBalanceResponse
                        {
                            AccountId = accountBalanceResponse.AccountId,
                            Balance = accountBalanceResponse.Balance,
                            Response = accountBalanceResponse.Response
                        };
                        if (GenerateKey.MD5(Serialization.SerializeAccountBalanceResponse(accountBalance.AccountId, accountBalance.Balance, accountBalance.Response)) != accountBalanceResponse.Key)
                        {
                            Main.ShowInvalidTokenMessage();
                        }
                        else
                        {
                            Home.ShowAccountBalance(accountBalanceResponse);
                        }
                    }
                    else if (api == "WithdrawResponse")
                    {
                        var withdrawResponse = Serialization.DeserializeWithdrawResponse(xmlText);
                        WithdrawResponse withdraw = new WithdrawResponse
                        {
                            AccountId = withdrawResponse.AccountId,
                            NewBalance = withdrawResponse.NewBalance,
                            AccountTypeName = withdrawResponse.AccountTypeName,
                            Response = withdrawResponse.Response
                        };
                        if (GenerateKey.MD5(Serialization.SerializeWithdrawResponse(withdraw.AccountId, withdraw.NewBalance, withdraw.AccountTypeName, withdraw.Response)) != withdrawResponse.Key)
                        {
                            Main.ShowInvalidTokenMessage();
                        }
                        else
                        {
                            Home.WithdrawResult(withdraw);
                        }
                    }
                    else if (api == "DepositResponse")
                    {
                        var depositResponse = Serialization.DeserializeDepositResponse(xmlText);
                        DepositResponse deposit = new DepositResponse
                        {
                            AccountId = depositResponse.AccountId,
                            NewBalance = depositResponse.NewBalance,
                            AccountTypeName = depositResponse.AccountTypeName,
                            Response = depositResponse.Response
                        };
                        if (GenerateKey.MD5(Serialization.SerializeDepositResponse(deposit.AccountId, deposit.NewBalance, deposit.AccountTypeName, deposit.Response)) != depositResponse.Key)
                        {
                            Main.ShowInvalidTokenMessage();
                        }
                        else
                        {
                            Home.DepositResult(deposit);
                        }
                    }
                    else if (api == "TransferResponse")
                    {
                        var transferResponse = Serialization.DeserializeTransferResponse(xmlText);
                        TransferResponse transfer = new TransferResponse
                        {
                            AccountId = transferResponse.AccountId,
                            NewBalance = transferResponse.NewBalance,
                            AccountTypeName = transferResponse.AccountTypeName,
                            AccountIdDestiny = transferResponse.AccountIdDestiny,
                            Response = transferResponse.Response
                        };
                        if (GenerateKey.MD5(Serialization.SerializeTransferResponse(transfer.AccountId, transfer.NewBalance, transfer.AccountTypeName, transfer.AccountIdDestiny, transfer.Response)) != transferResponse.Key)
                        {
                            Main.ShowInvalidTokenMessage();
                        }
                        else
                        {
                            Home.TransferResult(transfer);
                        }
                    }
                    else if (api == "ChangePinResponse")
                    {
                        var changePinResponse = Serialization.DeserializeChangePinResponse(xmlText);
                        ChangePinResponse changePin = new ChangePinResponse
                        {
                            AccountId = changePinResponse.AccountId,
                            Response = changePinResponse.Response
                        };
                        if (GenerateKey.MD5(Serialization.SerializeChangePinResponse(changePin.AccountId, changePin.Response)) != changePinResponse.Key)
                        {
                            Main.ShowInvalidTokenMessage();
                        }
                        else
                        {
                            Home.ChangePinResult(changePin);
                        }
                    }
                    else if (api == "PayEneeResponse")
                    {
                        var payEneeResponse = Serialization.DeserializePayEneeResponse(xmlText);
                        PayEneeResponse payEnee = new PayEneeResponse
                        {
                            AccountId = payEneeResponse.AccountId,
                            NewBalance = payEneeResponse.NewBalance,
                            AccountTypeName = payEneeResponse.AccountTypeName,
                            Response = payEneeResponse.Response
                        };
                        if (GenerateKey.MD5(Serialization.SerializePayEneeResponse(payEnee.AccountId, payEnee.NewBalance, payEnee.AccountTypeName, payEnee.Response)) != payEneeResponse.Key)
                        {
                            Main.ShowInvalidTokenMessage();
                        }
                        else
                        {
                            Home.PayEneeResult(payEnee);
                        }
                    }
                    else if (api == "PaySanaaResponse")
                    {
                        var paySanaaResponse = Serialization.DeserializePaySanaaResponse(xmlText);
                        PaySanaaResponse paySanaa = new PaySanaaResponse
                        {
                            AccountId = paySanaaResponse.AccountId,
                            NewBalance = paySanaaResponse.NewBalance,
                            AccountTypeName = paySanaaResponse.AccountTypeName,
                            Response = paySanaaResponse.Response
                        };
                        if (GenerateKey.MD5(Serialization.SerializePaySanaaResponse(paySanaa.AccountId, paySanaa.NewBalance, paySanaa.AccountTypeName, paySanaa.Response)) != paySanaaResponse.Key)
                        {
                            Main.ShowInvalidTokenMessage();
                        }
                        else
                        {
                            Home.PaySanaaResult(paySanaa);
                        }
                    }
                    else if (api == "PayHondutelResponse")
                    {
                        var payHondutelResponse = Serialization.DeserializePaySanaaResponse(xmlText);
                        PayHondutelResponse payHondutel = new PayHondutelResponse
                        {
                            AccountId = payHondutelResponse.AccountId,
                            NewBalance = payHondutelResponse.NewBalance,
                            AccountTypeName = payHondutelResponse.AccountTypeName,
                            Response = payHondutelResponse.Response
                        };
                        if (GenerateKey.MD5(Serialization.SerializePayHondutelResponse(payHondutel.AccountId, payHondutel.NewBalance, payHondutel.AccountTypeName, payHondutel.Response)) != payHondutelResponse.Key)
                        {
                            Main.ShowInvalidTokenMessage();
                        }
                        else
                        {
                            Home.PayHondutelResult(payHondutel);
                        }
                    }
                    else if (api == "MyTransactionsResponse")
                    {
                        MyTransactionsResponse myTransactionsResponse = Serialization.DeserializeMyTransactionsResponse(xmlText);
                        AccountBalanceResponse myTransactions = new AccountBalanceResponse
                        {
                            AccountId = myTransactionsResponse.AccountId,
                            Response = myTransactionsResponse.Response
                        };
                        if (GenerateKey.MD5(Serialization.SerializeMyTransactionsResponse(myTransactions.AccountId, myTransactions.Response)) != myTransactionsResponse.Key)
                        {
                            Main.ShowInvalidTokenMessage();
                        }
                        else
                        {
                            Home.ShowMyTransactionsMsg(myTransactionsResponse);
                        }
                    }
                    else if (api == "ExchangeViewResponse")
                    {
                        ExchangeViewResponse exchangeViewResponse = Serialization.DeserializeExchangeViewResponse(xmlText);
                        ExchangeViewResponse exchangeView = new ExchangeViewResponse
                        {
                            Currency = exchangeViewResponse.Currency,
                            Compra = exchangeViewResponse.Compra,
                            Venta = exchangeViewResponse.Venta,
                            Response = exchangeViewResponse.Response
                        };
                        if (GenerateKey.MD5(Serialization.SerializeExchangeViewResponse(exchangeView.Currency, exchangeView.Compra, exchangeView.Venta, exchangeView.Response)) != exchangeViewResponse.Key)
                        {
                            Main.ShowInvalidTokenMessage();
                        }
                        else
                        {
                            Home.ExchangeViewResult(exchangeViewResponse);
                        }
                    }
                }
            }
        }
    }
}
