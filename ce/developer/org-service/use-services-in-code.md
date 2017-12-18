---
title: "Use Dynamics 365 services in code (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This article discusses about the Discovery Service and Organization Service that can be used to identify your organization and to access Dynamics 365 data"
ms.custom: ""
ms.date: 12/15/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: bae224ef-2f5d-4555-a33c-9225b9365ed6
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Use Dynamics 365 services in code

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement organization service provides two web services that can be used to identify your organization and to access [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] data. This section describes how to use these services when you are developing applications or customizations for [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)].  
  
## Discovery Service web service  
 A single [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] installation can host multiple organizations on multiple servers. Therefore, it is important to specify which organization you want to access. The Discovery Service web service returns a list of organizations that the specified user belongs to and the URL endpoint address for each organization. <xref:Microsoft.Xrm.Sdk.Discovery.IDiscoveryService> is the interface that provides the <xref:Microsoft.Xrm.Sdk.Discovery.IDiscoveryService.Execute*> method you use with this service.
[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Discover the URL for your organization using the Organization Service](discover-url-organization-organization-service.md)  
  
## Organization Service web service  
 The primary web service for accessing data and metadata in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] is the Organization Service web service. <xref:Microsoft.Xrm.Sdk.IOrganizationService> is the interface that describes the methods available to use this service. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Use IOrganizationService for Your Organization](use-organization-service-read-write-data-metadata.md)  
  
## Add the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] assemblies to your project  
 Most of the time you’ll use the SDK assemblies in your development projects. Using the assemblies is the recommended developer scenario for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. These assemblies are available from NuGet packages. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Assemblies Included in the Dynamics 365 SDK](assemblies-included-sdk.md) and [Subscribe to SDK assembly updates using NuGet](subscribe-sdk-assembly-updates-using-nuget.md)
  
## Add the service reference to your project  
 You may have a development scenario where you want to include the service reference in your project rather than using the assemblies. To find the correct service references for your organization, see [Developer resources page](../developer-resources-page.md).
> [!NOTE]
> While it is technically possible to use the Organization Service endpoint without assemblies, the Web API provides a modern RESTful endpoint that is easier to use. More information: [Use the Dynamics 365 Customer Engagement Web API](../use-microsoft-dynamics-365-web-api.md)
  
### See also  
 [Use IDiscoveryService to Discover the URL for Your Organization](discover-url-organization-organization-service.md)   
 <xref:Microsoft.Xrm.Sdk.Discovery.IDiscoveryService>   
 [Use IOrganizationService for Your Organization](use-organization-service-read-write-data-metadata.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 [Connect to the Web Services in Dynamics 365 Customer Engagement](../authenticate-users.md)   
 [Use the Early Bound Entity Classes](use-early-bound-entity-classes-code.md)   
 [Write Code for Dynamics 365 (Web Services)](../extend-dynamics-365-server.md)   
 [Assemblies Included in the Dynamics 365 SDK](assemblies-included-sdk.md)   
 [Microsoft Dynamics CRM Developer Center](https://msdn.microsoft.com/dynamics/crm/default.aspx)