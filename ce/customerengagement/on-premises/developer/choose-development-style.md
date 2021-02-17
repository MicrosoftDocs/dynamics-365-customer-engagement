---
title: "Choose your development style for Dynamics 365 Customer Engagement (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Learn about the various options available to developers to make use of Dynamics 365 Customer Engagement web services (SDK) or to extend the application."
ms.custom: 
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 0fcf59aa-d564-4c9b-9042-40df8664f831
caps.latest.revision: 64
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Choose your development style for Dynamics 365 Customer Engagement (on-premises)

The SDK offers a variety of methods and technologies to use when you write code to access the [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] web services or to extend the application. This topic provides guidance on the development style to choose depending on your technology area..  

<a name="NetOrNot"></a>   
## .NET vs. non-.NET development  
 The first thing to consider while writing code to extend Dynamics 365 Customer Engagement (on-premises) is whether your code is written using [!INCLUDE[pn_NET_Framework](../includes/pn-net-framework.md)].  

- If your code is written using the [!INCLUDE[pn_NET_Framework](../includes/pn-net-framework.md)], consider using one of the following depending on what you are creating:  

  - If you are creating plug-ins, custom workflow activities, or custom XAML workflows, use the SDK assemblies, [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [.NET Development: Use Dynamics 365 Customer Engagement app assemblies](#SDKAssemblies)  

  - If you are creating Windows applications for Dynamics 365 Customer Engagement (on-premises), use XRM tooling assemblies. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [.NET Development: Use XRM Tooling assemblies](#XrmTooling)  

  - If you are creating non-Windows applications for [!INCLUDE[pn_dyn_365](../includes/pn-dyn-365.md)], use Web API. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the Dynamics 365 Customer Engagement Web API](use-microsoft-dynamics-365-web-api.md)  

- If your code is not written using  the [!INCLUDE[pn_NET_Framework](../includes/pn-net-framework.md)], use  Web API. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the Dynamics 365 Customer Engagement Web API](use-microsoft-dynamics-365-web-api.md)  

  The following flow diagram illustrates which development style to choose when developing for Dynamics 365 Customer Engagement (on-premises):  

  ![Development style flow for Dynamics 365 Customer Engagement (on-premises)](media/whentousewebapi.jpg "Development style flow for Dynamics 365 Customer Engagement (on-premises)")  

<a name="SDKAssemblies"></a>   

## .NET Development: Use SDK assemblies  

The SDK assemblies provides you with classes that you can use to connect to Dynamics 365 Customer Engagement (on-premises) web services to identify your organization and perform common business  operations like create, retrieve. update and delete data in Dynamics 365 Customer Engagement (on-premises). The SDK assemblies are available as NuGet packages. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Subscribe to SDK assembly updates using NuGet](/powerapps/developer/common-data-service/org-service/subscribe-sdk-assembly-updates-using-nuget).  

> [!IMPORTANT]
>  You should use the latest version of the SDK assemblies to create your plug-ins, custom workflow activities, or XAML workflows. Starting with version 9.0, you should use .NET Framework version 4.6.2.
> 
>  However, if you are using .NET Framework 4 and using the  [CrmConnection](https://msdn.microsoft.com/library/microsoft.xrm.client.crmconnection\(v=crm.6\).aspx) class of SDK extensions ([deprecated](https://msdn.microsoft.com/library/dn281891.aspx#SDKExtensions)) to connect to [!INCLUDE[pn_crm_8_1_0_op](../includes/pn-crm-8-1-0-op.md)] (on-premises) and [!INCLUDE[pn_crm_8_1_0_online_subsequent](../includes/pn-crm-8-1-0-online-subsequent.md)] (version 8.1.0) or later, you will need to use version 6.1.2 of the assemblies. Otherwise, you won't be able to connect. For more information about backward compatibility, see [Blog: Dynamics 365 Customer Engagement (on-premises) SDK Backwards Compatibility](https://go.microsoft.com/fwlink/?linkid=842744)  

 When using the SDK assemblies to write code, you work with the Organization web service (SOAP endpoint) to connect to an instance of Dynamics 365 Customer Engagement (on-premises), and perform the supported web service operations. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the Dynamics 365 Customer Engagement Organization Service](use-microsoft-dynamics-365-organization-service.md)  

> [!NOTE]
>  The SDK assemblies will eventually be migrated to internally use the Web API instead of the 2011 SOAP endpoint. When this happens, any code written using the SDK assemblies will continue to be supported as it will automatically transfer from the 2011 SOAP endpoint to use the Web API. This update will be fully transparent to you; additional details will be published in future SDK releases. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Microsoft Dynamics CRM 2011 endpoint](https://msdn.microsoft.com/library/dn281891.aspx#Crm2011Endpoint)  

- **Create and deploy plug-ins or custom workflow activities**: The plug-in and custom workflow activity classes allow you to create event handlers to perform custom business logic that you can integrate with Dynamics 365 Customer Engagement (on-premises) to modify or augment the standard behavior of the platform.  

     If you write plug-ins and custom workflow activities from scratch, you must use the Plug-in Registration Tool to register them. This tool provides a graphical user interface and supports registering plug-ins and custom workflow activities with Dynamics 365 Customer Engagement (on-premises). [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Plug-in Development](plugin-development.md) and [Custom Workflow Activities (Workflow Assemblies)](custom-workflow-activities-workflow-assemblies.md)  

- **Create and deploy custom XAML workflows**: Dynamics 365 Customer Engagement (on-premises) and IFD supports the ability to create custom XAML workflows. Using the Microsoft Visual Studio Workflow Designer, you can create custom XAML workflows, also called declarative workflows, by dragging workflow activities from the toolbox onto the design surface, creating variables, and setting properties of these activities to implement the workflow' functionality. You can use built-in Windows Workflow Foundation activities or the process activities that are specific to Dynamics 365 Customer Engagement (on-premises). [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [XAML workflows](https://docs.microsoft.com/previous-versions/dynamicscrm-2016/developers-guide/gg309458(v=crm.8))

[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]

- **Early-bound and late-bound programming models for Dynamics 365 Customer Engagement (on-premises) entities**: When using the SDK assemblies, you can choose between two programming models:  


  |  Early bound | Late bound |
  |------------|--------------|
  | Use the code generation tool (CrmSvcUtil) to create early-bound entity classes, derived from the <xref:Microsoft.Xrm.Sdk.Entity> class, which you can use to access business data in Dynamics 365 Customer Engagement. These classes include one class for each entity in your installation, including custom entities. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the early bound entity classes in code](org-service/use-early-bound-entity-classes-code.md) | The <xref:Microsoft.Xrm.Sdk.Entity> class contains the logical name of an entity and a property-bag array of the entity's attributes. This lets you use late binding so that you can work with types such as custom entities and custom attributes that were not present when your application was compiled. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the late bound entity class in code](org-service/use-late-bound-entity-class-code.md) |


- **Query data in Dynamics 365 Customer Engagement (on-premises)**: There are three ways in which you can retrieve or query data from Dynamics 365 Customer Engagement (on-premises) using the SDK assemblies: FetchXML, QueryExpression, and .NET LINQ. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Retrieve data with queries using SDK assemblies](org-service/retrieve-data-queries-sdk-assemblies.md)  

<a name="XrmTooling"></a>   
## .NET Development: Use XRM Tooling assemblies 

 The XRM tooling assemblies leverage the SDK assembly APIs (Organization service and IDiscoveryService) to provide easy authentication support with fewer lines of code and through [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlets. All the function calls in these classes provide thread-safety for actions performed in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] in a multithreaded environment. XRM tooling provides a common sign-in control with integrated authentication logic and an ability to securely store and reuse the authentication information to provide a consistent and seamless sign-in experience to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] from your Windows client applications. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Build windows client applications using the XRM tools](build-windows-client-applications-xrm-tools.md)  

 The XRM tooling assemblies are available as NuGet packages; the packages are found under the [crmsdk](https://www.nuget.org/profiles/crmsdk) profile. Select any package in the list with "Xrm Tooling"  as the name  to navigate to the package details page. 

 With the connection string support available in XRM tooling and the [deprecation](https://msdn.microsoft.com/library/dn281891.aspx#SDKExtensions) of SDK extensions for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], you must  use the XRM tooling assemblies instead of the [CrmConnection](https://msdn.microsoft.com/library/microsoft.xrm.client.crmconnection\(v=crm.6\).aspx) class to connect to Dynamics 365 Customer Engagement (on-premises). [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use connection strings in XRM tooling to connect to Dynamics 365 Customer Engagement (on-premises)](xrm-tooling/use-connection-strings-xrm-tooling-connect.md) and [Sample: Simplified connection quick start using Dynamics 365 Customer Engagement (on-premises)](xrm-tooling/sample-simplified-connection-quick-start.md)  

<a name="Connect"></a>   
## Choose how to connect to Dynamics 365 Customer Engagement (on-premises)  
 Depending on your development style (.NET vs. non-.NET), you'll choose how your code authenticates users in Dynamics 365 Customer Engagement (on-premises). The following table provides you brief information about the authentication model you should consider depending on your development style:  


| Development Style | Description |
|----------|---------------|
|  .NET: SDK assemblies | The SDK assemblies use [Windows Communication Foundation](https://msdn.microsoft.com/library/dd456779.aspx) (WCF) technology to establish a communication channel with the Dynamics 365 Customer Engagement (on-premises) web services. SDK simplifies use of the WCF technology by providing helper proxy classes that make it easy to write applications that connect to and authenticate with the Dynamics 365 Customer Engagement (on-premises) web services.<br /><br /> More information: [Sample: Authenticate users with Dynamics 365 web services](sample-authenticate-users-web-services.md) |
| .NET: XRM tooling assemblies   | Use the connection string, <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient> class, or XRM tooling PowerShell cmdlets to connect to Dynamics 365 Customer Engagement (on-premises).<br /><br /> More information: [Use connection strings in XRM tooling to connect to Dynamics 365 Customer Engagement (on-premises)](xrm-tooling/use-connection-strings-xrm-tooling-connect.md), [Use CrmServiceClient constructors to connect to Dynamics 365 Customer Engagement](/powerapps/developer/common-data-service/xrm-tooling/use-crmserviceclient-constructors-connect), [Use PowerShell cmdlets for XRM tooling to connect to Dynamics 365 Customer Engagement (on-premises)](xrm-tooling/use-powershell-cmdlets-xrm-tooling-connect.md)                                 |
| Dynamics 365 Customer Engagement (on-premises) Web API | More information: [Authenticate to Dynamics 365 Customer Engagement with the Web API](webapi/authenticate-web-api.md) |

 For detailed information about authenticating users to connect to Dynamics 365 Customer Engagement (on-premises), see [Authenticate users in Dynamics 365 Customer Engagement (on-premises)](authenticate-users.md)  

### See also  
 [Authenticate users in Dynamics 365 Customer Engagement (on-premises)](authenticate-users.md)   
 [Tutorials for Learning About Development for Dynamics 365 Customer Engagement (on-premises)](tutorials-resources-sdk.md)   
 [Write Code for Dynamics 365 Customer Engagement 2011 and Dynamics 365 Customer Engagement (Web Services, JavaScript)](extend-dynamics-365-server.md)   
 [Introduction to Programming Models for Dynamics 365 Customer Engagement (on-premises)](programming-models.md)   


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]