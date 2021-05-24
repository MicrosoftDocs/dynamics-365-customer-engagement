---
title: "Manage application tab templates | MicrosoftDocs"
description: "Learn how to create application tab templates in Customer Service. Also learn about the various application types and their predefined set of parameters."
author: "mh-jaya"
ms.author: v-jmh
manager: shujoshi
ms.date: 05/28/2021
ms.service: "dynamics-365-customerservice"
ms.topic: article
---

# Manage application tab templates

## Introduction

An application tab template in Customer Service lets you specify the type of applications you want to open when a session is started. Each application type has a predefined set of parameters associated with it.

The horizontal bar beneath the model-driven app navigation bar is called the application tab panel. Every customer session has at least one application tab that can't be closed; it is called **Anchor Tab**. That is, when a session is started, by default the system opens an application in the application tab panel. In addition, there may be few other applications that system opens by default based on the configuration.

With application tab template, you can define the applications that are available for a session, and then associate the applications with a session.

For example, you can create the **Customer summary** application type and associate it with Chat and SMS session. Now, when an agent accepts the notification from the chat or SMS channels, a session starts and by default the **Customer summary** page loads.

As an administrator, you can create multiple application tab templates.

  > [!Note]
  > You can't customize the out-of-the-box templates; instead, you'll need to create your own custom templates.

## Create an application tab template

1. Sign in to [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083), and go to the app profile manager page.
2. In the left pane, under Templates, select **Application tabs**. The Unified Interface page opens on a new tab.
3. Select **New** in the **Active Application Tab Templates** page.

4. Specify the following in the **New Application Tab Template** page.

    | Tab | Name | Value description | Example |
    |-----------|-------------------|-----------------------------------|-------------------------------------|
    | General | Name | The name of the application tab. This name wouldn't be visible for the agents at the run-time. | Knowledge article search |
    | General | Unique Name | A unique identifier in the <*prefix*>_<*name*> format. <br>**IMPORTANT**<br> The following are required for the unique name: <ul><li>The prefix can only be alphanumeric and its length must be between 3 to 8 characters.</li><li> An underscore must be there between the prefix and name.</li></ul><br> You can select the light bulb icon, and then select **Apply** to verify whether the name you've entered meets the requirements. | contoso_application_tab |
    | General | Title | Provide a title for the application that you want the agents to see at the run-time. | Knowledge article search |
    | General | Page type | Select an application type from the list. |  Web Resource |
    | General | Description | Provide a description for your reference. | The application type is used to display knowledge base search page. |

5. Select **Save**. After you save the template, the parameters for the application type that you selected appear in the **Parameters** section.

    Whenever you edit the application tab template, save the changes so you see the corresponding fields in the **Parameters** section.

6. Select the **Value** field of a parameter to edit and provide the value. See the [Application types in the application templates](#application-types) for the parameters.

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

The application type is used to display the dashboard as an application. The parameters available for the dashboard application type are as follows:

|Parameter | Description | Supported values | Example |
|----------------------------|-----------------------------------------------------------------------|-------------------------------|----------------------------------------------|
| dashboardId | GUID of the dashboard.| String | `d201a642-6283-4f1d-81b7-da4b1685e698` |

> [!NOTE]
> If the target dashboard is not included in the app module definition, then the default dashboard will be rendered instead.

### Entity list

The application type is used to display an entity view that defines how a list of records for a specific entity is displayed. The parameters available for the entity view application type are as follows:

|Parameter | Description | Supported values | Example |
|----------------------------|-----------------------------------------------------------------------|-------------------------------|----------------------------------------------|
| entityName | Logical name of the entity. | String <br> Slugs | account <br>`{anchor._customerid_value@Microsoft.Dynamics.CRM.lookuplogicalname}` |
| viewId | GUID of the view. | String | `00000000-0000-0000-00aa-000010001031` |


> [!NOTE]
> If the target view does not exist or is not included in the app module definition, then the default entity view will be rendered instead.

### Entity record

The application type is used to display an existing record or to open a form to create a record. 

The parameters available for the entity record application type when opening an existing record are as follows:

|Parameter | Description | Supported values | Example |
|----------------------------|-----------------------------------------------------------------------|-------------------------------|----------------------------------------------|
| entityName | Logical name of the entity.  | String <br> Slugs <br> | account <br> `{anchor._customerid_value@Microsoft.Dynamics.CRM.lookuplogicalname}` |
| entityId  | GUID of the entity record. | String <br> Slugs <br>  odata <br> | <br>`d49e62a8-90df-e311-9565-a45d36fc5fe8` <br> `{anchor.new_entityid}` <br> `{$odata.account.name.?$filter=accountid eq '{anchor._customerid_value}'}`
| formId | GUID of the form instance. | String | `915f6055-2e07-4276-ae08-2b96c8d02c57` |

The parameters available for the entity record application type when opening an entity form to create a new record are as follows:

|Parameter | Description | Supported values | Example |
|----------------------------|-----------------------------------------------------------------------|-------------------------------|----------------------------------------------|
| entityName | Logical name of the entity. | String <br> Slugs <br> <br> | contact <br> `{anchor._customerid_value@Microsoft.Dynamics.CRM.lookuplogicalname}` <br> |
| data | Data to be pre-populated in the form.| json | `{"firstname":"Paul", "lastname":"Cannon" , "jobtitle":"Sales Manager"}` |
| formId | GUID of the form instance. | String | `915f6055-2e07-4276-ae08-2b96c8d02c57` | 

### Search

The parameters available for the entity search application type are as follows:

|Parameter | Description | Supported values | Example |
|----------------------------|------------------------------------------------------------------------|-------------------------------|----------------------------------------------|
| searchType | Define to use Relevance search or Categorized search. The possible values are: <ul><li> **0** for Relevance Search </li> <li> **1** for Categorized Search </li></ul> | Number | 0 |
| searchText | Define the string you want to search. <br> **This field is required.**| String <br>  Slugs <br> <br> odata <br> | <br> contoso <br>  `{anchor.title}` <br> `{anchor._customerid_value@OData.Community.Display.V1.FormattedValue}` <br> `{$odata.incident.title.?$filter=incidentid eq '{anchor.incidentid}'&$select=title}` <br> |

### Third-party website

The application type is used to display third-party websites as an application. You can use this type to host only the websites that are compatible with iframe hosting. The application tab template parses the URL and data parameters to format the URL address to be displayed.

|Parameter | Description | Supported values | Example |
|----------------------------|------------------------------------------------------------------------|-------------------------------|----------------------------------------------|
| url | The website URL to be displayed in the app tab. <br> **This field is required.** <br> | String <br> | https://www.bing.com/search?q=  |
| data | Additional data parameter to be parsed with the url parameter. <br> **This field is optional.** | String <br> Slugs <br><br> odata <br> | <br>contoso <br> `{anchor.title}` <br> `{anchor._customerid_value@OData.Community.Display.V1.FormattedValue}` <br> `{$odata.incident.title.?$filter=incidentid eq '{anchor.incidentid}'&$select=title}` <br> |

### Web resource

The application type is used to display web resources that represent files, which are used to extend the web application such as html files, JavaScript, and CSS, and several image formats. The parameters available for the web resources application type are as follows:

|Parameter | Description | Supported values | Example |
|----------------------------|-----------------------------------------------------------------------|-------------------------------|----------------------------------------------|
| webresourceName | Name of the web resource to open. | String | `msdyn_kbsearchpagehost.html`|
| data | Provide string or key value pair, according to the requirement of the web resource. | String <br>  Slugs <br> <br> odata <br> | <br> contoso <br> `{anchor.title}` <br> `{anchor._customerid_value@OData.Community.Display.V1.FormattedValue}` <br> `{$odata.incident.title.?$filter=incidentid eq '{anchor.incidentid}'&$select=title}` <br> |


#### How parsing works

These examples are based on a scenario where the case was opened as the anchor tab in a new session with ticket number: `CAS-01003-P3B7G1`.

**url** parameter: https://www.bing.com/search?q= <br>
**data** parameter using slugs: `{anchor.ticketnumber}` <br>
Expected url: https://www.bing.com/search?q=CAS-01003-P3B7G1 <br>

**url**: https://www.bing.com/search?q= <br>
**data parameter using odata**: `{$odata.incident.ticketnumber.?$filter=incidentid eq `{anchor.incidentid}`&$select=ticketnumber}` <br>
**Expected URL**: https://www.bing.com/search?q=CAS-01003-P3B7G1 <br>

> [!NOTE]
> The url parameter requires the correct url format using 'http://'  or 'https://'. 

To learn more, see [Third-party application tab refreshes when focus is changed](../customer-service/omnichannel-readme.md#third-party-application-tab-refreshes-when-focus-is-changed).



### Out-of-the-box application tab templates

The out-of-the-box application tab templates are as follows:

- Customer Summary
- Entity record
- Knowledge Search
- Omnichannel Conversations Dashboard
- Power BI
- Search

### See also

[Manage session templates](session-templates.md)  
[Manage notification templates](notification-templates.md)  
[Associate templates with workstreams](associate-templates.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
