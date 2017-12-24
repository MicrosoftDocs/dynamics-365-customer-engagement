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

## Input and output parameters for geospatial actions

While writing your custom plug-in, you will have to consider the input and output parameters for the geospatial actions in [!INCLUDE[pn_field_service](../../includes/pn-field-service.md)] so that you can pass in and expect appropriate input and output data respectively in your plug-in code. There are two ways in which you can view the input and output parameters of the geospatial functions:

- **Web API action reference content**: View refrence information about the geospatial actions in [pn_field_service](../../includes/pn-field-service.md)].
    - <xref:Microsoft.Dynamics.CRM.msdyn_GeocodeAddress>
    - <xref:Microsoft.Dynamics.CRM.msdyn_RetrieveDistanceMatrix>
- **Action definition**: You can view the action definition in the product for information about the input/output prameters, including information whether a parametr is required or optional.
 
    To view an action definition, select **Settings** > **Processes**. Next, search for the action name: **Resource Scheduling - Geocode Address** or **Resource Scheduling - Retrieve Distance Matrix**, and then select the action in the grid to display its definition. The highlighted area in the action definition provides information about the input and output paraneters for an action.

    ![Action definition](../media/FS-ActionDefinition.png)

## Write your custom plug-in

Plug-ins are custom classes that implement the <xref:Microsoft.Xrm.Sdk.IPlugin> interface. For detailed information about creating a plug-in, see [Plug-in development](../../developer/plugin-development.md)

We have created a sample custom plug-in that demonstrates how to use the Google Maps API to provide geospatial data for field operations instead of the default Bing Maps API. More information: Download the sample code from here.

> [!NOTE]
> The sample plug-in code won't work unless you provide your own Google API key in the **GoogleDataContracts.cs** file in the sample.

Once you have written your plug-in code, build the project to generate a plug-in assembly (.dll) that will be used to register the plug-in on the Field Service geospatial actions.

## Register and deploy your custom plug-in

Before a plug-in can be used, it must be registered and deployed on the server. The Plug-in Registration Tool provides a graphical user interface to register and deploy plug-ins. For detailed information about registering and eploying plog-ins in general, see [Register and Deploy Plug-Ins](../../developer/register-deploy-plugins.md).

Assuming that you are working with the sample custom plug-in, you will have the **CustomPlugin-FS-Geospatial.dll** assembly when you build the sample project. We will use the Plug-in Registration Tool to register and deploy this plug-in assembly.

> [!TIP]
> For detailed information about how to use Plug-in Registration Tool, see [Walkthrough: Register a plug-in using the plug-in registration tool](../../developer/walkthrough-register-plugin-using-plugin-registration-tool.md)

 

### See also  
    