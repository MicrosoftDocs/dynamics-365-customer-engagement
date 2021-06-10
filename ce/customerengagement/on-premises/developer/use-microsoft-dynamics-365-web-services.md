---
title: "Use Dynamics 365 Customer Engagement (on-premises) web services (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "This topic introduces available web service APIs that you will use when you write programs for Dynamics 365 Customer Engagement (on-premises) and provides basic information to understand and compare them"
ms.custom: 
ms.date: 09/05/2019
ms.reviewer: pehecke
ms.service: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: fd004500-99bf-4391-84ae-b1e41a2ecd77
caps.latest.revision: 14
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Use Dynamics 365 Customer Engagement (on-premises) web services

Web services provide APIs that you’ll use when you write programs for Dynamics 365 Customer Engagement (on-premises). This topic introduces available web services and provides basic information to understand and compare them.  
  
<a name="bkmk_webapi"></a>

## Web API  

 The Web API was introduced with version 8.0 and was incrementally updated to provide parity with the Organization service. With this release parity was achieved.

 Compared to the Organization service, the Web API provides better compatibility across a wide variety of programming languages, platforms, and devices. The Web API implements the OData (Open Data Protocol) v4. OData is an OASIS standard for building and consuming RESTful APIs over rich data sources. You can learn more at the [OData protocol](https://www.odata.org/) and the [OASIS standard](https://www.oasis-open.org/standards#odatav4.0) websites.  
  
 Because the Web API is built on open standards, you aren’t required to use client libraries specific to Dynamics 365 Customer Engagement (on-premises). You can choose to compose HTTP requests for specific operations or use third-party libraries to generate classes for whatever language or platform you want to use. View a [list of available libraries](https://www.odata.org/libraries/).  
  
 Eventually the Web API will replace the Organization service and Organization Data service but both of these existing web services will be available to enable a gradual transition to a single Web API. The Web API should be your first choice for new development that will support Dynamics 365 Customer Engagement (on-premises) and future versions of Dynamics 365 Customer Engagement (on-premises). Use the Web API for any projects that access Dynamics 365 Customer Engagement (on-premises) data with code that doesn’t run on the server, including requests from web resources and form scripts that run in Dynamics 365 Customer Engagement (on-premises) application clients. At this time you can’t easily use the Web API for code that runs on the server, such as in plug-ins or workflow assemblies. You should continue to use the Organization service for these purposes.
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the Dynamics 365 Customer Engagement Web API](use-microsoft-dynamics-365-web-api.md).  
  
<a name="bkmk_organizationservice"></a>

## Organization service

The Organization service has been available since [!INCLUDE[pn_CRM_2011](../includes/pn-crm-2011.md)]. It’s the web service that most developers working with Dynamics 365 Customer Engagement (on-premises) are already familiar with. The Organization service is optimized for use with .NET. There are a set of .NET assemblies and tools to allow you to generate strongly typed classes and proxies that streamline the development process and enjoy a better development experience using [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)]. 

The .NET assemblies for the Organization service currently use a 2011 SOAP endpoint which has been deprecated. The SDK assemblies will eventually be migrated to internally use the Web API instead of the 2011 SOAP endpoint. When this happens, any code written using the SDK assemblies will continue to be supported as it will automatically transfer from the 2011 SOAP endpoint to use the Web API. This update will be fully transparent to you; additional details will be published in future SDK releases. 

See [Choose your development style](choose-development-style.md) for guidance about whether to use the Organization service or Web API.

If you’re a .NET developer with no requirements to support other platforms, you don’t have to move to the Web API right away. You can still use the Organization service to support any functionality you want to deploy to organizations using older versions of Dynamics 365 Customer Engagement (on-premises) released before the Web API was made available.  
  
Business logic that runs in plug-ins or workflow assemblies on the server expect to use the Organization service. Input and output parameters use specific classes defined with the assemblies that support the Organization service.  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the Dynamics 365 Customer Engagement (on-premises) Organization service](use-microsoft-dynamics-365-organization-service.md)  
  
<a name="bkmk_organizationdataservice"></a>
 
## Organization Data service

 The Organization Data service, also sometimes known as the “OData” or “REST” endpoint has also been available since [!INCLUDE[pn_CRM_2011](../includes/pn-crm-2011.md)]. This service implemented the OData v2 standard. While this service will continue to be available as-is for years to come, we are deprecating it in Dynamics 365 Customer Engagement (on-premises). The Organization Data service has always been limited to performing create, read, update, and delete operations and never supported the ability to call specialized messages used in the Organization service, so it could never reach parity with the functionality of the Organization service. Changes implemented in the OData standards between v2 and v4 do not allow for upgrading the service to meet the requirements of a service that has parity with the Organization Services. We were able to apply a lot of the feedback we received about the Organization Data Service and apply it to make the Web API better.  
  
 This release of the [!INCLUDE [pn-sdk](../includes/pn-sdk.md)] does not include information about the Organization Data Service. You can find information about the Organization Data Service in the documentation for the [!INCLUDE[pn_crm_2015](../includes/pn-crm-2015.md)] release at [Use the OData endpoint with web resources](https://msdn.microsoft.com/library/gg334279\(v=crm.7\).aspx).  
  
<a name="bkmk_discovery"></a>   
## Discovery web services  
 Dynamics 365 Customer Engagement (on-premises) is a multi-tenant application. This means that a single deployment can host multiple instances of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] (on-premises), each with its own data, each available via a different URL. Additionally, especially when Dynamics 365 Servers are hosted in a data center, the specific server can change as resources are moved or load balanced. Discovery web services provide a way for a client to detect which servers and organizations are available for a user to connect to based on their user account. You can choose to use either the OData V4 RESTful API or the SOAP based SDK assembly API to access the Discovery web service. The RESTful API provides the same benefits as the SOAP web service, and it is easier to consume for a wider range of programming languages, platforms, and devices.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Discover the URL for your organization using the Web API](webapi/discover-url-organization-web-api.md) or [Discover the URL for Your Organization With IDiscoveryService Web Service](org-service/discover-url-organization-organization-service.md)  
  
<a name="bkmk_deployment"></a>   
## Deployment web service  
 For Dynamics 365 Customer Engagement (on-premises) you can perform actions to manage your deployment programmatically using the Deployment web service. These are essentially the same operations you can perform on the server using the Deployment manager tool client installed on the server. You can create, import, or delete organizations as well as apply certain settings in code. This may be useful when you want to automate certain processes if you are providing a hosting service or if you want to automate creation of environments for testing.  
  
  
### See also  
 [Authenticate users in Dynamics 365 Customer Engagement](authenticate-users.md)   
 [Authenticate users to Dynamics 365 Customer Engagement (on-premises)](authenticate-users.md)   
 [Use Dynamics 365 Customer Engagement web services](use-microsoft-dynamics-365-web-services.md)   
 [Build Windows client applications using the XRM tools](build-windows-client-applications-xrm-tools.md)   
 [Model-driven apps Developer Guide](/powerapps/developer/model-driven-apps/overview)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]