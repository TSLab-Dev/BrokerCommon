namespace TSLab.DataSource
{
    public static class BrokerUtils
    {
        public static string GetGroup(this Broker broker)
        {
            switch (broker)
            {
                case Broker.AlorDemo:
                case Broker.AlorMicex:
                case Broker.AlorForts:
                case Broker.AlorDemoForts:
                    return "Alor";
                case Broker.Bittrex:
                case Broker.Bitfinex:
                case Broker.BinanceSpot:
                case Broker.Deribit:
                case Broker.Huobi:
                case Broker.BinanceFutures:
                case Broker.BinanceFutCoin:
                case Broker.Bitmex:
                case Broker.OkxSpot:
                case Broker.OkxFutures:
                case Broker.OkxPerpSwap:
                case Broker.OkxMargin:
                case Broker.ByBitSpot:
                case Broker.ByBitPerpUsdt:
                case Broker.ByBitPerpInverse:
                case Broker.ByBitFutInverse:
                    return "Bitcoin";
                default:
                    return broker.ToString();
            }
        }
    }
}
