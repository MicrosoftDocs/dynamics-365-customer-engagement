---
title: "Assemblies included in Dynamics 365 Customer Engagement SDK (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Learn about assemblies such as Microsoft.Crm.Sdk.Proxy.dll, Microsoft.Xrm.Sdk.dll, Microsoft.Xrm.Sdk.Workflow.dll, Microsoft.Crm.Tools.EmailProviders.dll and Microsoft.Xrm.Sdk.Deployment.dll that you can use when writing custom code"
ms.custom: ""
ms.date: 11/20/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ec508435-b1db-42c6-8d08-e833b3ee9689
caps.latest.revision: 30
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Assemblies included in Dynamics 365 Customer Engagement SDK

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement has several programming assemblies that you can use when writing custom code.  
  
 The following table lists the assemblies that are included in the SDK.  
  
|Assembly name|Namespace name|Description|  
|-------------------|--------------------|-----------------|  
|Microsoft.Crm.Sdk.Proxy.dll||Defines requests and responses for messages business data model specific (non-core) messages as well as enumerations required for working with organization data.|  
||<xref:Microsoft.Crm.Sdk>|Contains enumerations of possible picklists and integer values for some attributes. The naming convention of the classes is \<*EntityName*>\<*AttributeName*> to make it easier to locate the specific attribute.|  
||<xref:Microsoft.Crm.Sdk.Messages>|Contains request and responses for business data model specific (non-core) messages.|  
|Microsoft.Xrm.Sdk.dll||Defines the core xRM methods and types, including proxy classes to make the connection to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] simpler, authentication methods, and the service contracts.|  
||<xref:Microsoft.Xrm.Sdk>|Defines the data contracts for attribute types, interfaces for authoring plug-ins, and other general purpose xRM types and methods.|  
||<xref:Microsoft.Xrm.Sdk.Client>|Defines classes for use by client-code, including a data context, proxy classes to ease the connection to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)], and the LINQ provider.|  
||<xref:Microsoft.Xrm.Sdk.Discovery>|Defines all classes required to communicate with the Discovery Service, including the service contract, all request/responses and supporting classes.|  
||<xref:Microsoft.Xrm.Sdk.Messages>|Defines request/response classes for Create, Retrieve, Update, Delete, Associate , Disassociate, and the metadata classes.|  
||<xref:Microsoft.Xrm.Sdk.Metadata>|Defines the data contracts for [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] metadata.|  
||<xref:Microsoft.Xrm.Sdk.Query>|Defines query classes required to connect to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].|  
|Microsoft.Xrm.Sdk.Workflow.dll||Defines types and methods required to author a custom workflow activity.|  
||<xref:Microsoft.Xrm.Sdk.Workflow>|Defines the attribute and dependency property classes required to author a custom workflow activity.|  
||<xref:Microsoft.Xrm.Sdk.Workflow.Activities>|Defines the workflow activities that are used by the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] workflow designer.|  
||<xref:Microsoft.Xrm.Sdk.Workflow.Designers>|Defines a [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)] designer for displaying a [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] workflow in [!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)].|  
|Microsoft.Xrm.Sdk.Data||Defines methods and types needed for developing virtual entity data provider plug-ins. More information: [Get started with virtual entities](../virtual-entities/get-started-ve.md) |  
|Microsoft.Xrm.Sdk.Deployment.dll||Defines types and methods for interacting with the Deployment Web Service.|  
||<xref:Microsoft.Xrm.Sdk.Deployment>|Defines the data contracts necessary to communicate with the Deployment Web Service.|  
||<xref:Microsoft.Xrm.Sdk.Deployment.Proxy>|Defines a helper class to generate a proxy for the Deployment Web Service.|
|Microsoft.Xrm.Tooling.Connector||Provides the low-level interaction and wrapper methods for the Dynamics 365 Customer Engagement SDK assembly APIs. More information: [Build Windows client applications using the XRM tools](../build-windows-client-applications-xrm-tools.md)| 
||<xref:Microsoft.Xrm.Tooling.Connector>|Provides classes and methods to interact with the Customer Engagement SDK assembly APIs.| 
||<xref:Microsoft.Xrm.Tooling.Connector.Model>|Provides classes and events to communicate with the Customer Engagement Discovery Service APIs.|
|Microsoft.Xrm.Tooling.CrmConnectControl||Defines a WPF user control that provides a common user interface for the sign-in experience to Dynamics 365 with built-in encryption for securely storing your credentials/profile, and then reusing it at runtime to automatically sign in to Dynamics 365. More information: [Build Windows client applications using the XRM tools](../build-windows-client-applications-xrm-tools.md)|
||<xref:Microsoft.Xrm.Tooling.CrmConnectControl>|Provides classes and methods to define a WPF control for common sign-in experience.|
||<xref:Microsoft.Xrm.Tooling.CrmConnectControl.Model>|Provides classes and methods for the WPF control to communicate with the Customer Engagement Discovery Service APIs.|
||<xref:Microsoft.Xrm.Tooling.CrmConnectControl.Properties>|Provides a strongly-typed resource class for looking up localized strings in Customer Engagement.|
||<xref:Microsoft.Xrm.Tooling.CrmConnectControl.Utility>|Provides classes and methods to perform utility operations such as storing, using, and managing user credentials, accessing, loading and describing configuration entries, and managing trace control settings.|
|Microsoft.Xrm.Tooling.WebResourceUtility||Provides support for accessing information from the following two types of web resources in Customer Engagement: Image and XML. More information: [Build Windows client applications using the XRM tools](../build-windows-client-applications-xrm-tools.md)|
||<xref:Microsoft.Xrm.Tooling.WebResourceUtility>|Provides classes and methods to access information from Image and XML type of web resources in Customer Engagement.|
|Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase||Defines properties and customizations for the Customer Engagement package. More information: [Create packages for the Dynamics 365 Package Deployer](../create-packages-package-deployer.md)|
||<xref:Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase>|Provides classes and methods to define properties and customizations for the Customer Engagement package.|


  
### See also  
 [Programming models for Dynamics 365 Customer Engagement](../programming-models.md)   
 [Use the Early Bound Entity Classes](use-early-bound-entity-classes-code.md)   
 [Use the Late Bound Entity Class](use-late-bound-entity-class-code.md)   
 [Use Dynamics 365 Services](use-services-in-code.md)   
 [Entity and attribute naming conventions](entity-attribute-naming-conventions.md)   
 [Introduction to entity attributes](../introduction-entity-attributes.md)