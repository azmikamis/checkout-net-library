﻿using Checkout.Helpers;
using Checkout.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checkout
{
    public class ApiUrls
    {
        private static string _baseApiUri= AppSettings.BaseApiUri;
        private static string _cardTokensApiUri;
        private static string _paymentTokensApiUri;
        private static string _cardProvidersUri;
        private static string _localPaymentProvidersUri;
        private static string _cardChargesApiUri;
        private static string _cardTokenChargesApiUri;
        private static string _defaultCardChargesApiUri;
        private static string _chargeRefundsApiUri;
        private static string _captureChargesApiUri;
        private static string _updateChargesApiUri;

        private static string _chargesApiUri;
        private static string _chargeApiUri;

        private static string _customersApiUri;
        private static string _customerApiUri;

        private static string _cardsApiUri;
        private static string _cardApiUri;

        public static string Charges
        {
            get
            {
                return _chargesApiUri ?? (_chargesApiUri = string.Concat(_baseApiUri, "/charges"));
            }
        }

        public static string Charge
        {
            get
            {
                return _chargeApiUri ?? (_chargeApiUri = string.Concat(_baseApiUri, "/charges/{0}"));
            }
        }

        public static string CaptureCharge
        {
            get
            {
                return _captureChargesApiUri ?? (_captureChargesApiUri = string.Concat(_baseApiUri, "/charges/{0}/capture"));
            }
        }

        public static string RefundCharge
        {
            get
            {
                return _chargeRefundsApiUri ?? (_chargeRefundsApiUri = string.Concat(_baseApiUri, "/charges/{0}/refund"));
            }
        }

        public static string VoidCharge
        {
            get
            {
                return _chargeRefundsApiUri ?? (_chargeRefundsApiUri = string.Concat(_baseApiUri, "/charges/{0}/refund"));
            }
        }

        public static string DefaultCardCharge
        {
            get
            {
                return _defaultCardChargesApiUri ?? (_defaultCardChargesApiUri = string.Concat(_baseApiUri, "/charges/customer"));
            }
        }

        public static string CardTokenCharge
        {
            get
            {
                return _cardTokenChargesApiUri ?? (_cardTokenChargesApiUri = string.Concat(_baseApiUri, "/charges/token"));
            }
        }

        public static string CardCharge
        {
            get
            {
                return _cardChargesApiUri ?? (_cardChargesApiUri = string.Concat(_baseApiUri, "/charges/card"));
            }
        }

        public static string CardToken
        {
            get
            {
                return _cardTokensApiUri ?? (_cardTokensApiUri = string.Concat(_baseApiUri, "/tokens/card"));
            }
        }

        public static string PaymentToken
        {
            get
            {
                return _paymentTokensApiUri ?? (_paymentTokensApiUri = string.Concat(_baseApiUri, "/tokens/payment"));
            }
        }

        public static string CardProviders
        {
            get
            {
                return _cardProvidersUri ?? (_cardProvidersUri = string.Concat(_baseApiUri, "/providers/cards"));
            }
        }

        public static string LocalPaymentProviders
        {
            get
            {
                return _localPaymentProvidersUri ?? (_localPaymentProvidersUri = string.Concat(_baseApiUri, "/providers/localpayments"));
            }
        }

        public static string Customers
        {
            get
            {
                return _customersApiUri ?? (_customersApiUri = string.Concat(_baseApiUri, "/customers"));
            }
        }
        public static string Customer
        {
            get
            {
                return _customerApiUri ?? (_customerApiUri = string.Concat(_baseApiUri, "/customers/{0}"));
            }
        }

        public static string Cards {
            get
            {
                return _cardsApiUri ?? (_cardsApiUri = string.Concat(_baseApiUri, "/customers/{0}/cards"));
            }
        }
        public static string Card
        {
            get
            {
                return _cardApiUri ?? (_cardApiUri = string.Concat(_baseApiUri, "/customers/{0}/cards/{1}"));
            }
        }
    }
}