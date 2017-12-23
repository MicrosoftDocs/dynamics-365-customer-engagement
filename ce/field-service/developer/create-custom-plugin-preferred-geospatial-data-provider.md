---
title: "Create custom plug-in to use your preferred geospatial data provider (Developer Guide for Dynamics 365 Field Service) | MicrosoftDocs"
description: "Provides information on how to use geospatial data providers other than the default Bing Maps in Dynamics 365 for Field Service."
ms.custom: ""
ms.date: 01/05/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "conceptual"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2be7f42d-745c-4454-b132-f2a3d47194ae
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Create custom plug-in to use your preferred geospatial data provider in Field Service

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This topic provides you information about how to create a custom plug-in containing sample code that uses Google Maps API instead of the Bing Maps API as the geospatial data provider and register the plug-in on the two Field Service actions using the Plug-in Registration tool

## Create your custom plug-in

Plug-ins are custom classes that implement the <xref:Microsoft.Xrm.Sdk.IPlugin> interface. For detailed information about creating a plug-in, see [Plug-in development](../../developer/plugin-development.md)

We have a sample custom plug-in that uses the Google Maps API to provide geospatial data instead of the default Bing Maps API. Download the sample code from here.

> [!NOTE]
> The sample plug-in code won't work unless you provide your own Google API key in the **GoogleDataContracts.cs** file in the sample.



### See also  
    