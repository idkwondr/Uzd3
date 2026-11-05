// Paskaidrojums:
// 
// (a) Kâpçc Calculator balstâs uz ILogger, nevis uz ConsoleLogger un kurð princips to prasa?
// 
// Calculator balstâs uz ILogger abstraktâ interfeisa, nevis uz konkrçto ConsoleLogger klasi,
// jo tas ievçro Dependency Inversion (DI) principu no SOLID. Ðis princips nosaka, ka
// augstâkâ lîmeòa moduïi (Calculator) nedrîkst bût atkarîgi no zemâkâ lîmeòa moduïiem
// (ConsoleLogger, MemoryLogger), bet gan abi drîkst bût atkarîgi no abstrakcijas (ILogger).
// Tâ vietâ, lai Calculator tieði izveidotu ConsoleLogger objektu ar "new ConsoleLogger()",
// tas saòem ILogger caur konstruktoru. Tas ïauj viegli mainît þurnâla veidu (konsole,
// atmiòa, u.c.) bez Calculator koda izmaiòâm. Tas padarî kodu elastîgâku un vieglâk testçjamu.
//
// (b) Kâpçc lasîðana ir atseviðíâ interfeisâ ILogReader un kurð princips to prasa?
//
// Lasîðana ir atseviðíâ interfeisâ ILogReader, jo tas ievçro Interface Segregation (IS)
// principu no SOLID. Ðis princips nosaka, ka klases nedrîkst bût spiesta îstenot metodes,
// kuras tâ neiebilst. ConsoleLogger tikai ieraksta þurnâlâ, tas nolasa jau ierakstîtos
// datus - tâpçc tas neòem ILogReader interfeisu. MemoryLogger gan ieraksta, gan nolasa
// datus - tâpçc tas îsteno abus interfeisus. Tâdâ veidâ interfeisi ir mazâki un visvairâk
// fokusçti uz vienu atbildîbu.
