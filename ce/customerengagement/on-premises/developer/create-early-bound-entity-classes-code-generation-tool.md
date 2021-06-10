---
title: "Create early bound entity classes with the code generation tool (CrmSvcUtil.exe) (Developer Guide for Dynamics 365 Customer Engagement (on-premises) )| MicrosoftDocs"
description: ""
keywords: 
ms.date: 09/05/2019
ms.prod: dynamicscrm-2016 
ms.custom: on-premise
ms.topic: article
ms.assetid: 06abab26-40fc-4b85-9a2a-5e68903ea138
author: JimDaly
ms.author: jdaly
ms.reviewer: pehecke
search.audienceType: 
  - developer

---

# Create early bound entity classes with the code generation tool (CrmSvcUtil.exe)

**CrmSvcUtil.exe** is a command-line code generation tool for use Dynamics 365 Customer Engagement (on-premises). This tool generates early-bound [!INCLUDE[pn_NET_Framework](../includes/pn-net-framework.md)] classes that represent the entity data model used by Dynamics 365 Customer Engagement (on-premises).

The code generation tool (CrmSvcUtil.exe) is distributed as part of the [Microsoft.CrmSdk.CoreTools](https://www.nuget.org/packages/Microsoft.CrmSdk.CoreTools) NuGet package. For information about downloading the code generation tool (CrmSvcUtil.exe), see [Download tools from NuGet](download-tools-NuGet.md).

<a name="bkmk_about"></a>
## About the code generation tool

The **CrmSvcUtil.exe** tool creates a [!INCLUDE[pn_MS_Visual_C#](../includes/pn-ms-visual-csharp.md)] or [!INCLUDE[pn_Visual_Basic](../includes/pn-visual-basic.md)] output file that contains strongly-typed classes for entities in your organization. This includes custom entities and attributes. This output file contains one class for each entity, providing early binding and [!INCLUDE[pn_IntelliSense](../includes/pn-intellisense.md)] support in [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] to aid you as you write custom code. The generated classes are partial classes that can be extended with custom business logic in separate files. You can also create extensions to this tool. For more information, see [Create extensions for the code generation tool](/powerapps/developer/common-data-service/org-service/extend-code-generation-tool) in the Dataverse documentation.  

The tool can also be used to generate a class derived from the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext> class that acts as an entity container in the entity data model. This service context provides the facilities for tracking changes and managing identities, concurrency, and relationships. This class also exposes a <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceContext.SaveChanges> method that writes inserts, updates, and deletes records in Dynamics 365 Customer Engagement (on-premises). For more information, see [Use OrganizatioServiceContext](/powerapps/developer/common-data-service/org-service/organizationservicecontext) in the Dataverse documentation.  

The code generation tool takes several parameters that determine the contents of the file that is created. The parameters can be passed in from the command line when you run the tool or in a .NET-connected application configuration file.  

The classes created by the code generation tool are designed to be built into a class library that can be referenced by projects that use Dynamics 365 Customer Engagement (on-premises). After you have generated the class file using the tool, you should add the file to your [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)] project. You must also add references to several assemblies that the generated classes are dependent upon.  

The following lists assemblies that must be referenced in your project when you use the generated code file.  

- Microsoft.Crm.Sdk.Proxy.dll  
- Microsoft.Xrm.Sdk.dll  

You can find these assemblies in the folder where you download the tools.
Folder path: `<Download_directory>\tools\CoreTools`.
For example, if you download the tools in devtools folder on your D drive, you can find the assemblies in `D:\devtools\Tools\CoreTools`.

More information about using the tool see the Dataverse topic [Generate early-bound classes for the Organization service](/powerapps/developer/common-data-service/org-service/generate-early-bound-classes).

<a name="bkmk_RuntheCodeGenerationUtility"></a>

## Run the code generation tool

Run the CrmSvcUtil.exe tool from the SDK\Bin folder. If you run the tool from another folder location, make sure that a copy of the Microsoft.Xrm.Sdk.dll assembly is in that same folder.  

The following sample shows the format for running the tool from the command line for an installation of Dynamics 365 Customer Engagement (on-premises). You supply the parameter values for your installation.

```ms-dos
CrmSvcUtil.exe /url:https://<serverName>/<organizationName>/XRMServices/2011/Organization.svc    /out:<outputFilename>.cs /username:<username> /password:<password> /domain:<domainName>    /namespace:<outputNamespace> /serviceContextName:<serviceContextName>  
```

You can look up the correct URL in the web application by selecting **Settings**, navigating to **Customizations**, and then choosing **Developer Resources**. The URL is shown under **Organization Service**.  

To list the supported command-line parameters, use the following command.

```ms-dos
CrmSvcUtil.exe /?  
```

<a name="bkmk_examples"></a>

## Usage examples

The following examples show how to use of the code generation tool from the command line. Note that user name and password are optional parameters. If your credentials for the target Dynamics 365 Server are stored in the [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] credential vault, you do not have to provide them to run the code generation tool.

### Claims authentication – Active Directory

The following sample shows how to run the code generation tool by using claims authentication in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]. Note the use of https because this sample server is using Transport Layer Security (TLS) or Secure Sockets Layer (SSL).  

```ms-dos  
CrmSvcUtil.exe /url:https://myport:555/MyOrg/XRMServices/2011/Organization.svc /out:GeneratedCode.cs /username:administrator /password:password
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

### See Also

 [Developer Tools for Dynamics 365 Customer Engagement (on-premises)](developer-tools.md)<br />
 [Browse the Metadata for Your Organization](browse-your-metadata.md)<br />
 [Create extensions for the code generation tool](/powerapps/developer/common-data-service/org-service/extend-code-generation-tool)<br />
 [Late-bound and Early-bound programming using the Organization service](/powerapps/developer/common-data-service/org-service/early-bound-programming)<br />
 [Run a simple program using Customer Engagement web services](simple-program-web-services.md)<br />


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]