using OOP3;

// Class'lar ve interface'ler kendini implemente eden class'ın referans numarasını tutabilir
ConsumerCreditManager consumerCreditManager = new ConsumerCreditManager();
consumerCreditManager.Calc();

MortgageManager mortgageManager = new MortgageManager();
mortgageManager.Calc();

ICreditManager vehicleCreditManager = new VehicleCreditManager();
vehicleCreditManager.Calc();