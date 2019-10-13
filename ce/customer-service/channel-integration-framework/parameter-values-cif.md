---
title: "Supported formats to pass parameters values in the Channel Integration Framework app | MicrosoftDocs"
description: "Learn about the supported formats to pass parameters values in the Channel Integration Framework app"
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/15/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: FB1DB0A5-97D6-40D6-BD5D-30606C44F8EF
ms.custom: 
---

# Preview: Pass parameters values

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview

While creating templates, you can pass parameter values such as Title of a session, notification, and application tab template.

While creating templates in the Channel Integration Framework app, you can pass parameter values such as Title of a session, notification, application tab template. These values are replaced based on the contextual details available at the time of execution.

## Pass data parameters in templates

Let us take a scenario for templates with the notifications.

The notification shows certain fields and values, which are called **Field header** and **Value** respectively.

Kenny Smith, a customer, initiated a conversation and when the agent sees the notification, it displays **Customer Name** as **Kenny Smith**.

Here, **Field header** is **Customer Name** and the **Value** is **Kenny Smith**.

For templates to identify the name of the customer as **Kenny Smith**, as an administrator, you must configure pass the parameter as values.

Similarly, for session and notification title, you can pass the data parameters in the support formats. To learn more, see [Supported formats for data parameter values](#supported-formats-for-data-parameter-values).

The Channel Integration Framework replaces these parameter values with the actual value based on the context of the session, channel provider, Common Data Service, and user actions

To learn more, see [Types context data parameters](#types-context-data-parameters).


## Types context data parameters

The context data parameters are available from the following:

- [Context data from the channel provider](#context-data-from-the-channel-provider)
- [Context data from the user actions](#context-data-from-the-user-actions)
- [Context data from Common Data Service](#context-data-from-common-data-service)

### Context data from the channel provider 

This context data is with the first-party channel provider such as Omnichannel for Customer Service or third-party channel provider that uses the widget exposed by Channel Integration Framework. The context data from the Omnichannel for Customer Service app are pre-chat survey, visitor portal navigation, and so on.

### Context data from the user actions 

This data is populated as and when agents perform some activities on the session. An example is opening a new customer record, case etc.

### Context data from Common Data Service 

The organizational data is stored in Common Data Service, and you can fetch the data with the use of OData queries.

## Supported formats for data parameter values

These list of supported formats are:

- [Slugs](#slugs)
- [OData queries](#odata-queries)
- [Static values](#static-values)

### Slugs

Slug is a replacement parameter that Channel Integration Framework populates at the run time based on the context.

Channel Integration Framework supports the following slugs.

| Slug | Description |
|------------|-----------------------------------|
| `{customerName}` | Name of the customer who initiated the conversation. |
| `{caseId}` | Unique Id of a case. The system displays the case Id only if a cased linked to the conversation. |
| `{caseTitle}` | Title of the case. The system displays the title of the case only if a cased linked to the conversation. |
| `{queueId}` | Unique Id of a queue. |
| `{visitorLanguage}` | The language of the customer who initiated the conversation. |
| `{visitorDevice}` | The device of the customer who initiated the conversation. |
| `{entityRoutingLogicalName}` | Name of the entity if the notification is for a entity records. |
| `{entityRoutingRecordId}` | Unique Id of the entity record if the notification is for a entity records. |
| `{customerEntityName}` | Name of the entity (contact or account entity) if the customer is authenticated. |
| `{customerRecordId}` | Unique Id of t.he entity (contact or account entity) if the customer is authenticated. |
| `{<name of the pre-chat survey questions>}` | All the pre-chat survey questions that are configured for a workstream will have the slug name as the name of the question. |

### OData queries

You can use the OData queries to get the context that are available from the Common Data Service platform.

The OData query format:

`{$Odata.<entityName>.<entityAttributeName>.<?options>} like {$Odata.account.name.?$filter=id eq <GUID>`

Example:

### Static values

These are hardcoded values that you update as your business requirement. For every hardcoded attribute you chose, follow the format type for the particular attribute.

**For example:**

For an incoming chat request, you want provide the static title to session and notification that agents see at the run time.

Notification title = `New chat request`

Session title = `Chat conversation`

## See also

- [Manage session templates](session-templates-cif.md)
- [Manage application tab templates](application-tab-templates-cif.md)
- [Manage notification templates](notification-templates-cif.md)
- [Associate templates with workstreams](associate-templates-cif.md)