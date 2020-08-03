---
title: "Manage application tab templates in Omnichannel Administration app | MicrosoftDocs"
description: "Learn about managing application tab templates in Omnichannel Administration app"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 01/31/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Manage application tab templates

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview

Application tab template in Omnichannel Administration app provide the type of applications you want to open when a session is started. Each application type has a predefined set of parameters associated with it.

The horizontal bar below the model-driven app navigation bar is called the application tab panel. Every customer session has at least one application tab that is not closable; it is called **Anchor Tab**. That is, when a session is started, by default the system opens an application in application tab panel. In addition, there may be few other applications that system opens by default based on the configuration. 

With application tab template, you can define the applications that are available for a session, and then associate the applications with a session.

For example, you can create the **Customer summary** application type and associate it with Chat and SMS session. Now, when an agent accepts the notification from  the chat or SMS channels, a session starts and by default the **Customer summary** page loads.

As an administrator, you can create multiple application tab templates.

## Create an application tab template

1. Sign in to the Omnichannel Administration app.

2. Select **Application Tabs** under **Agent Experience** in the sitemap.

3. Select **+ New** in the **Active Application Tabs** page.

4. Specify the following in the **New Application Tabs** page.

    | Tab | Name | Value description | Example |
    |-----------|-------------------|-----------------------------------|-------------------------------------|
    | General | Name | Specify the name of the application tab. This name wouldn't be visible for the agents at the run-time. | Knowledge article search |
    | General | Application title | Provide a title for the application that you want the agents to see at the run-time. | Knowledge article search |
    | General | Application type | Select a application type from the list. Choose one of the following: <br><br> <ul><li>Custom control</li> <li>Dashboard</li> <li>Entity view</li> <li>Entity record</li> <li>Entity search</li> <li>Web resource</li> <li>Website Url</li> </ul> <br> To learn more, see [Application types](#application-types).|  Web resource |
    | General | Description | Provide a description for your reference. | The application type is used to display KB Search Page. |

5. Select **Save** to save the application tab template. After you save, the parameters for the application type you selected appear in the **Parameters** section. 

    Whenever you edit the application tab template, save the changes so you see the corresponding fields in the **Parameters** section.

6. Select the **Value** field of a parameter to edit and provide the value. See the [Application types in the application templates](#application-types) for the parameters.

7. Select **Save**.

## Application types

The types of applications available are as follows:

- [Manage application tab templates](#manage-application-tab-templates)
  - [Overview](#overview)
  - [Create an application tab template](#create-an-application-tab-template)
  - [Application types](#application-types)
    - [Custom control](#custom-control)
    - [Dashboard](#dashboard)
    - [Entity view](#entity-view)
    - [Entity record](#entity-record)
    - [Entity search](#entity-search)
    - [Web resource](#web-resource)
    - [Website Url](#website-url)
    - [See also](#see-also)

### Custom control

The parameters available for the custom control application type are as follows:

| parameter | Example value | Description |
|----------------------------|---------------------------------|-----------------------------------------------------------------------------|
| controlName | `MscrmControls.OCSearchRuntime.OCSearchRuntimeControl` | Name of the control. <br> Type = String |
| data | `{key1:value1}` | Defines the attributes and values for the control. <br> Type = JSON Object |


### Dashboard

The application type is used to display the dashboard as an application. The parameters available for the dashboard application type are as follows:

| parameter | Example value | Description |
|----------------------------|---------------------------------|-----------------------------------------------------------------------------|
| dashboardId | `d201a642-6283-4f1d-81b7-da4b1685e698` | GUID of the dashboard. <br> Type = String |
| entityType  | incident | Entity type of the record. <br> Type = String |
| type | system | The value is either `system` or `user`. <br> Type = String |

### Entity view

The application type is used to display an entity view that defines how a list of records for a specific entity is displayed in the Omnichannel application. The parameters available for the entity view application type are as follows: 

| parameter | Example value | Description |
|----------------------------|---------------------------------|-----------------------------------------------------------------------------|
| entityName | Account | Logical name of the entity. <br> Type = String |
| viewId | `00000000-0000-0000-00AA-000010001003` | GUID of the view. <br> Type = String|
| viewType  | savedquery |  Defines the view type. Possible values are as follows:<br /><br /> - **1039**<br />     Use for a system view. The `viewid` represents the Id of a `savedquery` record.<br />- **4230**<br />     Use for a personal view. The `viewid` represents the Id of a `userquery` record.   <br> Type = String |

### Entity record

The parameters available for the entity record application type are as follows:

| parameter | Example value | Description |
|----------------------------|---------------------------------|-----------------------------------------------------------------------------|
| createFromEntity | account | Designates a record that provides default values based on mapped attribute values. The lookup object has the following String properties: `entityType`, `id`, and `name` (optional). <br> Type = JSON Object | 
| data | `{"firstname":"Rigsby", "lastname":"cho" , "jobtitle":"Sales Manager"}` | Defines the attributes and values for the new entity record. <br> Type = JSON Object |
| entityId  | `d72e3735-5dca-e911-a826-000d3a1f0599` | GUID of the entity record. <br> Type = String  |
| entityName | account | Logical name of the entity. <br> Type = String |
| formId | `8448B78F-8F42-454E-8E2A-F8196B0419AF` | GUID of the form instance. <br> Type = String |
| processId |  | GUID of the business process. <br> Type = String |
| relationship |  | Relationship object of the record. <br> Type = JSON Object |
| selectStageId | | GUID of the selected stage in business process instance.  <br> Type = String |

### Entity search

The parameters available for the entity search application type are as follows:

| parameter | Example value | Description |
|----------------------------|---------------------------------|-----------------------------------------------------------------------------|
| searchText  | Printer Noise | Define the string you want to search. <br> Type = String |
| searchType | 0 | Define to use Relevance search or Categorized search. The possible values are: <br> - **0** for RelevanceSearch <br> - **1** for CategorizedSearch  <br> Type = Number|

### Web resource

The application type is used to display Web resources that represent files, which are used to extend the web application such as html files, JavaScript, and CSS, and several image formats. The parameters available for the web resources application type are as follows:

| parameter | Example value | Description |
|----------------------------|---------------------------------|-----------------------------------------------------------------------------|
| data | Printer Noise | Provide string or key value pair, according to the requirement of the web resource.  <br> Type = String|
| webresourceName | `msdyn_kbsearchpagehost.html` |Name of the web resource to open. <br> Type = String|


### Website Url

The application type is used to display first-party and third-party websites as an application. You can use this type to host only the websites that are compatible for iframe hosting.  The parameters available for the website URL application type are as follows:

| parameter | Example value | Description |
|----------------------------|---------------------------------|-----------------------------------------------------------------------------|
| data | `stackoverflow` |Query parameters that you want to search. <br> Type = String|
| url | https://www.bing.com/search? | <br> Type = String|

To learn more, see [Third-party application tab refreshes when focus is changed](../omnichannel-readme.md#third-party-application-tab-refreshes-when-focus-is-changed).

### See also

- [Manage session templates](session-templates.md)
- [Manage notification templates](notification-templates.md)
- [Associate templates with workstreams](associate-templates.md)
