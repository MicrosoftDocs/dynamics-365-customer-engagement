---
title: "Visual Studio and the .NET Framework (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Learn about managed code development tools and requirements."
ms.date: 08/10/2026
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
  - Dynamics 365 Customer Engagement (on-premises)
  - Dynamics CRM 2016
  - Dynamics CRM Online
author: JimDaly
ms.author: jdaly
ms.reviewer: pehecke
search.audienceType: 
  - developer

---

# Visual Studio and the .NET platform

[!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] For code development, the available SDK for .NET assemblies supports targeting .NET Framework or .NET Core. This article describes the supported code development and target frameworks. 

## Client and service development using .NET Framework

Build custom client applications or services by using [!INCLUDE [pn-net-framework-462-long](../includes/pn-net-framework-462-long.md)] (or newer version).

Starting with the [!INCLUDE [pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)], only applications that use Transport Layer Security (TLS) 1.2 or better security can connect. Enforcement of this higher standard for security currently applies only to [!INCLUDE [pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)]. If your clients are designed to connect to any version or deployment type, prepare by recompiling the application to use a supported development platform.

For a list of compatible target frameworks, see the **Frameworks** tab of the SDK NuGet package named [Microsoft.CrmSdk.CoreAssemblies](https://www.nuget.org/packages/Microsoft.CrmSdk.CoreAssemblies).

More information: [Blog Post: Updates coming to Dynamics 365 Customer Engagement (on-premises) connection security](https://blogs.msdn.microsoft.com/crm/2017/09/28/updates-coming-to-dynamics-365-customer-engagement-connection-security/)

### Client and service development using .NET Core

The SDK APIs available in [Microsoft.CrmSdk.CoreAssembly](https://www.nuget.org/packages/Microsoft.CrmSdk.XrmTooling.CoreAssembly/) and other "Microsoft.CrmSdk" NuGet packages don't support .NET Core code development. However, code development for a .NET Framework or .NET Core build target is available when using the [Microsoft.PowerPlatform.Dataverse.Client](https://www.nuget.org/packages/Microsoft.PowerPlatform.Dataverse.Client) NuGet package, which contains the same namespaces as Microsoft.CrmSdk.CoreAssembly.

For a list of compatible target frameworks, see the **Frameworks** tab of the SDK NuGet package named [Microsoft.PowerPlatform.Dataverse.Client](https://www.nuget.org/packages/Microsoft.PowerPlatform.Dataverse.Client).

> [!TIP]
> When you install the .NET platform on your development computer, be sure to install the developer pack or SDK and not just the runtime. When you install the developer pack or SDK, you can choose the .NET platform in the **New Project** dialog box of [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)] and in the target drop-down menu of the project’s properties.

## Plug-in and custom workflow activity development

To extend the run-time capabilities of [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)], build event handlers called plug-ins and custom workflow activities that target .NET Framework 4.6.2 through 4.8.

> [!IMPORTANT]
> Sandbox support is now available for plug-ins and custom workflow activities that target .NET Framework 4.8. Existing projects that target .NET Framework 4.6.2 continue to be supported. However, update your existing code to target 4.8 for improved security and other new features.

More information: [Write plug-ins to extend business processes](write-plugin-extend-business-processes.md)

## See Also

[Support for .NET Framework versions](../developer/supported-extensions.md#SupportNET)<br/>
[Supported Extensions for Dynamics 365 Customer Engagement (on-premises)](../developer/supported-extensions.md)</br/>
[Developer Tools](../developer/developer-tools.md)

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
