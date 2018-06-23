# MegAPI

MegAPI is a project build as part of a larger system revolving a soundsystem the "MegaBoominator" that has been a work in progress since 2013. 
MegAPI is basicly an API that supports the storing and fetching of data. The API started as a simple solution that 
should only inform an esp8266 controller to change the light but ended up doing much more than that.

It is build in coherence with the following project:
https://github.com/Kostecki/MEGAPanel

This API is now used to:

* Send information to an esp8266 controller through an mqtt-broker to change the light and store the last known information after the controller has replied back
* Store and fetch information regarding batteries, average data consumption and hourly data consumption from a Raspberry Pi
* Change the battery that is currently in the soundsystem
* Send information regarding the battery status as sms to the relevant recipients.

I will disregard the clients of this service as this project is only regarding the API.

### Prerequisites

You need a couple of things before getting started. As I previously stated - this is not only a simple API anymore. It talks to a sms-gateway and a mqtt-broker.
These services are needed as well as a database to store the data.

As I am using Azure (and microsoft) the go-to database for me was MSSQL. This could be any database - as I haven\'t made use of any MSSQL specific features.

Visual Studio (I\'m using VS17 and the code runs EF 6.0 on asp.Net 4.6).

To the fun part:

*MQTT-Broker*
We of course pay for our MQTT-broker as this is a highly professional "company" - but should you need a simple Broker then http://cloudamqp.com lets you get a free tier one.
This could be used for eternal testing purposes for example...

*SMS-Gateway*
We of course pay for our SMS-gateway as this is a highly professional "company" - but should you need a test solution then look for companies that let\'s you have a free account with a 100 free messages.
We would never just switch between solutions each year - but also feel a responsibility to inform you of this possibility. 
I am using https://www.suresms.com/dk/ as I live in Denmark.

## Getting Started

This project is made from a standard Azure Web API template meaning that there are some legacy naming in the namespaces (some are still called ContactList) - just deal with it.

Start by cloning the project to your local machine, start it in Visual Studio, 
add a standard `Web.config` file in the `MegaLight` folder and let it include the following (with your own values).

*Connection string*
```
  <connectionStrings>
    <add name="DatabaseContext" connectionString="Server=tcp:[SERVERNAME],[SERVERPORT];Initial Catalog=Development;Persist Security Info=False;User ID=[USER_ID];Password=[USER_PASS];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" providerName="System.Data.SqlClient"/>
  </connectionStrings>
```
*Keys*
```
  <appSettings>
    <add key="Battery" value="1" />
    <add key="BatteryInformationSend" value="2" />
    <add key="NewCycle" value="3" />
    <add key="MinusUpNumber" value="4" />
    <add key="MinusDownNumber" value="5" />
    <add key="MqttServer" value="[MQTThost]" />
    <add key="MqttUser" value="[MQTTuser]" />
    <add key="MqttPassword" value="[MQTTpassword]" />
    <add key="smsUser" value="[sms-gatewayUser]" />
    <add key="smsPassword" value="[sms-gatewayPassword]" />
    <add key="apiUser" value="[BasicAuthUser]" />
    <add key="apiPassword" value="[BasicAuthPassword]" />
    <add key="smsRecievers" value="[comma separated list with sms recievers (12345678,876565343,8756431)]"/>
    <add key="smsCountry" value="[CountryCode (+45)]"/>
  </appSettings>
```
*Auth*
```
  <system.webServer>
    <modules>
      <add name="BasicAuthHttpModule" 
        type="WebHostBasicAuth.Modules.BasicAuthHttpModule, MegaLight"/>
    </modules>
  </system.webServer>
```

The project migration part has been done in a Code-First migration kinda way so;

Run the following commands from the Package Manager Console:

`enable-migrations`
`update-database`

If you wish to see the SQL it runs then simply substitute with `update-database -Verbose`.

Now press the "run"-button and see the magic happen as an api starts with a 403-forbidden page. (This will probably be fixed in the future ¯\\\_(ツ)_/¯)

You are now ready to get the show on the road!

## Running the tests

We don\'t do no tests - but you can simply write /ping in the url and should get a pong back if your API is running.

PostMan tests will be added in a folder so they can be imported (change the host as this will call the localhost:[somePort]).

## Every API call, their function, expected json in request and response.

### GET

**/ping**

pongs you


**/getLit**

Gets last set light status.

<details><summary>Response</summary><p>

*Response-model:*
```
{
	"Animation":string,
	"Brightness":float,
	"Color":{
		"R":int,
		"G":int,
		"B":int
	}
}
```

</p></details>



**/getBatteries**

gets the last status we have on all the batteries that are logged

<details><summary>Response</summary><p>

*Response-model:*
```
[
	{
		"BatteryId":string,
		"Voltage":float,
		"CurrentBattery":boolean
	},
	...
]
```

</p></details>



**/getAverage**

gets the last recorded average that the RaspberryPi has sent

<details><p>

*Response-model:*
```
{
	"Up":float,
	"Down":float
}
```

</p></details>



**/getBatteryHistoric**

gets the last seven days worth of battery information collected into 4 hour spans

<details><summary>Response</summary><p>

*Response-model:*
```
{
	"Monday":[
		float,
		float,
		float,
		float,
		float,
		float
	],
	"Tuesday":[
		float,
		float,
		float,
		float,
		float,
		float
	],
	"Wednesday":[
		float,
		float,
		float,
		float,
		float,
		float
	],
	"Thursday":[
		float,
		float,
		float,
		float,
		float,
		float
	],
	"Friday":[
		float,
		float,
		float,
		float,
		float,
		float
	],
	"Saturday":[
		float,
		float,
		float,
		float,
		float,
		float
	],
	"Sunday":[
		float,
		float,
		float,
		float,
		float,
		float
	]
}
```

</p></details>



**/getDataHistoric**

gets the last seven days worth of data information collected into 1 hour spans

<details><summary>Response</summary><p>

*Response-model:*
```
{
	"Monday":[
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float}
	],
	"Tuesday":[
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float}
	],
	"Wednesday":[
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float}
	],
	"Thursday":[
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float}
	],
	"Friday":[
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float}
	],
	"Saturday":[
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float}
	],
	"Sunday":[
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float},
		{"Up":float,"Down":float}
	]
}
```

</p></details>



**/getStatus**

a combination of "getAverage", "getBatteryHistoric" and "getDataHistoric"

<details><summary>Response</summary><p>

*Response-model:*
```
{
	"Avg": {
		"Up":float,
		"Down":float
	},
	"DataWeek":{
		"Monday":[
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float}
		],
		"Tuesday":[
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float}
		],
		"Wednesday":[
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float}
		],
		"Thursday":[
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float}
		],
		"Friday":[
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float}
		],
		"Saturday":[
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float}
		],
		"Sunday":[
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float},
			{"Up":float,"Down":float}
		]
	},
	"BatteryWeek": {
		"Monday":[
			float,
			float,
			float,
			float,
			float,
			float
		],
		"Tuesday":[
			float,
			float,
			float,
			float,
			float,
			float
		],
		"Wednesday":[
			float,
			float,
			float,
			float,
			float,
			float
		],
		"Thursday":[
			float,
			float,
			float,
			float,
			float,
			float
		],
		"Friday":[
			float,
			float,
			float,
			float,
			float,
			float
		],
		"Saturday":[
			float,
			float,
			float,
			float,
			float,
			float
		],
		"Sunday":[
			float,
			float,
			float,
			float,
			float,
			float
		]
	}
}
```

</p></details>



#### [Authorized Calls]
*these calls will need a basic header authentication*


**/restart**

Lets us now that the RaspberryPi has been restarted

<details><summary>Response</summary><p>

*Response-model:*
```
{ 
	"response": "success" 
}
```

</p></details>



**/dailyStatus**
sends an sms message with current voltage wording is based on time of day

<details><summary>Response</summary><p>

*Response-model:*
```
{ 
	"response": "messageSend" 
}
```

</p></details>


### POST 


#### [Authorized Calls]


**/setLights**

sets the lights, either from the controller site or from mega.re

<details><summary>Request</summary><p>

*Request-model:*
```
{
	"Animation":string,
	"Brightness":float,
	"Color":{
		"R":int,
		"G":int,
		"B":int
	},
	Controller: boolean
}
```

</p></details>

<details><summary>Response</summary><p>

*Response-model:*
```
{ 
	"response": "success" 
}
```

</p></details>



**/setStatus**

sets the average and the current data information

<details><summary>Request</summary><p>

*Request-model:*
```
{
	"AvgSpeed": {
		"Up":float,
		"Down":float
	},
	"DataAmount": {
		"Up":float,
		"Down":float
	}
}
```

</p></details>

<details><summary>Response</summary><p>

*Response-model:*
```
{ 
	"response": "success" 
}
```

</p></details>



**/setVoltage**

sets the current voltage on the battery

<details><summary>Request</summary><p>

*Request-model:*
```
{ 
	"Voltage": float 
}
```

</p></details>

<details><summary>Response</summary><p>

*Response-model:*
```
{ 
	"response": "success" 
}
```

</p></details>



**/changeBattery**

changes the battery-identifier in the database

<details><summary>Request</summary><p>

*Request-model:*
```
{ 
	"batId": string 
}
```

</p></details>

<details><summary>Response</summary><p>

*Response-model:*
```
{ 
	"response": "success" 
}
```

</p></details>


## Deployment

I have published it to an azure platform by simply using the "publish" feature. this generates an appropriate deployment file.

## Contributing

Write a comment, I might do something, I might not. ¯\\\_(ツ)_/¯
I will however continue development on the project though it might be mostly seasonal based, as it is developed for festival usage.

## Versioning

There is only the master version. I will run a development branch that will not be working at all times.

## Authors

* **Lars Peter Jensen** - *Coder*
* **Jacob Kostecki** - *Model-designer*

## License

This project is licensed to me... and I guess anyone who wants to use it. Please don\'t blame me for bad code - this hasn\'t been created with best-practice (or even best solution) in mind.

## Acknowledgments

* Jacob Kostecki as he is a brand good designer and sparring
* Jacob Kostecki as he is a shitty and annoying designer that purposefully makes the data modelling A LIVING HELL.
