---
title: "msdyn_ciprovider Entity reference for Channel Integration Framework (CIF) in Dynamics 365 | Microsoft Docs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 12/10/2018
ms.topic: reference
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
---

# msdyn_ciprovider Entity Reference

Base entity for Channel Integration Framework.

## Entity properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_ciprovider|
|DisplayCollectionName|Channel Provider|
|DisplayName|Channel Provider|
|EntitySetName|msdyn_ciprovider|
|LogicalCollectionName|msdyn_ciprovider|
|LogicalName|msdyn_ciprovider|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_ciproviderid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_ciprovider|

## Attributes

| Attributes | Display Name | Description |
|------------|----------------------|-------------|
| msdyn_name | Name | Name of the channel provider |
| msdyn_Label | Label | The label is displayed as the title on the widget |
| msdyn_LandingUrl | Channel URL | The URL of the provider to host in the widget. |
| msdyn_ClickToAct | Enable Outbound Communication | Widget initiates outbound communication. Raises `onclicktoact` event on the communication widget.|
| msdyn_SortOrder| Channel Order | The order precedence of the channel providers. |
| msdyn_ciproviderapiversion | API Version  | The version of the Channel Integration Framework APIs. |
| msdyn_trustedDomain  | Trusted Domains | An additional domain if the initial landing URL and the final domain from which the communication widget is hosted are different. Ad the domain (URL) to access the Channel Integration Framework APIs.|
| msdyn_AppSelector | Select the Unified Interface Apps for the Channel | The list of Unified Interface Apps where the channel is displayed for the agents. |
| msdyn_RoleSelector | Select Roles for the Channel | The security roles that are present in Dynamics 365.|

## Related topics

- [Configure the channel provider](../../configure-channel-provider-channel-integration-framework.md)

- [Microsoft.CIFramework](../microsoft-ciframework.md)

- [Client-side events](../client-side-events.md)

