---
title: "Use your preferred geospatial data provider (Developer Guide for Dynamics 365 Field Service) | MicrosoftDocs"
description: "Provides information on how to use geospatial data providers of your choice instead of the default Bing Maps in Dynamics 365 for Field Service."
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
ms.assetid: bbae6f0d-1d53-4d6e-b76f-00dae07443e0
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Use your preferred geospatial data provider in Field Service

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_dyn_365_field_service](../../includes/pn-dyn-365-field-service.md)] provides geospatial functionality for the field service operations by using the Bing Maps API (data provider) by default.

The geospatial functionality in [!INCLUDE[pn_field_service](../../includes/pn-field-service.md) is provided using [actions](../../customize/actions.md), such as the **msdyn_GeocodeAddress** for geocoding addresses and **msdyn_RetrieveDistanceMatrix** for calculating travel times and distances between two locations. Additionally, the [!INCLUDE[pn_field_service](../../includes/pn-field-service.md) solution contains a plug-in registered on these two actions that by default uses the data provided by Bing Maps API to perform geospatial operations.

You can create a custom plug-in and register on these two actions to use geospatial data from a data provider of your choice instead of using the default Bing Maps. More information: [Create custom plug-in to use your preferred geospatial data provider](create-custom-plugin-preferred-geospatial-data-provider.md)

### See also  
    