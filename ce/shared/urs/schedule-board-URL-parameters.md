The schedule board is accessible through a URL that loads the web resource. The simplest way to access this URL is to configure the schedule board as you prefer, select **More options (&hellip;)**, and choose **Copy link**. The generated link includes the parameters currently configured on your board.

:::image type="content" source="../../field-service/media/schedule-board-copy-link.png" alt-text="Screenshot of the Copy link option on the schedule board.":::

You can also construct the URL manually and extend that URL with parameters to refine the experience.

## Understand the URL structure

The base URL is `https://<domain>/main.aspx?pagetype=webresource&webresourceName=msdyn_/ScheduleBoard/index.html?data=<parameters>`

- `<domain>` is the domain of your organization. For example, `contoso.onmicrosoft.com`
- `<parameters>` are URI-encoded and stringified JSON objects that include key-value pairs that define the focus of the schedule board.

## Create parameters

We'll use the browser console to create the parameters. [Learn more about the Console and DevTools in Microsoft Edge](/microsoft-edge/devtools-guide-chromium/console/).

1. Open the console in the browser.

1. Construct the command like `encodeURIComponent(JSON.stringify({parameter1: "value", parameter2: "value", ...}))` and enter it in the console. For example, to show the map and set the view mode to daily, the command is: `encodeURIComponent(JSON.stringify({map: "true", viewmode: "daily"}))`, which results in `%7B%22map%22%3A%22true%22%2C%22viewmode%22%3A%22daily%22%7D`.

   [More parameters and values are listed in the following section](#parameter-reference).

1. Append the resulting stringified object to the base URL to create a functional URL that launches the schedule board with the parameters set accordingly. For example: `https://contoso.onmicrosoft.com/main.aspx?pagetype=webresource&webresourceName=msdyn_/ScheduleBoard/index.html?data=%7B%22map%22%3A%22true%22%2C%22viewmode%22%3A%22daily%22%7D`.

## Append parameters based on Unified Interface

Optionally, *following* the schedule board URL parameters, you can add non-encoded parameters for the Unified Interface of Dynamics 365.

The following parameters open the schedule board in a separate browser window without navigation elements: `&cmdbar=false&navbar=off&newWindow=true`. Opening the schedule board with such parameters may get some system parameters such as `forceUCI=1` and `appid=<ID>` added automatically.

## Add parameters to a sitemap

You can customize the navigation of a model-driven app in Power Apps. Learn more: [Create a model-driven app site map using the site map designer](/power-apps/maker/model-driven-apps/create-site-map-app).

Use the constructed URL to add a new navigation point or override the schedule board settings path. In the URL field, enter `/main.aspx?pagetype=entitylist&etn=msdyn_scheduleboardsetting` and encoded parameters like `?data=%7B%22map%22%3A%22true%22%2C%22viewmode%22%3A%22daily%22%7D`.

## Parameter reference

The following parameters can get passed to the schedule board.

- **Schedule board tab**

  `tab : "<tab ID>"`

  Get the tab IDs using this browser query: `https://<domain>/api/data/v9.1/msdyn_scheduleboardsettinges?$select=msdyn_tabname,msdyn_scheduleboardsettingid`

- **Map section visible**

  `map : "true/false"`

- **Schedule board view type**

  `viewtype : "gantt/list"`

- **Schedule board view mode**

  `viewmode : "hourly/daily/weekly/monthly"`

- **Start date for the schedule board**

  `startdate : "YYYY-MM-DD"`

  The date takes the time zone configured for the schedule board. You can only define the start date in ISO format and the system sets the date to the start of the week or month that the given date is in.

- **Column width**

  `columnwidth : "1...100"`

  Changes the width of the columns for the gantt view type. Defines the percentage and gets converted based on the view mode.
