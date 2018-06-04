---
title: "Do not duplicate plug-in step registration | MicrosoftDocs"
description: "Duplicate plug-in step registration will cause the plug-in to fire multiple times on the same message/event."
ms.date: 01/26/2018
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
	- "Dynamics 365 (online)"
ms.assetid: 176c2bc4-3b40-477c-9c29-1f48b4cb0f6f
author: "jowells1"
ms.author: "jowells"
manager: "michu"
---
# Do not duplicate plug-in step registration

**Applies to**:

- [!include[](../../includes/pn-crm-9-0-0-online.md)]
- [!include[](../../includes/pn-crm-2016.md)]

**Applies to**:

- [!include[](../../includes/pn-crm-9-0-0-online.md)]
- [!include[](../../includes/pn-crm-2016.md)]
- [!include[](../../includes/pn-crm-8-1-0-both.md)]
- [!include[](../../includes/pn-crm-2015.md)]
- [!include[](../../includes/pn-crmv6.md)]
- [!include[](../../includes/pn-crm-2011.md)]

**Category**: Performance

**Impact potential**: High

<a name='symptoms'></a>

## Symptoms

Duplicate plug-in step registration will cause the plug-in to fire multiple times on the same message/event. This could lead to:

- Delayed processing of asynchronous jobs when registered as an asynchronous execution mode.
- Degraded user performance experience when registered as a synchronous execution mode. Experiences include:
    - Unresponsive client pages
    - Slow client interactions
    - The browser stops responding

<a name='guidance'></a>

## Guidance

Ensure you are updating existing plug-in registration steps rather than deleting and re-creating them.  Additionally, only create and update plug-in registration steps in a supported manner.

<a name='problem'></a>

## Problematic patterns

> [!WARNING]
> These patterns should be avoided.

Deleting and recreating a step in the source instance (test, dev, preprod) will also create a duplicate step being registered in the target environment if that step had been registered before.

![Duplicate Plug-in Step Registration](../media/duplicate-plugin-registration-step.png)

Manually creating the `SDKMessageProcessingSteps` with a new GUID or updating the existing GUID within the `customizations.xml` file will result in a duplicate step being registered. These types of tasks are unsupported as outlined in [When to edit the customizations file](../../developer/customize-dev/when-edit-customization-file.md).

<a name='additional'></a>

## Additional information

Duplicate plug-in step registration could cause SQL deadlocking when the events are registered on an update message. When issuing an update on a record, SQL will create a row lock on that record. If another transaction tries to update that same record, it will have to wait until the lock is released before it's able to make the update. If a timeout occurs, the transaction is rolled back and the update is not committed to the SQL database.

<a name='seealso'></a>

### See also

[Walkthrough: Register a plug-in using the plug-in registration tool](../../developer/walkthrough-register-plugin-using-plugin-registration-tool.md)<br />
[Deadlocking](https://technet.microsoft.com/library/ms177433.aspx)<br />
