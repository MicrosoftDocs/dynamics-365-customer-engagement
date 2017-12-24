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

This topic provides you information about how to create a custom plug-in containing sample code that uses Google Maps API instead of the Bing Maps API as the geospatial data provider and register the plug-in on the two [!INCLUDE[pn_field_service](../../includes/pn-field-service.md)] actions using the Plug-in Registration tool

## Input and output parameters for geospatial actions

While writing your custom plug-in, you will have to consider the input and output parameters for the geospatial actions in [!INCLUDE[pn_field_service](../../includes/pn-field-service.md)] so that you can pass in and expect appropriate input and output data respectively in your plug-in code. There are two ways in which you can view the input and output parameters of the geospatial functions:

- **Web API action reference content**: View refrence information about the geospatial actions in [!INCLUDE[pn_field_service](../../includes/pn-field-service.md)].
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

Once you have written your plug-in code, build the project to generate a plug-in assembly (.dll), which will be used to register the plug-in on the [!INCLUDE[pn_field_service](../../includes/pn-field-service.md)] geospatial actions.

## Register and deploy your custom plug-in

Before a plug-in can be used, it must be registered and deployed on the server. The Plug-in Registration Tool provides a graphical user interface to register and deploy plug-ins. For detailed information about registering and eploying plog-ins in general, see [Register and Deploy Plug-Ins](../../developer/register-deploy-plugins.md).

> [!IMPORTANT]
> This section contains information based on an assumption that you are working with the sample custom plug-in, and have built the sample project to generate the **CustomPlugin-FS-Geospatial.dll** assembly. We will use the Plug-in Registration Tool to register and deploy this plug-in assembly.

1. Get the Plug-in Registration Tool. [!INCLUDE[proc-download-plugin-registration-tool](../../includes/proc-download-plugin-registration-tool.md)]
2. Navigate to the `[Your folder]\Tools\PluginRegistration` folder, and double-click the **PluginRegistration.exe** file to run the tool.
3. Click **CREATE NEW CONNECTION**.
4. In the **Login** dialog, specify the credentials to connect to your Dynamics 365 instance, and click **Login**.
5. If you have access to multiple organizations in the Dynamics 365 instance, you are prseneted with a list of organizations to choose to connect to. Otherwise, your default organization is used.
6. You should see a collapsed list of registered plug-in or custom workflow activity assemblies. Select **Register** > **Register New Assembly**.
7. In the **Register New Assembly** dialog box:
    
    - Under the **Step 1** section, click the ellipses […] button to select the **CustomPlugin-FS-Geospatial.dll** assembly.
    - Under the **Step 2** section, select both the plug-ins.
    - Under the **Step 3** section, select the **Sandbox** option.
    - Under the **Step 4** section, select the **Database** option.
    - Select **Register Selected Plugins**.

    ![](../media/FS-register-plugin-assembly.png)

    The **CustomPlugin-FS-Geospatial.dll** assembly and the two plug-ins for the msdyn_GeocodeAddress and msdyn_RetrieveDistanceMatrix are now registered and deployed to the server.

8. The next step is to register a step for each action. A *step* refers to the SDK message processing step entity that is used to configure when and how the plug-in is to be executed.

    In the **Registered Plug-ins & Custom Workflow Activities** tree view, expand the **(Assembly) CustomPlugin-FS-Geospatial** node, and select a registered plug-in, say **Microsoft.Crm.Sdk.Samples.msdyn_RetrieveDistanceMatrix**.

    ![](../media/FS-register-plugin-step.png)

9. Right-click the plugin, and select **Register New Step**.

10. In the **Register New Step** dialog box, specify the following:
    - **Message**: msdyn_RetrieveDistanceMatrix
    - **Execution Order**: As required. See [Execution order considerations while registering your custom plug-in](#execution-order-considerations-while-registering-your-custom-plug-in) later in this topic.
    - **Event Pipeline Stage of Execution**: PostOperation
    - **Execution Mode**: Synchronous
    - Leave the rest of the fields with their default values. Click **Register New Step**. 

    ![](../media/FS-register-step-retrievedistancematrix.png)

11. Next, right-click the **Microsoft.Crm.Sdk.Samples.msdyn_GeocodeAddress** plug-in, and select **Register New Step**.

12. In the **Register New Step** dialog box, specify the following:
    - **Message**: msdyn_GeocodeAddress
    - **Execution Order**: As required. See [Execution order considerations while registering your custom plug-in](#execution-order-considerations-while-registering-your-custom-plug-in) later in this topic.  
    - **Event Pipeline Stage of Execution**: PostOperation
    - **Execution Mode**: Synchronous
    - Leave the rest of the fields with their default values. Click **Register New Step**. 

    ![](../media/FS-register-step-geocodeaddress.png)

You are now done with registering steps to call your custom plug-in for the both the geospatial actions. 

If you view any of the [!INCLUDE[pn_field_service](../../includes/pn-field-service.md)] geospatial actions in the Plug-in Registration tool, you will see both the default and your custom plug-in registered for the action. For example, see the plug-ins for the **mdyn_GeocodeAddress** action.

![](../media/FS-resitered-plugins-for-message.png)


> [!TIP]
> For detailed information about how to use Plug-in Registration Tool, see [Walkthrough: Register a plug-in using the plug-in registration tool](../../developer/walkthrough-register-plugin-using-plugin-registration-tool.md)

## Execution order considerations while registering your custom plug-in

When you register multiple plug-ins for the same entity and message, the execution sequence of the plug-ins is defined by the *execution order* of individual plug-ins. The one with a lower execution order value executes first followed by the one with a higher execution order value.

The execution order value of the default [!INCLUDE[pn_field_service](../../includes/pn-field-service.md)] plug-in that uses Bing Maps for the geocode and distance matrix actions is set to **1**. You can set the execution order of your custom plug-in to execute before (less than 1) or after (greater than 1) the default plug-in.

The following table depicts how you may want your custom plug-in to be treated depending on the execution order and parameter conditions.

|||
|--|--|
|**Primary**| If you want to treat your custom plug-in as *primary* and the default [!INCLUDE[pn_field_service](../../includes/pn-field-service.md)] Bing plug-in as secondary, set the execution order of your plug-in to **0**. This will result in your plug-in getting executed prior to the Bing plug-in. The Bing plug-in will examine the "latitude" and "longitude" values that your custom plug-in returns, and only proceeds to geocode with Bing if both the returned values are 0. This would be the preferred way if your custom plug-in is expected to provide the majority of your geocoding needs.|
|**Secondary**|If you want to treat your custom plug-in as *secondary* to Bing plug-in by providing the geocoding service only when Bing fails to geocode, set the execution order of your plugin to **2**. You would also write your custom plug-in code such that it first examines the "latitude" and "longitude" values that Bing plug-in returns, and proceeds only if both the returned values are 0. This would be the preferred execution way if Bing is expected to provide the majority of your geocoding needs.|
|**Completely override**| If you always want your custom plug-in to be the source of geocoding and completely override Bing from geocoding even when your custom plug-in fails to geocode, you will need to always return something other than 0,0 for "latitude" and "longitude" values. You may want to decide which exception conditions throw a .NET exception and which ones simply do not return a result. To not return a result and not allow any subsequent plug-in to return a result, your custom plug-in needs to return something like 0.0001, 0.0001. 

### See also  
    