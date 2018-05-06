---
title: "Create early bound entity classes with the code generation tool (CrmSvcUtil.exe) (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: ""
keywords: ""
ms.date: 12/15/2017
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 06abab26-40fc-4b85-9a2a-5e68903ea138
author: kabala123
ms.author: jdaly
manager: amyla
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm:
topic-status: Drafting
---

# Create early bound entity classes with the code generation tool (CrmSvcUtil.exe)

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

**CrmSvcUtil.exe** is a command-line code generation tool for use with [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. This tool generates early-bound [!INCLUDE[pn_NET_Framework](../../includes/pn-net-framework.md)] classes that represent the entity data model used by [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].

The code generation tool (CrmSvcUtil.exe) is distributed as part of the [Microsoft.CrmSdk.CoreTools](https://www.nuget.org/packages/Microsoft.CrmSdk.CoreTools) NuGet package. For information about downloading the code generation tool (CrmSvcUtil.exe), see [Download tools from NuGet](../download-tools-NuGet.md).

<a name="bkmk_about"></a>
## About the code generation tool

The **CrmSvcUtil.exe** tool creates a [!INCLUDE[pn_MS_Visual_C#](../../includes/pn-ms-visual-csharp.md)] or [!INCLUDE[pn_Visual_Basic](../../includes/pn-visual-basic.md)] output file that contains strongly-typed classes for entities in your organization. This includes custom entities and attributes. This output file contains one class for each entity, providing early binding and [!INCLUDE[pn_IntelliSense](../../includes/pn-intellisense.md)] support in [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)] to aid you as you write custom code. The generated classes are partial classes that can be extended with custom business logic in separate files. You can also create extensions to this tool. For more information, see [Create Extensions for the Code Generation Tool](extend-code-generation-tool.md).  

The tool can also be used to generate a class derived from the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext> class that acts as an entity container in the entity data model. This service context provides the facilities for tracking changes and managing identities, concurrency, and relationships. This class also exposes a <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext.SaveChanges> method that writes inserts, updates, and deletes records in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]. For more information, see [Use the Organization Service Context Class](use-the-organizationservicecontext-class.md).  

The code generation tool takes several parameters that determine the contents of the file that is created. The parameters can be passed in from the command line when you run the tool or in a .NET-connected application configuration file.  

The classes created by the code generation tool are designed to be built into a class library that can be referenced by projects that use [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]. After you have generated the class file using the tool, you should add the file to your [!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)] project. You must also add references to several assemblies that the generated classes are dependent upon.  

The following lists assemblies that must be referenced in your project when you use the generated code file.  

- Microsoft.Crm.Sdk.Proxy.dll  
- Microsoft.Xrm.Sdk.dll  

You can find these assemblies in the folder where you download the tools.
Folder path: `<Download_directory>\tools\CoreTools`.
For example, if you download the tools in devtools folder on your D drive, you can find the assemblies in `D:\devtools\Tools\CoreTools`.

<a name="bkmk_RuntheCodeGenerationUtility"></a>

## Run the code generation tool

Run the CrmSvcUtil.exe tool from the SDK\Bin folder. If you run the tool from another folder location, make sure that a copy of the Microsoft.Xrm.Sdk.dll assembly is in that same folder.  

The following sample shows the format for running the tool from the command line for an on-premises installation of [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]. You supply the parameter values for your installation.

```ms-dos
CrmSvcUtil.exe /url:http://<serverName>/<organizationName>/XRMServices/2011/Organization.svc    /out:<outputFilename>.cs /username:<username> /password:<password> /domain:<domainName>    /namespace:<outputNamespace> /serviceContextName:<serviceContextName>  
```

The following sample shows the format for running the tool from the command line with [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)]. You supply the parameter values appropriate for your account and server.  

```ms-dos
CrmSvcUtil.exe /url:https://<organizationUrlName>.api.crm.dynamics.com/XRMServices/2011/Organization.svc    /out:<outputFilename>.cs /username:<username> /password:<password>     /namespace:<outputNamespace> /serviceContextName:<serviceContextName>  
```

For the `username` parameter, type the user name that is used to sign in to [!INCLUDE[pn_Windows_Live_ID](../../includes/pn-windows-live-id.md)] or [!INCLUDE[pn_MS_Office_365](../../includes/pn-ms-office-365.md)]. You can look up the correct URL in the web application by selecting **Settings**, navigating to **Customizations**, and then choosing **Developer Resources**. The URL is shown under **Organization Service**.  

To list the supported command-line parameters, use the following command.

```ms-dos
CrmSvcUtil.exe /?  
```

> [!NOTE]
> When you run the tool against [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] using the [!INCLUDE[pn_Windows_Live_ID](../../includes/pn-windows-live-id.md)] identity provider, you no longer have to supply the `deviceid` and `devicepassword` parameters from the command line. The tool registers your device automatically.

<a name="bkmk_parameters"></a>

## Parameters

The following table lists the code generation tool parameters and a gives a brief description of their use.  
  
|Parameter|Shortcut|Description|Required|
|---------------|--------------|-----------------|--------------|
|deviceid|di|No longer needed|False|
|devicepassword|dp|No longer needed|False|
|domain|d|The domain to authenticate against when you connect to the server.|False|
|url||The URL for the Organization service.|True|
|out|o|The file name for the generated code.|True|
|language|l|The language to generate the code in. This can be either “CS” or “VB”. The default value is “CS”.|False|
|namespace|n|The namespace for the generated code. The default is the global namespace.|False|  
|username|u|The user name to use when you connect to the server for authentication.|False|  
|password|p|The password to use when you connect to the server for authentication.|False|  
|servicecontextname||The name of the generated organization service context class. If no value is supplied, no service context is created.|False|
|help|?|Show usage information.|False|
|nologo||Suppress the banner at runtime.|False|
|generateActions||Generate request and response classes for actions.||
|interactivelogin|il|When set to **true**, a dialog to log into the Dynamics 365 service is displayed. All other connection related parameters specified on the command line are   ignored.|False|  
|connectionstring|connstr|Contains information, provided as a single string, for connecting to a Dynamics 365 organization. All other connection related parameters specified on the command line are ignored. For more information see [Use connection strings in XRM tooling to connect to Dynamics 365](../xrm-tooling/use-connection-strings-xrm-tooling-connect.md).|False|

<a name="bkmk_examples"></a>

## Usage examples

The following examples show how to use of the code generation tool from the command line for each deployment type. Note that user name and password are optional parameters. If your credentials for the target [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] server are stored in the [!INCLUDE[pn_ms_Windows_short](../../includes/pn-ms-windows-short.md)] credential vault, you do not have to provide them to run the code generation tool.

### Claims authentication – Active Directory

The following sample shows how to run the code generation tool by using claims authentication in [!INCLUDE[pn_Active_Directory](../../includes/pn-active-directory.md)]. Note the use of https because this sample server is using Transport Layer Security (TLS) or Secure Sockets Layer (SSL).  

```ms-dos  
CrmSvcUtil.exe /url:https://myport:555/MyOrg/XRMServices/2011/Organization.svc /out:GeneratedCode.cs /username:administrator /password:password
```

### Dynamics 365 (online)

The following sample shows how to run the code generation tool for [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)]. The first example is for the [!INCLUDE[pn_Windows_Live_ID](../../includes/pn-windows-live-id.md)] identity provider and the second is for the [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] identity provider.

```ms-dos
CrmSvcUtil.exe /url:https://myorg.api.crm.dynamics.com/XRMServices/2011/Organization.svc /out:GeneratedCode.cs /username:"myname@live.com" /password:"myp@ssword!"   
```

```ms-dos
CrmSvcUtil.exe /url:https://myorg.api.crm.dynamics.com/XRMServices/2011/Organization.svc /out:GeneratedCode.cs /username:"myname@myorg.onmicrosoft.com" /password:"myp@ssword!"   
```

### Claims authentication - IFD

The following sample shows how to run the code generation tool using claims authentication.  

```ms-dos
CrmSvcUtil.exe /url:https://myorg.crm.com:555/XRMServices/2011/Organization.svc /out:GeneratedCode.cs /username:administrator /password:p@ssword!
```

<a name="bkmk_sampleconfig"></a>

## Use the configuration File

The CrmSvcUtil.exe.config configuration file must be in the same folder as the CrmSvcUtil.exe tool. The configuration file uses the standard key/value pairs in the `appSettings` section. However, if you enter a value at the command line, that value will be used instead of the one in the configuration file. Any key/value pairs found in the application configuration file that do not match any of the expected parameters are ignored.  

Do not include the `url` and `namespace` parameters in the configuration file. These must be entered from the command line when the CrmSvcUtil.exe tool is being run.  

The following sample shows how to configure the output file and the domain name parameters in the application configuration file using shortcut keys.  

```xml
<appSettings>    
    <add key="o" value="CrmProxy.cs"/>    
    <add key="d" value="mydomain"/>
</appSettings>  
```

<a name="bkmk_enabletrace"></a>

## Enable tracing
 To enable tracing when you run the tool, add the following lines to the configuration file:  

```xml
<system.diagnostics>   
   <trace autoflush="false" indentsize="4">   
      <listeners>   
         <add name="configConsoleListener" type="System.Diagnostics.ConsoleTraceListener">   
            <filter type="System.Diagnostics.EventTypeFilter" initializeData="Error" />   
         </add>   
      </listeners>   
   </trace>   
</system.diagnostics>  
```

For more information on supported tracing options see [Configure tracing for XRM tooling](../xrm-tooling/configure-tracing-xrm-tooling.md).  

## Community tools

**Early Bound Generator** is a tool that XrmToolbox community developed for [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement. Please see the [Developer tools](../developer-tools.md) topic for community developed tools.

> [!NOTE]
> The community tools are not a product of [!include[pn_microsoft_dynamics](../../includes/pn-microsoft-dynamics.md)] and does not extend support to the community tools. 
> If you have questions pertaining to the tool, please contact the publisher. More Information: [XrmToolBox](https://www.xrmtoolbox.com). 


### See Also

 [Developer Tools for Dynamics 365](../developer-tools.md)<br />
 [Browse the Metadata for Your Organization](../browse-your-metadata.md)<br />
 [Create an Extensions for the Code Generation Tool](extend-code-generation-tool.md)<br />
 [Use the Early Bound Entity Classes for Create, Update and Delete](use-entity-class-create-update-delete.md)<br />
 [Troubleshooting Tips](troubleshooting-tips.md)<br />
 [Run a simple program using Customer Engagement web services](../simple-program-web-services.md)<br />
