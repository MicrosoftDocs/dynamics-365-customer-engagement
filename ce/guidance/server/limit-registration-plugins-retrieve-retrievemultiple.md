---
title: "Limit the registration of plug-ins for Retrieve and RetrieveMultiple messages | MicrosoftDocs"
description: "Adding synchronous plug-in logic to the Retrieve and RetrieveMultiple message events can cause slowness throughout Dynamics 365."
ms.date: 12/27/2017
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
	- "Dynamics 365 (online)"
ms.assetid: 4be02eba-7f1b-4d5b-9d72-929f9feccb3d
author: "jowells1"
ms.author: "jowells"
manager: "michu"
---

[//]: <> (1/10/2018 - Version 1 release without sample code.  Adding Sample Code Task to backlog for User Story 836085)

# Limit the registration of plug-ins for Retrieve and RetrieveMultiple messages

**Applies to**:

- [!include[](../../includes/pn-crm-9-0-0-online.md)]
- [!include[](../../includes/pn-crm-2016.md)]
- [!include[](../../includes/pn-crm-8-1-0-both.md)]
- [!include[](../../includes/pn-crm-2015.md)]
- [!include[](../../includes/pn-crmv6.md)]
- [!include[](../../includes/pn-crm-2011.md)]

**Category**: Performance

**Impact potential**: Medium

<a name='symptoms'></a>

## Symptoms

Adding synchronous plug-in logic to the Retrieve and RetrieveMultiple message events can result in:

- Unresponsive client pages
- Slow client interactions
- The browser stops responding

<a name='guidance'></a>

## Guidance

Evaluate the design of solutions that include plug-ins registered for the Retrieve and RetrieveMultiple messages.  In general, it is not recommended to register plug-ins for these messages due to the risks associated with slowing down the requests to return an entity record or records from various entry points.  However, it may be appropriate for the design of your application. An example of a common application would be the injection of additional filter criteria to a specific existing query. This allows a solution to compensate for what cannot be done in the user interface for views.  The view designer can only support a certain depth of complexity and then other options must be employed to augment the results or the query.

If it is an appropriate solution, then follow these tips to minimize the impact to the environment:

- Include conditions in the plug-in code to quickly check if the targeted logic needs to be performed. If it does not, then return quickly, refraining from executing unnecessary extra steps that will delay returning the data to the caller.

[//]: <> (@michu - Should we include an example here of what that would look like?)

- Avoid including long running tasks, especially those that can be non-deterministic, such as the invocation of external service calls or complex queries to [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)].

- Limit or avoid querying for additional data from [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)]

### Virtual Entities

Most commonly Retrieve and RetrieveMultiple is called within plug-ins to retrieve data from external sources. The data from the external sources are rendered in [!INCLUDE  [pn-dynamics-365](../../includes/pn-dynamics-365.md)] or used to work/manipulate existing data. [!include[](../../includes/pn-crm-9-0-0-online.md)] introduces a feature called [Virtual Entities](../../developer/virtual-entities/get-started-ve.md) which allows integration of data residing in external systems by seamlessly representing that data as entities in [!INCLUDE  [pn-dynamics-365](../../includes/pn-dynamics-365.md)], without replication of data and often without custom coding. Review the [Virtual Entities](../../developer/virtual-entities/get-started-ve.md) documentation for further information about the capabilities, limiations, and configuration.

### Retrieve Caution

[!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)] will trigger at least two Retrieve messages for each entity form load.  One retrieve contains limited attributes, which can vary by entity, and subsequent calls will include more attributes.  If you expect a single action to occur during the loading of a form, then do not rely strictly on the trigger of a Retrieve message.

[//]: <> (1/10/2018 - Commenting out Problem section until we have examples for Problematic Patterns)

[//]: <> (<a name='problem'></a>)

[//]: <> (## Problematic patterns)

[//]: <> (INSERT_INFORMATION_HERE)

<a name='additional'></a>

## Additional information

The `Retrieve` and `RetrieveMultiple` messages are two of the most frequently processed messages in [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)]. The `Retrieve` message is triggered when opening up an entity form or when an entity is being accessed using the `Retrieve` operation in one of the service endpoints. `RetrieveMultiple` is triggered due to various actions in the application and service endpoints, for example, when populating a grid in the user interface.  Adding synchronous plug-in logic to these message events can cause slowness throughout [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)].

<a name='seealso'></a>

### See also

[Performance Optimizations for Microsoft Dynamics CRM Online](https://mbs.microsoft.com/customersource/northamerica/CRM/learning/documentation/user-guides/PerformanceOptimizationsCRMOnlineSuccess)<br />
[Virtual Entities](../../developer/virtual-entities/get-started-ve.md)<br />
