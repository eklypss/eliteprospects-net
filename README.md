# eliteprospects-net
A work-in-progress project that aims to create a fully featured & easy-to-use .NET/C# wrapper for the [eliteprospects.com](http://www.eliteprospects.com/) API.

## Notes
All data is fetched from the EP API and the data is owned by them. If you wish to use this wrapper, please refer to their [FAQ](https://github.com/menmo/eliteprospects-api-documentation/blob/master/README.md) and [Terms of Service](https://github.com/menmo/eliteprospects-api-documentation/blob/master/LICENSE.md). 

**You must display "Provided by [Eliteprospects.com](http://www.eliteprospects.com/)" wherever Eliteprospects data is used.**

## Examples
**Note:** the parameter system will be changed to something that is easier to use in the future.

**Getting the 15 latest transfers in SHL:**
```
EPClient client = new EPClient();
var transfers = client.GetTransfer(new Parameters(new Filter("transferType=TRANSFER%26toTeam.latestTeamStats.league.id=1"), new Limit(15), new Sort("transferDate:desc")));
foreach(var t in transfers.DataList)
{
    Console.WriteLine("[{0}] {1} {2} from {3} to {4}", t.Updated, t.Player.FirstName, t.Player.LastName, t.FromTeam.Name, t.ToTeam.Name);
}
```

**Outputs:**

```
[2017-04-07] Marcus Fagerudd from Ilves to Djurgårdens IF
[2017-04-06] Alexander Younan from Frölunda HC to Rögle BK
[2017-04-06] Elias Pettersson from Timrå IK to Växjö Lakers HC
[2017-04-06] Henrik Törnqvist from Linköping HC to Karlskrona HK
[2017-04-06] Cory Murphy from Växjö Lakers HC to Karlskrona HK
[2017-04-06] Sakari Manninen from HPK to Örebro HK
[2017-04-05] Sebastian Wännström from Rögle BK to Linköping HC
[2017-04-05] Emil Kruse from BIK Karlskoga to Rögle BK
[2017-04-05] Sebastian Wännström from Rögle BK to HV71
[2017-04-05] Fredrik Karlström from AIK to Linköping HC
[2017-04-04] Henrik Larsson from BIK Karlskoga to Brynäs IF
[2017-04-03] Patrik Zackrisson from Lugano to Djurgårdens IF
[2017-04-01] Jens Westin from Timrå IK to Färjestad BK
[2017-03-31] Theodor Lennström from BIK Karlskoga to Färjestad BK
[2017-03-31] Michael Lindqvist from AIK to Färjestad BK
```

**Getting the retired numbers for a team specified by a string:**

```
EPClient client = new EPClient();
var retiredNumbers = client.GetRetiredNumber(new Parameters(new Filter("team.name=Boston Bruins"), new Limit(100), new Sort("number:asc")));
foreach(var t in retiredNumbers.DataList)
{
    Console.WriteLine("#{0} {1} {2}", t.Number, t.Player.FirstName, t.Player.LastName);
}
```

**Outputs:**
```
#2 Eddie Shore
#3 Lionel Hitchman
#4 Bobby Orr
#5 Dit Clapper
#7 Phil Esposito
#8 Cam Neely
#9 Johnny Bucyk
#15 Milt Schmidt
#24 Terry O'Reilly
#77 Raymond Bourque
```
**Note:** the data above is provided by **[eliteprospects.com](http://www.eliteprospects.com/)**

## Libraries
The project uses the following third party libraries:
* Newtonsoft.Json
