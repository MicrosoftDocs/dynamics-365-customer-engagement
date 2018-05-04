---
title: "Sample: Simplified connection quick start (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "This sample shows you how to connect to the Dynamics 365 (online) Customer Engagement web services using the CrmServiceClient and perform basic create, update, retrieve, and delete operations on an entity. "
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a4fb3634-948e-4bac-a32f-f626c78d83a0
caps.latest.revision: 29
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Sample: Simplified connection quick start using Dynamics 365 Customer Engagement

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample shows you how to connect to the [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement web services using the <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient> and perform basic create, update, retrieve, and delete operations on an entity. For more information about the <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient>, see [Use CrmServiceClient constructors to connect to Dynamics 365](use-crmserviceclient-constructors-connect.md).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]

## Requirements

The complete sample code can be found here [Sample: Quick start for Microsoft Dynamics 365](https://code.msdn.microsoft.com/Sample-Quick-start-for-650dbcaa) 

<!--[!INCLUDE[sdk_download](../../includes/sdk-download.md)]-->

You must modify the supplied app.config file with connection information for your [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] server before running the sample. For more information, see the commented out example connection strings in the app.config file.  

## Demonstrates

This sample authenticates the user with the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] web services by using the <xref:Microsoft.Xrm.Tooling.Connector.CrmServiceClient> and methods. After obtaining a reference to the Organization web service, the sample performs basic create, update, retrieve, and delete operations on an account entity. The sample also handles common exceptions. No helper code is used to establish a connection to the Organization web service.  

In addition, this sample supports OAuth authentication and advanced connection diagnostics. For more information on using diagnostics, see [Configure tracing for XRM Tooling](configure-tracing-xrm-tooling.md).

## Example

The following shows a sample app.config file. To use this, remove the comment characters “<!- -” at the beginning of the \<add … /> line and the “- ->” at the end on the line for the line that is relevant to your server and organization. Next, modify the attribute values as appropriate for your configuration.

```xml
<?xml version="1.0" encoding="utf-8"?>  
<configuration>  
  <connectionStrings>  
    <!-- Online using Office 365 -->  
    <!-- <add name="Server=CRM Online, organization=contoso, user=someone"  
         connectionString="Url=https://contoso.crm.dynamics.com; Username=someone@contoso.onmicrosoft.com; Password=password; authtype=Office365"/> -->  
  
    <!-- On-premises with provided user credentials -->  
    <!-- <add name="Server=myserver, organization=AdventureWorksCycle, user=administrator"  
         connectionString="Url=http://myserver/AdventureWorksCycle; Domain=mydomain; Username=administrator; Password=password; authtype=AD"/> -->  
  
    <!-- On-premises using Windows integrated security -->  
    <!-- <add name="Server=myserver, organization=AdventureWorksCycle"  
         connectionString="Url=http://myserver/AdventureWorksCycle; authtype=AD"/> -->  
  
    <!-- On-Premises (IFD) with claims -->  
    <!--<add name="Server=litware.com, organization=contoso, user=someone@litware.com"  
         connectionString="Url=https://contoso.litware.com/contoso; Username=someone@litware.com; Password=password; authtype=IFD"/>-->  
  </connectionStrings>  
  <startup>  
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5.2" />  
  </startup>  
<system.diagnostics>  
    <trace autoflush="true"/>  
    <sources>  
      <source name="Microsoft.Xrm.Tooling.Connector.CrmServiceClient" switchName="Microsoft.Xrm.Tooling.Connector.CrmServiceClient" switchType="System.Diagnostics.SourceSwitch">  
        <listeners>  
          <add name="console" type="System.Diagnostics.ConsoleTraceListener"/>  
          <add name="fileListener"/>  
        </listeners>  
      </source>  
      <source name="Microsoft.Xrm.Tooling.CrmConnectControl" switchName="Microsoft.Xrm.Tooling.CrmConnectControl" switchType="System.Diagnostics.SourceSwitch">  
        <listeners>  
          <add name="console" type="System.Diagnostics.ConsoleTraceListener"/>  
          <add name="fileListener"/>  
        </listeners>  
      </source>  
      <source name="CrmSvcUtil" switchName="CrmSvcUtil" switchType="System.Diagnostics.SourceSwitch">  
        <listeners>  
          <add name="console" type="System.Diagnostics.ConsoleTraceListener"/>  
          <add name="fileListener"/>  
        </listeners>  
      </source>  
    </sources>  
    <switches>  
  
      <!--Possible values for switches: Off, Error, Warning, Information, Verbose  
						Verbose:      includes Error, Warning, Info, Trace levels  
						Information:  includes Error, Warning, Info levels  
						Warning:      includes Error, Warning levels  
						Error:        includes Error level-->  
  
      <add name="Microsoft.Xrm.Tooling.CrmConnectControl" value="Off"/>  
      <add name="Microsoft.Xrm.Tooling.Connector.CrmServiceClient" value="Error"/>  
      <add name="CrmSvcUtil" value="Off"/>  
    </switches>  
  
    <sharedListeners>  
      <add name="fileListener" type="System.Diagnostics.TextWriterTraceListener" initializeData="CrmSvcUtil.log"/>  
    </sharedListeners>  
  
  </system.diagnostics>  
  <runtime>  
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">  
      <dependentAssembly>  
        <assemblyIdentity name="Microsoft.Xrm.Sdk" publicKeyToken="31bf3856ad364e35" culture="neutral" />  
        <bindingRedirect oldVersion="0.0.0.0-7.0.0.0" newVersion="8.0.0.0" />  
      </dependentAssembly>  
      <dependentAssembly>  
        <assemblyIdentity name="Microsoft.Xrm.Sdk.Deployment" publicKeyToken="31bf3856ad364e35" culture="neutral" />  
        <bindingRedirect oldVersion="0.0.0.0-7.0.0.0" newVersion="8.0.0.0" />  
      </dependentAssembly>  
      <dependentAssembly>  
        <assemblyIdentity name="Microsoft.ServiceBus" publicKeyToken="31bf3856ad364e35" culture="neutral" />  
        <bindingRedirect oldVersion="0.0.0.0-2.4.0.0" newVersion="2.4.0.0" />  
      </dependentAssembly>  
    </assemblyBinding>  
  </runtime>  
</configuration>  
  
```

## Example

<!-- [!code-csharp[QuickStartCS#SimplifiedConnection](../../snippets/csharp/CRMV8/quickstartcs/cs/simplifiedconnection.cs#simplifiedconnection)]   -->

### See also
[Use connection strings in XRM tooling to connect to Dynamics 365](use-connection-strings-xrm-tooling-connect.md)<br />
[Tutorials for Learning About Dynamics 365 Development](../tutorials-resources-sdk.md)<br />
[Run a Simple Program Using Dynamics 365 Web Services](../simple-program-web-services.md)<br />
[Sample: Quick Start for Dynamics 365](../sample-quick-start.md)<br />
[Sample: Quick start for XRM Tooling API](sample-quick-start-xrm-tooling-api.md)<br />
