---
title: "Programming models (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Dynamics 365 Customer Engagement (on-premises) offers several programming models designed to give you the flexibility to decide what works best for your needs."
ms.custom: 
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 14127ed4-0506-4071-a408-6052048ba299
author: JimDaly
ms.author: jdaly
manager: annbe
tags: 
  - aug2017
  - MigrationHO
search.audienceType: 
  - developer

---
# Programming models for Dynamics 365 Customer Engagement (on-premises)

Microsoft Dynamics 365 Customer Engagement (on-premises) offers several programming models designed to give you the flexibility to decide what works best for your needs.

The following diagram illustrates the key programmability scenarios for Dynamics 365 Customer Engagement (on-premises). Use the appropriate Dynamics 365 Customer Engagement (on-premises) programming models for the type of solutions you create.

![Programmability Scenarios for Dynamics 365 Customer Engagement (on-premises)](media/crm-v8-programmabilityscenarios.png "Programmability Scenarios for Dynamics 365 Customer Engagement (on-premises)")  

<a name="bkmk_ExternalApplications"></a>

## Connecting to Dynamics 365 Customer Engagement (on-premises)

 When you write clients to access data in Dynamics 365 Customer Engagement (on-premises) you have two options: you can use the Web API or the organization service.

<a name="bkmk_webAPI"></a>

### Web API
 The Web API was introduced with [!INCLUDE[pn_crm_2016_and_online_full](../includes/pn-crm-2016-and-online-full.md)] and it provides a development experience that can be used across a wide variety of programming languages, platforms, and devices. The Web API implements the [OData](https://odata.org) (Open Data Protocol) v4. OData is an OASIS standard for building and consuming RESTful APIs over rich data sources.

 When you use the Web API, you can choose from [a list of community-supported libraries that support the OData v4 standard](https://www.odata.org/libraries/). You can also choose to write code using HTTP directly. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the Dynamics 365 Customer Engagement Web API](use-microsoft-dynamics-365-web-api.md)

 When you connect to [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] (on-premises) environments with Internet-facing deployment (IFD), you can use [Azure AD Authentication Libraries (ADAL)](/azure/active-directory/azuread-dev/active-directory-authentication-libraries) to enable authentication from a wide variety of programming languages and platforms. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Authenticate to Dynamics 365 Customer Engagement (on-premises) with the Web API](webapi/authenticate-web-api.md)

> [!NOTE]
> The organization data service ("REST endpoint" or  "OData endpoint") is an OData v2 service that was deprecated in [!INCLUDE[pn_crm_2016_and_online_full](../includes/pn-crm-2016-and-online-full.md)] in favor of the Web API. The organization data service isn’t included in the preceding diagram. The organization service is still available to support code that used it. However, for any new development for Dynamics 365 Customer Engagement (on-premises) we recommend using the Web API. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the OData endpoint with web resources](https://msdn.microsoft.com/library/gg334279\(v=crm.7\).aspx)

<a name="bkmk_organizationService"></a>

### Organization service
 If you are a .NET developer you can use either the Web API or the organization service. With the organization service you can use a set of assemblies and tools to generate strongly typed classes that include custom entities and attributes that have been added to an instance of Dynamics 365 Customer Engagement (on-premises).

 With SDK assemblies and tools for code generation you can also include an <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext>, which is based on the same concept as the [DataServiceContext](/dotnet/api/system.data.services.client.dataservicecontext) in [!INCLUDE[pn_WCF_long](../includes/pn-wcf-long.md)] Data Services. This class lets you track changes, manage identities and relationships, and gives you access to the Dynamics 365 Customer Engagement (on-premises) [!INCLUDE[pn_LINQ](../includes/pn-linq.md)] provider so you can build queries using LINQ. When you use the tools for code generation, you get strongly typed classes for entities and attributes that are defined when the code generation tool is run. These are called *early-bound* classes. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the Early Bound Entity Classes in Code](/powerapps/developer/data-platform/org-service/early-bound-programming#early-boundearly-bound)

 When your code needs to work with entities and attributes that weren’t known at the time that the code generation tools were run, you can use an <xref:Microsoft.Xrm.Sdk.Entity> class that allows for specifying entities and entity attribute in your code. This *late-bound* style of writing code provides greater flexibility but doesn’t allow for compile-time checking of all types so that no implicit casts occur. Late binding checks types only when the object is created or an action is performed on the type. The Entity class requires types to be explicitly specified to prevent implicit casts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the Late Bound Entity Class in Code](/powerapps/developer/data-platform/org-service/early-bound-programming)

 If you create a [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] client or are using [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)], Xrm.Tooling provides a set of APIs that use the SDK assemblies to provide additional capabilities and resources specifically for [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] client development. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Build Windows client applications using the XRM tools](build-windows-client-applications-xrm-tools.md)

<a name="bkmk_internalLogic"></a>

## Extending on the server
 You can write code that listens for events and applies custom business logic to modify or augment the standard behavior of the platform. This code is only available to be written using .NET managed code and the developer experience is based on the same objects defined in the SDK assemblies. You can work with the organization service to perform operations with Dynamics 365 Customer Engagement (on-premises) data. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Write Plug-Ins to Extend Business Processes](write-plugin-extend-business-processes.md).

 You can also create custom processes based on the [Windows Workflow Foundation](https://msdn.microsoft.com/netframework/aa663328.aspx) programming model. You can create several different types of processes. Most of the time you’ll use the workflow designer. But when there is some capability you can’t achieve in the designer, you can define processes using code. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Write Workflows to Automate Business Processes](automate-business-processes-customer-engagement.md)

<a name="bkmk_applicationExtensions"></a>

## Extending in the application
 Each of the client applications provided by Dynamics 365 Customer Engagement (on-premises) includes the ability to define customizations and deploy to multiple types of clients. The web application, [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)], [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)], and [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] each provide capabilities to include custom navigation and command options as well as the `Xrm` object model and `Xrm.Utility` functions you can use with [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] to provide responsive experiences in the client. [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] libraries, HTML pages, images, and other types of files that can be used or displayed in the client are available as URL addressable web resources. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use JavaScript with Customer Enagement apps](use-javascript.md) and [Web Resources for Dynamics 365 Customer Engagement (on-premises)](web-resources.md).

 When you need to access Dynamics 365 Customer Engagement (on-premises) data that isn’t available in the context where your [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] code is running, you can make calls to the server to get the data you need. The organization service can be used, but it is much easier to use the Web API with JSON rather than the XML required by the organization service. Because your script runs in the context of the application, you are automatically authenticated. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Get started with the Dynamics 365 Customer Engagement Web API (client-side JavaScript)](/powerapps/developer/model-driven-apps/clientapi/get-started-web-api-client-side-javascript)

### See also
[Developer Guide for Dynamics 365 Customer Engagement (on-premises)](overview.md)<br />
[Get started](get-started-sdk.md)<br />
[Tutorials and resources](tutorials-resources-sdk.md)<br />
[Best practices](best-practices-sdk.md)<br />
[Developer tools](developer-tools.md)<br/>


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]