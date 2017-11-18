---
title: "Subscribe to SDK assembly updates using NuGet (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Use of NuGet packages in your application project enables you to keep your project up-to-date with the latest releases of the SDK assemblies and tools. Learn how to subscribe to SDK assembly updates using NuGet"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 39957a5b-ca3b-4598-93d3-7846503acaeb
caps.latest.revision: 23
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Subscribe to SDK assembly updates using NuGet

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

.NET SDK assemblies and some command-line tools are available through a software distribution website called [nuget.org](http://www.nuget.org). Use of [!INCLUDE[tn_nuget](../../includes/tn-nuget.md)] packages in your application project enables you to keep your project up-to-date with the latest releases of the SDK assemblies and tools. [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)] has supported this capability since version 2010 and there is even a standalone [!INCLUDE[tn_nuget](../../includes/tn-nuget.md)] client for those developers that don’t develop in [!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)]. Another advantage of using [!INCLUDE[tn_nuget](../../includes/tn-nuget.md)] packages in your projects is that assembly references and dependencies are automatically taken care of for you. [!INCLUDE[tn_nuget](../../includes/tn-nuget.md)] packages are available for the [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement SDK as well as for the previous versions – 2011 , 2013, and 2015.  
  
<a name="BKMK_GetNuGetPackages"></a>

## Where to find the NuGet SDK packages

 The [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] SDK packages are found under the [crmsdk](https://www.nuget.org/profiles/crmsdk) profile. These are the official [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] SDK packages. Select any package in the list to navigate to the package details page. The following are the current NuGet packages relevant for [!INCLUDE [pn-crm-9-0-0-online](../../includes/pn-crm-9-0-0-online.md)].  


|Package|Description|
|---------|---------|
|[Microsoft.CrmSdk.CoreAssemblies](https://www.nuget.org/packages/Microsoft.CrmSdk.CoreAssemblies/)|Contains the Microsoft.Xrm.Sdk.dll and Microsoft.Crm.Sdk.Proxy.dll assemblies plus tools|
|[Microsoft.CrmSdk.CoreTools](https://www.nuget.org/packages/Microsoft.CrmSdk.CoreTools/)|Contains the SDK tools authored by the Microsoft Dynamics 365 team.|
|[Microsoft.CrmSdk.Deployment](https://www.nuget.org/packages/Microsoft.CrmSdk.Deployment/)|Contains the Microsoft.Xrm.Sdk.Deployment.dll assembly|
|[Microsoft.CrmSdk.Outlook](https://www.nuget.org/packages/Microsoft.CrmSdk.Outlook/)|Contains the Microsoft.Crm.Outlook.dll assembly|
|[Microsoft.CrmSdk.Samples.HelperCode-CS](https://www.nuget.org/packages/Microsoft.CrmSdk.Samples.HelperCode-CS/)|C# helper code authored by the Microsoft Dynamics 365 Customer Engagement Developer Documentation team. This code is for use against the Organization Service endpoint.|
|[Microsoft.CrmSdk.WebApi.Samples.HelperCode](https://www.nuget.org/packages/Microsoft.CrmSdk.WebApi.Samples.HelperCode/)|C# helper code authored by the Microsoft Dynamics 365  Customer Engagement Developer documentation team. This code is for use with the Web API. These classes provide web service authentication for both on-premises and online deployments, error handling, and connection string configuration. These classes are used in our Web API samples|
|[Microsoft.CrmSdk.Workflow](https://www.nuget.org/packages/Microsoft.CrmSdk.Workflow/)|Contains the Microsoft.Xrm.Sdk.Workflow.dll assembly|
|[Microsoft.CrmSdk.XrmTooling.CoreAssembly](https://www.nuget.org/packages/Microsoft.CrmSdk.XrmTooling.CoreAssembly/)|Contains the  Microsoft.Xrm.Tooling.Connector assembly |
|[Microsoft.CrmSdk.XrmTooling.CrmConnector.PowerShell](https://www.nuget.org/packages/Microsoft.CrmSdk.XrmTooling.CrmConnector.PowerShell/)|Contains the assemblies for Xrm.Tooling.Connector Powershell |
|[Microsoft.CrmSdk.XrmTooling.PackageDeployment.PowerShell](https://www.nuget.org/packages/Microsoft.CrmSdk.XrmTooling.PackageDeployment.PowerShell/)| Contains the assemblies for Package Deployer Powershell        |
|[Microsoft.CrmSdk.XrmTooling.PackageDeployment.Wpf](https://www.nuget.org/packages/Microsoft.CrmSdk.XrmTooling.PackageDeployment.Wpf/)|Contains the Dynamics 365 Package Deployer|
|[Microsoft.CrmSdk.XrmTooling.PackageDeployment](https://www.nuget.org/packages/Microsoft.CrmSdk.XrmTooling.PackageDeployment/)|Contains the Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase.dll assembly|
|[Microsoft.CrmSdk.XrmTooling.PluginRegistrationTool](https://www.nuget.org/packages/Microsoft.CrmSdk.XrmTooling.PluginRegistrationTool/)|Contains the Plugin Registration Tool required to manage Plugin assemblies,Workflow assemblies,Virtual Entitles, and Service endpoints for Microsoft Dynamics 365.|
|[Microsoft.CrmSdk.XrmTooling.WpfControls](https://www.nuget.org/packages/Microsoft.CrmSdk.XrmTooling.WpfControls/)|Contains the Microsoft.Xrm.Tooling.CrmConnectControl.dll, Microsoft.Xrm.Tooling.Ui.Styles.dll, and Microsoft.Xrm.Tooling.WebResourceUtility.dll assemblies|

  
### [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]
  
 On the package details page, select any package with a version number starting with 8.x. The package title indicates that the version of the package is for the [!INCLUDE[pn_crm_2016_shortest](../../includes/pn-crm-2016-shortest.md)] SDK. The package targets [!INCLUDE[pn_NET_Framework_452_short](../../includes/pn-net-framework-452-short.md)].  
  
### CRM 2015
  
 On the package details page, select any package with a version number starting with 7.x. The package title indicates that the version of the package is for the [!INCLUDE[pn_crm_2015_shortest](../../includes/pn-crm-2015-shortest.md)] SDK. The package targets [!INCLUDE[pn_NET_Framework_452_short](../../includes/pn-net-framework-452-short.md)].  
  
### CRM 2013
  
 On the package details page, select any package with a version number starting with 6.x. The package title indicates that the version of the package is for the [!INCLUDE[pn_crm_2013_shortest](../../includes/pn-crm-2013-shortest.md)] SDK. The package targets [!INCLUDE[pn_NET_Framework_4_short](../../includes/pn-net-framework-4-short.md)]. Beginning with package version 6.1.1, the package also targets [!INCLUDE[pn_NET_Framework_45_short](../../includes/pn-net-framework-45-short.md)].  
  
### CRM 2011
  
 On the package details page, select any package with a version number starting with 5.x. The package title indicates that the version of the package is for the [!INCLUDE[pn_crm_2011_shortest](../../includes/pn-crm-2011-shortest.md)] SDK. The package targets [!INCLUDE[pn_NET_Framework_4_short](../../includes/pn-net-framework-4-short.md)].  
  
## How to install a package in your project  
 For information about installing [!INCLUDE[tn_nuget](../../includes/tn-nuget.md)] packages into your project, see [Managing NuGet Packages Using the Dialog](http://docs.nuget.org/docs/start-here/managing-nuget-packages-using-the-dialog).  
  
### See also  
 [nuget DOCS](http://docs.nuget.org/)   
 [Installing NuGet](http://docs.nuget.org/docs/start-here/installing-nuget)   
 [Manage Project Libraries with NuGet](https://msdn.microsoft.com/magazine/hh547106.aspx)