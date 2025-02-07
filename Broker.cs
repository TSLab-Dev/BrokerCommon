// ReSharper disable IdentifierTypo
namespace TSLab.DataSource
{
    public enum Broker
    {
        Unknown = 0,
        Bitfinex = 1,
        BinanceSpot = 2,
        Deribit = 3,
        AlorDemo = 4,
        AlorMicex = 5,
        AlorForts = 6,
        AlorDemoForts = 7,
        Huobi = 8,
        BinanceFutures = 9,
        Bitmex = 10, // 0x0000000A
        BinanceFutCoin = 11, // 0x0000000B
        OkxSpot = 12, // 0x0000000C
        OkxMargin = 13, // 0x0000000D
        OkxPerpSwap = 14, // 0x0000000E
        OkxFutures = 15, // 0x0000000F
        ByBitSpot = 16, // 0x00000010
        ByBitPerpUsdt = 17, // 0x00000011
        ByBitPerpInverse = 18, // 0x00000012
        ByBitFutInverse = 19, // 0x00000013
        AlorDemoCurrency = 20, // 0x00000014
        AlorOpen = 21, // 0x00000015
        Bitmex_USDT = 22, // 0x00000016
        BinanceMargin = 23, // 0x00000017
        BinanceUSA = 24, // 0x00000018
        Lmax = 25, // 0x00000019
        InteractiveBrokers = 26, // 0x0000001A
        Iqfeed = 27, // 0x0000001B
        Rithmic = 28, // 0x0000001C
        Quik = 29, // 0x0000001D
        QuikLua = 30, // 0x0000001E
        QuikLua2 = 31, // 0x0000001F
        NetInvestor = 32, // 0x00000020
        RicomTrust = 33, // 0x00000021
        Rts = 34, // 0x00000022
        RtsAlor = 35, // 0x00000023
        SmartCom = 36, // 0x00000024
        Tinkoff = 37, // 0x00000025
        Tinkoff2 = 38, // 0x00000026
        Transaq = 39, // 0x00000027
        TransaqAdd = 40, // 0x00000028
        TransaqHft = 41, // 0x00000029
        TransaqJust2Trade = 42, // 0x0000002A
        TransaqSpc = 43, // 0x0000002B
        TransaqDemo = 44, // 0x0000002C
        RtsItinvest = 45, // 0x0000002D
        RtsOpen = 46, // 0x0000002E
        QuikBcs = 47, // 0x0000002F
        QuikOpen = 48, // 0x00000030
        Bittrex = 49, // 0x00000031
        TextFiles = 50, // 0x00000032
        CvsFiles = 51, // 0x00000033
        BinFiles = 52, // 0x00000034
        YahooFinanceFiles = 53, // 0x00000035
        BitgetPerpUsdt = 54, // 0x00000036
        KucoinPerpUsdt = 55, // 0x00000037
		 //Linked providers
        LinkedBinanceSpot = 56,
        LinkedBinanceFutures = 57,
        LinkedBinanceMargin = 58,
        LinkedBinanceFutCoin = 59,
        LinkedByBitSpot = 60,
        LinkedByBitPerpUsdt = 61,
        LinkedByBitPerpInverse = 62,
        LinkedByBitFutInverse = 63,
        LinkedDeribit = 64,
        LinkedOkxSpot = 65,
        LinkedOkxMargin = 66,
        LinkedOkxPerpSwap = 67,
		LinkedOkxFutures = 68,
		CoinBaseSpot = 69,
		CoinBaseFuture = 70,
		CoinBasePerp = 71,
        OkxSpotDemo = 72,
        OkxMarginDemo = 73,
        OkxPerpSwapDemo = 74,
        OkxFuturesDemo = 75,
        ByBitSpotDemo = 76,
        ByBitPerpUsdtDemo = 77,
        ByBitPerpInverseDemo = 78,
        ByBitFutInverseDemo = 79,
	}
}
