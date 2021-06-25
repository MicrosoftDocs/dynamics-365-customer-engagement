---
title: "Manage application tab templates | MicrosoftDocs"
description: "Learn how to create application tab templates in Customer Service. Find information on the various application types and their corresponding parameters."
author: "mh-jaya"
ms.author: v-jmh
manager: shujoshi
ms.date: 06/09/2021
ms.service: "dynamics-365-customerservice"
ms.topic: article
---

# Manage application tab templates

An application tab template in Customer Service lets you specify the type of applications you want to open when a session is started. Each application type has a predefined set of parameters associated with it.

The vertical bar in the left panel shows the list of sessions. The panel will always show at least one session that can't be closed or customized; it's called the **Home session**.

The horizontal bar beneath the model-driven app navigation bar is called the application tab panel. Every session has at least one application tab that can't be closed or customized; it's called the **Anchor Tab**. When a session is started, by default the system opens an application in the application tab panel. There may also be additional applications that the system opens by default based on the configuration.

With the application tab template, you can define applications that are available for a session, and then associate those applications with the session.

For example, you can create the **Customer Summary** application type and associate it with a chat or SMS session. Now, when an agent accepts the notification from the chat or SMS channels, a session starts and the **Customer Summary** page loads by default.

As an administrator, you can create multiple application tab templates.

  > [!Note]
  > You can't customize the out-of-the-box templates; instead, you'll need to create your own custom templates.

## Create application tab templates

1. Sign in to [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083), and go to the app profile manager page.
2. In the left pane, under Templates, select **Application tabs**. The Unified Interface page opens in a new tab.
3. Select **New** on the **Active Application Tab Templates** page.

4. Specify the following on the **New Application Tab Template** page.

    | Tab | Name | Value description | Example |
    |-----------|-------------------|-----------------------------------|-------------------------------------|
    | General | Name | Specify the name of the application tab. This name won't be visible for the agents at the runtime. | Knowledge article search |
    | General | Unique Name | Provide a unique identifier in the <*prefix*>_<*name*> format. <br>**IMPORTANT**<br> The following are required for the unique name: <ul><li>The prefix can only be alphanumeric and its length must be between 3 and 8 characters.</li><li> An underscore must be between the prefix and name.</li></ul><br> You can select the light bulb icon, and then select **Apply** to verify whether the name you've entered meets the requirements. | contoso_application_tab |
    | General | Title | Provide a title for the application that you want the agents to see at the runtime. | Knowledge article search |
    | General | Page type | Select an application type from the list. |  Web resource |
    | General | Description | Provide a description for your reference. | The application type is used to display a knowledge base search page. |

5. Select **Save**. The parameters for the application type that you selected appear in the **Parameters** section.

    Whenever you edit the application tab template, save the changes so you see the corresponding fields in the **Parameters** section.

6. Select the **Value** field of a parameter to edit and provide the value. For more information on parameters, go to [Application types in the application templates](#application-types).

7. Select **Save**.

## Application types

The following types of applications are available:

- Dashboard
- Entity list
- Entity record
- Search
- Third-party website
- Web resource
- Control (for internal use only)

### Dashboard

This application type is used to display the dashboard as an application. The following parameter is available for the dashboard application type:

|Parameter | Description | Supported values | Example |
|---------|--------------|------------------|---------|
| dashboardId | GUID of the dashboard | String | `d201a642-6283-4f1d-81b7-da4b1685e698` |

> [!NOTE]
> If the target dashboard is not included in the app module definition, the default dashboard is displayed instead.

### Entity list

This application type is used to display an entity view that defines how a list of records for a specific entity is displayed. The following parameters are available for the entity view application type:

|Parameter | Description | Supported values | Example |
|---------|--------------|------------------|---------|
| entityName | Logical name of the entity | String <br> Slugs | account <br>`{anchor._customerid_value@Microsoft.Dynamics.CRM.lookuplogicalname}` |
| viewId | GUID of the view | String | `00000000-0000-0000-00aa-000010001031` |

> [!NOTE]
> If the target view does not exist or is not included in the app module definition, the default entity view is displayed instead.

### Entity record

This application type is used to display an existing record or open a form to create a new record.

The following parameters are available for the entity record application type when an existing record is opened:

|Parameter | Description | Supported values | Example |
|----------------------------|-----------------------------------------------------------------------|-------------------------------|----------------------------------------------|
| entityName | Logical name of the entity  | String <br> Slugs <br> | account <br> `{anchor._customerid_value@Microsoft.Dynamics.CRM.lookuplogicalname}` |
| entityId  | GUID of the entity record | String <br> Slugs <br>  | `d49e62a8-90df-e311-9565-a45d36fc5fe8` <br> `{anchor._customerid_value}` <br> 
| formId | GUID of the form instance | String | `915f6055-2e07-4276-ae08-2b96c8d02c57` |

The following parameters are available for the entity record application type when an entity form is opened to create a new record:

|Parameter | Description | Supported values | Example |
|---------|--------------|------------------|---------|
| entityName | Logical name of the entity | String <br> Slugs <br> <br> | contact <br> `{anchor._customerid_value@Microsoft.Dynamics.CRM.lookuplogicalname}` <br> |
| data | Data to be pre-populated in the form| json | `{"firstname":"Paul", "lastname":"Cannon", "jobtitle":"Sales Manager"}` |
| formId | GUID of the form instance | String | `915f6055-2e07-4276-ae08-2b96c8d02c57` |

### Search

The following parameters are available for the entity search application type:

|Parameter | Description | Supported values | Example |
|---------|--------------|------------------|---------|
| searchType | Define to use Relevance search or Categorized search. The possible values are: <ul><li> **0** for Relevance search </li> <li> **1** for Categorized search </li></ul> | Number | 0 |
| searchText | Define the string you want to search. <br> **This field is required.**| String <br>  Slugs <br> <br> odata <br> |  contoso <br>  `{anchor.title}` <br> `{anchor._customerid_value@OData.Community.Display.V1.FormattedValue}` <br> `{$odata.incident.title.?$filter=incidentid eq '{anchor.incidentid}'&$select=title}` <br> |

### Third-party website

This application type is used to display third-party websites as an application. You can use this type to host only the websites that are compatible with iframe hosting. The application tab template parses the URL and data parameters to format the URL address to be displayed.

|Parameter | Description | Supported values | Example |
|---------|--------------|------------------|---------|
| url | The website URL to be displayed in the app tab <br> **This field is required.** <br> | String <br> | `https://www.bing.com/search?q=`  |
| data | Additional data parameter to be parsed with the url parameter <br> **This field is optional.** | String <br> Slugs <br><br> odata <br> | contoso <br> `{anchor.title}` <br> `{anchor._customerid_value@OData.Community.Display.V1.FormattedValue}` <br> `{$odata.incident.title.?$filter=incidentid eq '{anchor.incidentid}'&$select=title}` <br> |
#### How parsing works

These examples are based on a scenario where the case was opened as the Anchor Tab in a new session with ticket number: `CAS-01003-P3B7G1`.

**url parameter**: `https://www.bing.com/search?q=` <br>
**data parameter using slugs**: `{anchor.ticketnumber}` <br>
**Expected URL**: `https://www.bing.com/search?q=CAS-01003-P3B7G1` <br>

**url parameter**: `https://www.bing.com/search?q=` <br>
**data parameter using odata**: `{$odata.incident.ticketnumber.?$filter=incidentid eq'{anchor.incidentid}'&$select=ticketnumber}` <br>
**Expected URL**: `https://www.bing.com/search?q=CAS-01003-P3B7G1` <br>

> [!NOTE]
> The url parameter requires the correct URL format using 'http://' or 'https://'.

For more information, go to [Third-party application tab refreshes when focus is changed](https://go.microsoft.com/fwlink/p/?linkid=2165393).

### Web resource

This application type is used to display web resources that represent files, which are used to extend the web application such as html files, JavaScript, CSS, and several image formats. The following parameters are available for the web resources application type:

|Parameter | Description | Supported values | Example |
|---------|--------------|------------------|---------|
| webresourceName | Name of the web resource to open | String | `msdyn_kbsearchpagehost.html`|
| data | Provide string or key value pair, according to the requirement of the web resource. | String <br>  Slugs <br> <br> odata <br> | contoso <br> `{anchor.title}` <br> `{anchor._customerid_value@OData.Community.Display.V1.FormattedValue}` <br> `{$odata.incident.title.?$filter=incidentid eq '{anchor.incidentid}'&$select=title}` <br> |

### Out-of-the-box application tab templates

The out-of-the-box application tab templates are as follows:

- Customer Summary
- Entity Record
- Knowledge Search
- Omnichannel Conversations Dashboard
- Power BI
- Search

### See also

[Manage session templates](session-templates.md)  
[Manage notification templates](notification-templates.md)  
[Associate templates with workstreams](associate-templates.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
