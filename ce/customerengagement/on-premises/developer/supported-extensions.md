---
title: "Supported extensions (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "You can customize  Dynamics 365 Customer Engagement (on-premises) by using tools that are available in the Customer Engagement web application or that are described in the Dynamics 365 Customer Engagement (on-premises) SDK. These customizations are supported and can be upgraded. Customizations made using methods other than the ones described here are unsupported and could cause problems during updates and upgrades to Dynamics 365 Customer Engagement."
ms.custom: 
ms.reviewer: pehecke
ms.date: 09/05/2025
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 9386a572-0f6c-4edb-91f1-021ee63e6a58
caps.latest.revision: 64
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer

---
# Supported extensions

You can customize Dynamics 365 Customer Engagement (on-premises) by using tools that are available in the Dynamics 365 Customer Engagement (on-premises) web application or that are described in the [!INCLUDE [pn-sdk](../includes/pn-sdk.md)]. These customizations are supported and can be upgraded.  
  
 Customizations made using methods other than described here are unsupported and could cause problems during updates and upgrades to Dynamics 365 Customer Engagement (on-premises). For more information, see [Unsupported Customizations](supported-extensions.md#Unsupported).  
  
 Topics covered in technical articles published on Microsoft sites such as Learn are supported, but might not be upgradable.  
  
<a name="CustUsingWebApp"></a>

## Customizations using Dynamics 365 Customer Engagement (on-premises) web application  

 There are various tools included with Dynamics 365 Customer Engagement (on-premises) that you can use to customize it. Customizations made using the Dynamics 365 Customer Engagement (on-premises) tools and web application are fully supported and fully upgradeable.  
  
 The following customization methods can be used to produce fully supported customizations:  
  
- **Customization in the web application**. For more information, see the [Customization Guide (Dynamics 365 Customer Engagement (on-premises))](../customize/overview.md).  
  
- **Settings in the web application**. For more information, see  [Administer Dynamics 365 Customer Engagement (on-premises)](../admin/overview.md).  
  
- **Reporting Services**. For more information, see [Reporting and Analytics Guide (Dynamics 365 Customer Engagement (on-premises))](../analytics/reporting-analytics-with-dynamics-365.md).  
  
- **Using Filtered Views with external applications such as those in Microsoft Office**.  
  
> [!NOTE]
> *Fully supported* means that developer support can provide assistance for customizations and that application support can help customers running those modifications.  
>
> For more information about using the customization tools in the web application, see the [Customization Guide (Dynamics 365 Customer Engagement (on-premises))](../customize/overview.md).  
  
<a name="CustUsingSDK"></a>

## Customizations using the Dynamics 365 Customer Engagement (on-premises) SDK

 The [!INCLUDE [pn-sdk](../includes/pn-sdk.md)], technical articles, and sample code published on this site, and information released by the Dynamics 365 Customer Engagement (on-premises) Developer Support Team are included in the area of customizations using the [!INCLUDE[cc-dyn365-ce-web-services](../includes/cc-dyn365-ce-web-services.md)]. The specific actions and levels of supportability and upgradeability are described later in this article.  
  
### Dynamics 365 Customer Engagement (on-premises) web services

 Use of the web services is fully supported. The list of web services includes: Discovery Service, Organization Service (SDK),  Organization Data Service, the Web API, and the Deployment Service. We strive to keep the APIs backward compatible but reserve the right to change APIs for more features. Entity attributes may also change in future versions. For more information, see [Write Code for Dynamics 365 Customer Engagement (on-premises)(Web Services)](extend-dynamics-365-server.md).  
  
### Client-side JavaScript

 You can use [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] within Dynamics 365 Customer Engagement (on-premises) in three areas:  
  
- **Form Script event handlers**: You can configure form event handlers to call functions defined in [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resources.  
  
- **Command bar (ribbon) commands**: You can use the `<CustomRule>` or `<JavaScriptFunction>` elements to define actions that call functions defined within [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resources.  
  
- **Web resources and IFRAMEs**: You can use [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resources within HTML web resources. IFRAMES configured to allow cross-site scripting, or scripts within HTML web resources included in a form may interact with the documented `Xrm.Page` or `Xrm.Utility` methods within the form via the parent reference.  
  
  All interaction with Dynamics 365 Customer Engagement (on-premises) application pages must only be performed through the methods with the methods documented in the [Client API Reference](/powerapps/developer/model-driven-apps/clientapi/reference). Directly accessing the Document Object Model (DOM) of any Dynamics 365 Customer Engagement (on-premises) application pages isn't supported. The use of jQuery in form scripts and commands isn't recommended. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Client scripting in Customer Engagement (on-premises) using JavaScript](clientapi/client-scripting.md)  
  
  You can open Dynamics 365 Customer Engagement (on-premises) forms, views, dialogs, and reports using the methods documented in [Open Forms, Views, Dialogs and Reports with a URL](open-forms-views-dialogs-reports-url.md).  
  
### Ribbon customization  

 Use of `RibbonDiffXml` to add, remove, or hide ribbon elements is supported. Reuse of ribbon commands defined by Dynamics 365 Customer Engagement (on-premises) is supported; however, we reserve the right to change or deprecate the available commands. Reuse of JavaScript functions defined within ribbon commands isn't supported.  
  
### Solution file  

 Modification of an unmanaged solution file is supported as described in this documentation. Certain customization tasks are performed using these steps:  
  
- Export a solution component as an unmanaged solution.  
- Extract the contents of the solution package.  
- Edit the Customizations.xml file.  
- Repackage the solutions file.  
- Import the modified solution.  
  
    > [!NOTE]
    > Changes to the Customizations.xml file must conform to the CustomizationsSolution.xsd schema. For more information, see [Schemas Used in Dynamics 365 Customer Engagement (on-premises)](schemas-used-dynamics-365.md).  
  
The following supported tasks require this procedure:  
  
- Ribbon customization.  
- Application navigation customization using SiteMap.  
- Form and dashboard customization using FormXml.  
- Saved query customization.  
  
### Plug-ins
  
 The ability to create custom business logic using the plug-in mechanism described in this documentation is fully supported and upgradeable. This feature is available for all Dynamics 365 Customer Engagement (on-premises) deployments, including on-premises, IFD, and online deployments. However, plug-ins can only be registered and executed in the sandbox (isolation) of Dynamics 365 Customer Engagement (on-premises). [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Plug-ins for Extending Dynamics 365 Customer Engagement (on-premises)](write-plugin-extend-business-processes.md)  
  
 Adding your plug-in and custom workflow activity assemblies to the `%installdir%\server\bin\` folder is supported on Dynamics 365 Customer Engagement (on-premises) on-premises and IFD server installations only.  
  
### Workflow  

 The ability to create custom workflow activities (assemblies) to be called from workflow rules is fully supported and upgradeable. This feature is available for Dynamics 365 Customer Engagement (on-premises) on-premises, IFD, and Online. However, custom workflow activities can only be registered and executed in the sandbox (isolation) of Dynamics 365 Customer Engagement (on-premises). [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Automate your business processes in Customer Engagement](automate-business-processes-customer-engagement.md)  
  
 The ability to edit XAML workflows is fully supported and upgradeable. However, this feature is available for Dynamics 365 Customer Engagement (on-premises) on-premises and IFD only. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Automate your business processes in Customer Engagement (on-premises)](automate-business-processes-customer-engagement.md)  
  
<a name="SupportNET"></a>

## Support for .NET Framework Versions  

 The support considerations for custom code written the Microsoft .NET Framework 4.6.2 is described here.
  
- Any web service client created by using the Microsoft .NET Framework 4.6.2 (or newer versions) that calls the Dynamics 365 Customer Engagement (on-premises) web services is fully supported in Dynamics 365 Customer Engagement (on-premises).  

  > [!IMPORTANT]
  > You should build any custom client applications using [!INCLUDE [pn-net-framework-462-long](../includes/pn-net-framework-462-long.md)] or newer.
  > Beginning with the Dynamics 365 Customer Engagement (on-premises) version 9, only applications using Transport Level Security (TLS) 1.2 or better security is allowed to connect. TLS 1.2 isn't the default protocol used by [!INCLUDE [pn-net-framework-452-short](../includes/pn-net-framework-452-short.md)], but it is in  [!INCLUDE [pn-net-framework-462-short](../includes/pn-net-framework-462-short.md)].
  >
  > Enforcement of this higher standard for security is only applied to Dynamics 365 Customer Engagement (on-premises) version 9 at this time. If your clients are designed to connect to any version or deployment type, you can prepare by recompling the application to use [!INCLUDE [pn-net-framework-462-short](../includes/pn-net-framework-462-short.md)].
  > More information: [Blog Post: Updates coming to Dynamics 365 Customer Engagement (on-premises) connection security](https://blogs.msdn.microsoft.com/crm/2017/09/28/updates-coming-to-dynamics-365-customer-engagement-connection-security/)
  
- Any .NET assembly that is created with the Microsoft .NET Framework 4.6.2 for use in Dynamics 365 Customer Engagement (on-premises) as a Dynamics 365 Customer Engagement (on-premises) plug-in assembly or as a Dynamics 365 Customer Engagement (on-premises) custom workflow activity is supported.  
- Any visualization (chart) that is created with [!INCLUDE[pn_NET_Framework_452_short](../includes/pn-net-framework-452-short.md)].

More information: [Visual Studio and the .NET Framework](visual-studio-dot-net-framework.md)  
  
<a name="Unsupported"></a>

## Unsupported customizations
  
 Modifications to Dynamics 365 Customer Engagement (on-premises) that are made without using either the methods described in this documentation or Dynamics 365 Customer Engagement (on-premises) tools aren't supported and aren't preserved during updates or upgrades of Dynamics 365 Customer Engagement (on-premises). Anything that isn't documented in this documentation and supporting documents isn't supported. Additionally, unsupported modifications could cause problems when you update through the addition of hotfixes or service packs or upgrade Dynamics 365 Customer Engagement (on-premises). To minimize update and upgrade issues, don't modify any Dynamics 365 Customer Engagement (on-premises) file that you didn't create yourself.  
  
 Here is a list of unsupported action types that are frequently asked about:  
  
- Modifications to any .aspx, .css, .htm, .js, .xml, .jpg, or .gif files or the addition of files in the `wwwroot` directories of the Dynamics 365 Customer Engagement (on-premises) application, Dynamics 365 Customer Engagement (on-premises) tools, or Dynamics 365 Customer Engagement (on-premises) files located at Program Files\\Dynamics 365 Customer Engagement (on-premises). However, if you made changes to these files, these files are checked for modifications and won't be overwritten.  
  
- Modifications to the Dynamics 365 Customer Engagement (on-premises) website (file and website settings). Custom applications should be installed in a different website. Unsupported modifications includes changes to the file system access control lists (ACLs) of any files on the Dynamics 365 Server.  
  
- Use of client certificates isn't supported. If you configure the Dynamics 365 Customer Engagement (on-premises) website to require IIS client certificates, you receive authentication failures for any applications that were built using the SDK.  
  
- Modifications to the physical schema of the database, other than adding or updating indexes. Such modifications includes any actions performed against the database without using the System Customization capabilities in the web application or using the metadata APIs that are described in this SDK documentation. Modifying tables, stored procedures, or views in the database isn't supported. Adding tables, stored procedures, or views to the database is also not supported because of referential integrity or upgrade issues. For Dynamics 365 Customer Engagement (on-premises) on-premises deployments, adding indexes is supported per the guidelines in the [Deploying and administering Microsoft Dynamics 365 Customer Engagement (on-premises)](/previous-versions/dynamicscrm-2015/deployment-administrators-guide/hh699811(v=crm.7)) documentation. These restrictions apply to all Dynamics 365 Customer Engagement (on-premises) databases and the [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)] local database.  
  
  > [!IMPORTANT]
  > When you change the database without using the support methods for system customization, you run the risk of problems occurring during updates and upgrades.  
  
- Data (record) changes in the Dynamics 365 Customer Engagement (on-premises) database using SQL commands or any technology other than described in this documentation.  
  
- Referencing any Dynamics 365 Customer Engagement (on-premises) dynamic-link libraries (DLLs) other than listed here:  
  
  - Microsoft.Crm.Outlook.Sdk.dll
  - Microsoft.Crm.Sdk.Proxy.dll
  - Microsoft.Xrm.Sdk.dll
  - Microsoft.Xrm.Sdk.Data.dll  
  - Microsoft.Xrm.Sdk.Deployment.dll  
  - Microsoft.Xrm.Sdk.Workflow.dll
  - Microsoft.Xrm.Tooling.Connector.dll
  - Microsoft.Xrm.Tooling.CrmConnectControl.dll
  - Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase.dll
  - Microsoft.Xrm.Tooling.WebResourceUtility.dll
  
- The use of application programming interfaces (APIs) other than the documented APIs in the web services: Web API, Organization Service, Deployment Service, Discovery Service, Organization Data Service.  
  
- To achieve the appearance and behavior of Dynamics 365 Customer Engagement (on-premises), the reuse of any Dynamics 365 Customer Engagement (on-premises) user interface controls, including the grid controls. These controls may change or be overwritten during an upgrade. We don't recommend that you use or change the Default.css file in the Dynamics 365 Customer Engagement (on-premises) root installation folder.  
  
- The reuse of any Dynamics 365 Customer Engagement (on-premises) JavaScript code, including ribbon commands. This code may change or be overwritten during an upgrade.  
  
- Modifications to any one of the Dynamics 365 Customer Engagement (on-premises) forms or adding new forms, such as custom .aspx pages, directly to [!INCLUDE[pn_MS_Outlook_Full](../includes/pn-ms-outlook-full.md)] or making changes to .pst files. These changes are not upgraded.  
  
- Making customizations except when you use the Dynamics 365 Customer Engagement (on-premises) supported tools available offline in the [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)].  
  
- The use of custom HttpModules to inject HTML/DHTML into the Dynamics 365 Customer Engagement (on-premises) Forms.  
  
- Creating a plug-in assembly for a standard Dynamics 365 Customer Engagement (on-premises) assembly (Microsoft.Crm.*.dll) or performing an update or delete of a platform created `pluginassembly` isn't supported.  

- Creating an [!INCLUDE[pn_Internet_Information_Services](../includes/pn-internet-information-services.md)] application inside the Dynamics 365 Customer Engagement (on-premises) website for any VDir and specifically within the ISV folder isn't supported. The \<crmwebroot>\ISV folder is no longer supported.  
  
- Editing a solutions file to edit any solution components other than ribbons, forms, SiteMap, or saved queries isn't supported. For more information, see [Support for Editing the Customization File](customize-dev/when-edit-customization-file.md). Defining new solution components by editing the solutions file isn't supported. Editing web resource files exported with a solution isn't supported. Except for the steps documented in [Maintain Managed Solutions](maintain-managed-solutions.md), editing the contents of a managed solution isn't supported.  
  
- Silverlight [Application Library Caching](/previous-versions/windows/) isn't supported.  
  
- Displaying an entity form within an IFrame embedded in another entity form isn't supported.

- Plugin and Workflow Assemblies must contain all the necessary logic within the respective dll. Plugins may reference some core .NET assemblies. However, we don't support dependencies on .NET assemblies that interact with low-level Windows APIs, such as the graphics design interface. Previously, Dynamics 365 Customer Engagement allowed for assemblies to refer to these interfaces, but to adhere to our security standards, changes to this behavior are required.
  
### See also  
 [Choose your development style for managed code](choose-development-style.md)<br/>
 [Write Code for Dynamics 365 Customer Engagement (on-premises)(Web Services)](extend-dynamics-365-server.md)<br/>
 [Client scripting in Customer Engagement (on-premises) using JavaScript](clientapi/client-scripting.md)

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
