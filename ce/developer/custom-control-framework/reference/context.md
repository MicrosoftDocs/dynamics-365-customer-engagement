---
title: Context | Microsoft Docs
description: 
keywords:
ms.author: nabuthuk
manager: 
ms.date: 06/4/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 6e066350-9d22-4078-b497-26be7d2fa374
---
# Context

<!-- PropBag -->

[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [context-description](includes/context-description.md)]


<!-- ## accessibility

Placeholder description: PropBag.accessibility

**Type**: [Accessibility](accessibility.md) -->



<!-- ## children

Placeholder description: PropBag.children

**Type**: `any`<br />
**Optional** -->

## client

Placeholder description: PropBag.client

**Type**: [Client](client.md)


<!-- 
## communicationChannel

Placeholder description: PropBag.communicationChannel

**Type**: [CommunicationChannel](communicationchannel.md) -->



<!-- ## decorators

Placeholder description: PropBag.decorators
<!-- 
QUESTION
IDecorators seems to be no more than a dictionary
	interface IDecorators
	{
		//Multiple decorators where parent can pass to child control
		[key: string]: System.Dictionary;
	}

 -->

**Type**: `[KeyValuePair](keyvaluepair.md)`<br />
**Optional** -->

<!-- ## diagnostics

Placeholder description: PropBag.diagnostics

**Type**: [Diagnostics](diagnostics.md) -->

## device 

Placeholder description: PropBag.device

**Type**: [Device](device.md)



<!-- ## externalContext

Placeholder description: PropBag.externalContext

**Type**: [ExternalContext](externalcontext.md) -->



## factory

Placeholder description: PropBag.factory

**Type**: [Factory](factory.md)



## formatting

Placeholder description: PropBag.formatting

**Type**: [Formatting](formatting.md)



<!-- ## learningPath

Placeholder description: PropBag.learningPath

<!-- 
QUESTION
I don't think we should document ILearningPath as an interface in our TOC.
We can document it in-line with this property since it is only used here.

interface ILearningPath
{
	/**
	 * DOM attribute name.
	 */
	DOMAttributeName: string;

	/**
	 * Identifier for the base control.
	 */
	baseControlId: string;
}

-->

**Type**: `object` -->

<!-- ### Remarks
The object has the following `string` properties:
|Name|Description|
|----|-----------|
|`DOMAttributeName`|DOM attribute name.|
|`baseControlId`|Identifier for the base control.|-->

## mode

Placeholder description: PropBag.mode

**Type**: [Mode](mode.md)



## navigation

Placeholder description: PropBag.navigation

**Type**: [Navigation](navigation.md)



<!--## offline

Placeholder description: PropBag.offline

**Type**: [Offline](offline.md)-->



<!-- ## orgSettings

Placeholder description: PropBag.orgSettings

**Type**: [OrgSettings](orgsettings.md)-->



<!--## page

Placeholder description: PropBag.page

**Type**: [Page](page.md)-->



## parameters

Placeholder description: PropBag.parameters

**Type**: `any`



<!--## performance

<!-- 
QUESTION
All methods provided by IPerformance are internal
Should we just remove it?
--->

[!INCLUDE [internal](../../../includes/internal.md)] -->

<!--## refs

Placeholder description: PropBag.refs

**Type**: `object`<br />
**Optional**

## reporting

Placeholder description: PropBag.reporting

**Type**: [Reporting](reporting.md)-->

## resources

Placeholder description: PropBag.resources

**Type**: [Resources](resources.md)

<!--## theming

Placeholder description: PropBag.theming

**Type**: [Theming](theming.md)-->

## updatedProperties

Placeholder description: PropBag.updatedProperties

**Type**: `string[]`

## userSettings

Placeholder description: PropBag.userSettings

**Type**: [UserSettings](usersettings.md)

## utils

Placeholder description: PropBag.utils

**Type**: [Utility](utility.md)

## webAPI

Placeholder description: PropBag.webAPI

**Type**: [WebApi](webapi.md)

### Related topics

[Custom Control Framework API Reference](index.md)<br />
[Custom Control Framework Overview](../custom-control-framework-overview.md)







