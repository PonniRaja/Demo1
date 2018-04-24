# Getting started

Get current weather, daily forecast for 16 days, and 3-hourly forecast 5 days for your city. Helpful stats, graphics, and this day in history charts are available for your reference. Interactive maps show precipitation, clouds, pressure, wind around your location stations. Data is available in JSON, XML, or HTML format. **Note**: This sample Swagger file covers the `current` endpoint only from the OpenWeatherMap API. <br/><br/> **Note**: All parameters are optional, but you must select at least one parameter. Calling the API by city ID (using the `id` parameter) will provide the most precise location results.

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (OpenWeatherMapAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=OpenWeatherMap%20API-CSharp&workspaceName=OpenWeatherMapAPI&projectName=OpenWeatherMapAPI.Tests)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the OpenWeatherMapAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=OpenWeatherMap%20API-CSharp&workspaceName=OpenWeatherMapAPI&projectName=OpenWeatherMapAPI.Tests)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=OpenWeatherMap%20API-CSharp&workspaceName=OpenWeatherMapAPI&projectName=OpenWeatherMapAPI.Tests)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=OpenWeatherMap%20API-CSharp&workspaceName=OpenWeatherMapAPI&projectName=OpenWeatherMapAPI.Tests)

### 3. Add reference of the library project

In order to use the OpenWeatherMapAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=OpenWeatherMap%20API-CSharp&workspaceName=OpenWeatherMapAPI&projectName=OpenWeatherMapAPI.Tests)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` OpenWeatherMapAPI.Tests ``` and click ``` OK ```. By doing this, we have added a reference of the ```OpenWeatherMapAPI.Tests``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=OpenWeatherMap%20API-CSharp&workspaceName=OpenWeatherMapAPI&projectName=OpenWeatherMapAPI.Tests)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=OpenWeatherMap%20API-CSharp&workspaceName=OpenWeatherMapAPI&projectName=OpenWeatherMapAPI.Tests)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| appid | API key to authorize requests. If you don't have an OpenWeatherMap API key, use `fd4698c940c6d1da602a70ac34f0b147`. |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string appid = "appid"; // API key to authorize requests. If you don't have an OpenWeatherMap API key, use `fd4698c940c6d1da602a70ac34f0b147`.

OpenWeatherMapAPIClient client = new OpenWeatherMapAPIClient(appid);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [WeatherController](#weather_controller)

## <a name="weather_controller"></a>![Class: ](https://apidocs.io/img/class.png "OpenWeatherMapAPI.Tests.Controllers.WeatherController") WeatherController

### Get singleton instance

The singleton instance of the ``` WeatherController ``` class can be accessed from the API Client.

```csharp
WeatherController weather = client.Weather;
```

### <a name="get_call_current_weather_data_for_one_location"></a>![Method: ](https://apidocs.io/img/method.png "OpenWeatherMapAPI.Tests.Controllers.WeatherController.GetCallCurrentWeatherDataForOneLocation") GetCallCurrentWeatherDataForOneLocation

> Access current weather data for any location on Earth including over 200,000 cities! Current weather is frequently updated based on global models and data from more than 40,000 weather stations.


```csharp
Task<UWP.Models.SuccessfulResponse> GetCallCurrentWeatherDataForOneLocation(
        string q = null,
        string id = null,
        string lat = null,
        string lon = null,
        string zip = "94040,us",
        UWP.Models.UnitsEnum? units = UWP.Models.UnitsEnum.STANDARD,
        UWP.Models.LangEnum? lang = UWP.Models.LangEnum.EN,
        UWP.Models.ModeEnum? mode = UWP.Models.ModeEnum.JSON)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| q |  ``` Optional ```  | **City name**. *Example: London*. You can call by city name, or by city name and country code. The API responds with a list of results that match a searching word. For the query value, type the city name and optionally the country code divided by comma; use ISO 3166 country codes. |
| id |  ``` Optional ```  | **City ID**. *Example: `2172797`*. You can call by city ID. API responds with exact result. The List of city IDs can be downloaded [here](http://bulk.openweathermap.org/sample/). You can include multiple cities in parameter &mdash; just separate them by commas. The limit of locations is 20. *Note: A single ID counts as a one API call. So, if you have city IDs. it's treated as 3 API calls.* |
| lat |  ``` Optional ```  | **Latitude**. *Example: 35*. The latitude cordinate of the location of your interest. Must use with `lon`. |
| lon |  ``` Optional ```  | **Longitude**. *Example: 139*. Longitude cordinate of the location of your interest. Must use with `lat`. |
| zip |  ``` Optional ```  ``` DefaultValue ```  | **Zip code**. Search by zip code. *Example: 95050,us*. Please note if country is not specified then the search works for USA as a default. |
| units |  ``` Optional ```  ``` DefaultValue ```  | **Units**. *Example: imperial*. Possible values: `metric`, `imperial`. When you do not use units parameter, format is `standard` by default. |
| lang |  ``` Optional ```  ``` DefaultValue ```  | **Language**. *Example: en*. You can use lang parameter to get the output in your language. We support the following languages that you can use with the corresponded lang values: Arabic - `ar`, Bulgarian - `bg`, Catalan - `ca`, Czech - `cz`, German - `de`, Greek - `el`, English - `en`, Persian (Farsi) - `fa`, Finnish - `fi`, French - `fr`, Galician - `gl`, Croatian - `hr`, Hungarian - `hu`, Italian - `it`, Japanese - `ja`, Korean - `kr`, Latvian - `la`, Lithuanian - `lt`, Macedonian - `mk`, Dutch - `nl`, Polish - `pl`, Portuguese - `pt`, Romanian - `ro`, Russian - `ru`, Swedish - `se`, Slovak - `sk`, Slovenian - `sl`, Spanish - `es`, Turkish - `tr`, Ukrainian - `ua`, Vietnamese - `vi`, Chinese Simplified - `zh_cn`, Chinese Traditional - `zh_tw`. |
| mode |  ``` Optional ```  ``` DefaultValue ```  | **Mode**. *Example: html*. Determines format of response. Possible values are `xml` and `html`. If mode parameter is empty the format is `json` by default. |


#### Example Usage

```csharp
string q = "q";
string id = "id";
string lat = "lat";
string lon = "lon";
string zip = "94040,us";
var units = UWP.Models.UnitsEnum?Helper.ParseString("imperial");
var lang = UWP.Models.LangEnum?Helper.ParseString("en");
var mode = UWP.Models.ModeEnum?Helper.ParseString("json");

UWP.Models.SuccessfulResponse result = await weather.GetCallCurrentWeatherDataForOneLocation(q, id, lat, lon, zip, units, lang, mode);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Not found response |


[Back to List of Controllers](#list_of_controllers)



