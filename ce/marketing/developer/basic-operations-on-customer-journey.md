---
title: "Basic Operations on Customer Journey using API| Microsoft Docs" # Intent and product brand in a unique string of 43-59 chars including spaces
description: The Customer Journey API enables programmatic interaction with certain segmentation features of Dynamics 365 for Marketing App."" # 115-145 characters including spaces. This abstract displays in the search result.
ms.custom: ""
ms.date: 2/07/2019
ms.reviewer: ""
ms.service: "D365CE"
ms.topic: "article"
author: "nkrb" # GitHub ID
ms.author: "nabuthuk" # MSFT alias of Microsoft employees only
manager: "kvivek" # MSFT alias of manager or PM counterpart
search.audienceType: 
  - developer
search.app: 
  - PowerApps
  - D365CE
---
# Basic Operations on Customer Journey using API

[!INCLUDE[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

As you engage potential customers, they start by discovering your product, evaluate whether it meets their needs, look for a good offer, and finally make a purchase. We call this process the customer journey. Use customer journeys to create a model that helps you guide the members of a selected marketing segment through this process by using automated messaging, activity generation, interactive decision points, and more. More information [Create Customer Journey](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/create-simple-customer-journey)

> [!IMPORTANT]
> - Customer Journey API is a preview feature.
> - [!INCLUDE[cc_preview_features_definition](../../includes/cc-preview-features-definition.md)] 
> - [!INCLUDE[cc_preview_features_no_MS_support](../../includes/cc-preview-features-no-ms-support.md)]

The Customer Journey API enables programmatic interaction with Customer Journey records.
The API leverages the standard Dynamics 365 API for manipulating entities or messages. More information [Dynamics 365 Web API](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/use-microsoft-dynamics-365-web-api)

When you create a Customer Journey, the properties are stored in `msdyncrm_customerjourney` entity. You can browse the entity metadata for available properties and optionset value mapping. You can get the metadata information by using `@odata.context`in `GET` response. 

> [!NOTE]
> Before you perform operations, you should install Dynamics 365 for Marketing app. 

This topic demonstrates how to perform basic operation on the `msdyncrm_segment` entity. You need to pass the following mandatory fields in order to create a segment.
