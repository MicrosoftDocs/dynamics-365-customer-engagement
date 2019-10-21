---
title: "Use automation dictionary to pass parameters keys in the Channel Integration Framework app | MicrosoftDocs"
description: "Learn how to use automation dictionart to pass parameters keys in the Channel Integration Framework app"
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: FB1DB0A5-97D6-40D6-BD5D-30606C44F8EF
ms.custom: 
---

# Preview: Use automation dictionary to pass data parameter keys

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview

Automation Dictionary maintains the contextual data for the sessions. You can use the keys from the automation dictionary to pass the parameter keys in the templates.

While creating templates in the Channel Integration Framework app, you can pass parameter keys such as title of a session, title of notification, title of an application tab template, and custom parameter values for application tab types. These keys are replaced based on the contextual information available at the time of execution.

## Pass data parameters in templates

Let us take a scenario for templates with the notifications.

The notification shows certain fields and values, which are called **Field header** and **Value** respectively.

Kenny Smith, a customer, initiated a conversation and when the agent sees the notification, it displays **Customer Name** as **Kenny Smith**.

Here, **Field header** is **Customer Name** and the **Value** is **Kenny Smith**.

For templates to identify the name of the customer as **Kenny Smith**, as an administrator, you must pass the parameter as keys.

Similarly, for session and notification title, you can pass the data parameters. To learn more, see [Automation dictionary formats to data parameter keys](#automation-dictionary-formats-to-data-parameter-keys).

The Channel Integration Framework replaces these parameter values with the actual value based on the context of the session, channel provider, Common Data Service, and user actions

To learn more, see [Types context data parameters](#types-context-data-parameters).


## Types context data parameters

The automation dictionary uses the context data parameters that are available from the following sources:

- [Context data from the channel provider](#context-data-from-the-channel-provider)
- [Context data from the user actions](#context-data-from-the-user-actions)
- [Context data from Common Data Service](#context-data-from-common-data-service)

> [!div class=mx-imgBorder] 
> ![Automation dictionary](media/automation-dictionary-cif.png "Automation dictionary")

### Context data from the channel provider 

This context data is from the first-party channel provider such as Omnichannel for Customer Service or third-party channel provider that uses the widget exposed by Channel Integration Framework. The context data from Omnichannel for Customer Service are pre-chat survey, visitor portal navigation, and so on.

### Context data from the user actions 

This data is populated as and when agents perform some activities in the session. An example is opening a new customer record, case, and so on.

### Context data from Common Data Service 

The organizational data is stored in Common Data Service, and you can fetch the data with the use of OData queries. To learn more, see [OData queries](#odata-queries)

## Automation dictionary formats to data parameter keys

Automation Dictionary maintains the contextual data for the sessions. The keys in the automation dictionary can be passed as parameters to the action in macros. The system replaces these parameter keys with the actual value based on the context of the session, channel provider, Common Data Service, and user actions.
These list of supported formats are:

- [Slugs](#slugs)
- [OData queries](#odata-queries)
- [Static values](#static-values)

### Slugs

Slug is a replacement parameter that Channel Integration Framework populates at the runtime based on the context. Channel Integration Framework supports the following slugs.

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

#### Format

The `{ChannelProvider.<Slug>}` or `{Slug}` parameter format is used to retrieve the context from the channel provider, where `ChannelProvider` is a standard construct to get the value from the provider context of the current session. 

   For example: 

   `{ChannelProvider.caseId}`

   or

   `{caseId}`

### OData queries

You can use the OData queries to get the context that are available from the Common Data Service platform.

The OData query format:

`{$Odata.<entityName>.<entityAttributeName>.<?options>} like {$Odata.account.name.?$filter=id eq <GUID>`

Example:

- `{$odata.incident.prioritycode.?$filter=incidentid eq '{caseId}'&$select=prioritycode}`

- `{$odata.incident.title.?$filter=incidentid eq '{caseId}'&$select=title}`

### Static values

These are hardcoded values that you update as your business requirement. For every hardcoded attribute you chose, follow the format type for the particular attribute.

**For example:**

For an incoming chat request, you want provide the static title to the session and notification template that agents see at the runtime.

Notification title = `New chat request`

Session title = `Chat conversation`

## See also

- [Manage session templates](session-templates-cif.md)
- [Manage application tab templates](application-tab-templates-cif.md)
- [Manage notification templates](notification-templates-cif.md)
- [Associate templates with workstreams](associate-templates-cif.md)