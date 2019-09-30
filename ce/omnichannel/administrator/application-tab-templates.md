---
title: "Manage application tab templates in Omnichannel Administrator app | MicrosoftDocs"
description: "Learn about managing application tab templates in Omnichannel Administrator app"
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 610965FF-21E2-483C-85B9-3C54E38346C5
ms.custom: 
---

# Preview: Manage application tab templates

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview

Application tab template in Omnichannel for administrator app provide the type of applications you want to open when a session is started. Each application type has a predefined set of parameters associated with it.

The horizontal bar below the model-driven app navigation bar is called the application tab panel. Every customer session has at least one application tab that is not closable; it is called **Anchor Tab**. That is, when a session is started, by default, the system opens an application in application tab panel. In addition, there may be few other applications that system opens by default based on the configuration. 

With application tab template, you can define the applications that are available for a session, and then associate the applications with a session. 

For example, you can create the **Customer summary** application type and associate it with Chat and SMS session. Now, when an agent accepts the notification from  the Chat or SMS channel, a session is started and by default the **Customer summary** page loads.

As an administrator, you can create multiple application tab templates.

## Create a application tab template

1. Sign in to the Omnichannel Administrator app.

2. Select **Application Tabs** under **Templates** in the sitemap.

3. Select **+ New** in the **Active Application Tabs** page.

4. Specify the following in the **New Application Tabs** page.

    | Tab | Name | Value description | Example |
    |-----------|-------------------|-----------------------------------|-------------------------------------|
    | General | Name | Specify the name of the application tab. This name wouldn't be visible for the agents at the run-time. | Knowledge article search |
    | General | Application title | Provide a title to the application that you want the agents to see at the run-time. | Knowledge article search |
    | General | Application type | Select a application type from the list. Choose one of the following: <br><br> <ul><li>Custom control</li> <li>Dashboard</li> <li>Entity view</li> <li>Entity record</li> <li>Entity search</li> <li>Web resource</li> <li>Website Url</li> </ul> <br> To learn more, see [Application types](#application-types).|  Web resource |
    | General | Description | Provide a description for your reference. | The application type is used to display KB Search Page. |
    | General | Value | Specify a value against the parameter. | msdyn_kbsearchpagehost.html <br><br> Update the value against the **webresourceName** parameter |

5. Select **Save** to save the application tab template. After you save, the parameters for the application type you selected is appears in the **Parameters** section.

6. Select the **Value** field of a parameter to edit and provide the value. See the [Application types in the application templates](#application-types) for the parameters.

7. Select **Save** to save the changes.

## Application types

The types of application available are as follows:

- [Custom control](#custom-control)
- [Dashboard](#dashboard)
- [Entity view](#entity-view)
- [Entity record](#entity-record)
- [Entity search](#entity-search)
- [Web resource](#web-resource)
- [Website Url](#website-url)

### Custom control

The parameters available for the custom control application type are as follows:

| parameter | Value | Description |
|----------------------------|---------------------------------|-----------------------------------------------------------------------------|
| controlName | | |
| data | | |


### Dashboard

The application type is used to display the dashboard as an application. The parameters available for the dashboard application type are as follows:

| parameter | Value | Description |
|----------------------------|---------------------------------|-----------------------------------------------------------------------------|
| dashboardId | | |
| entityType  | | |
| Type | | |

### Entity view

The application type is used to display entity view that defines how a list of records for a specific entity is displayed in the Omnichannel application. The parameters available for the entity view application type are as follows: 

| parameter | Value | Description |
|----------------------------|---------------------------------|-----------------------------------------------------------------------------|
| entityName | | |
| viewId | | |
| viewType  | | |

### Entity record

The parameters available for the entity record application type are as follows:

| parameter | Value | Description |
|----------------------------|---------------------------------|-----------------------------------------------------------------------------|
| createFromEntity | | |
| data | | |
| entityId  | | |
| entityName | | |
| formId | | |
| processId | | |
| relationship | |
| selectStageId | | |

### Entity search

The parameters available for the entity search application type are as follows:

| parameter | Value | Description |
|----------------------------|---------------------------------|-----------------------------------------------------------------------------|
| searchText  | | |
| searchType | | |

### Web resource

The application type is used to display Web resources that represent files, which are used to extend the Dynamics 365 for Customer Engagement web application such as html files, JavaScript, and CSS, and several image formats. The parameters available for the web resources application type are as follows:

| parameter | Value | Description |
|----------------------------|---------------------------------|-----------------------------------------------------------------------------|
| data | | |
| webresourceName | | |
| processId | | |
| processInstanceId | | |

### Website Url

The application type is used to display a first-party and third-party websites as an application. The parameters available for the website url application type are as follows:

| parameter | Value | Description |
|----------------------------|---------------------------------|-----------------------------------------------------------------------------|
| data | | |
| url | | |

## See also

- [Manage session templates](session-templates.md)
- [Manage notification templates](notification-templates.md)
- [Associate templates with worksteams](associate-templates.md)