---
title: "Visual Studio and the .NET Framework (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Learn about managed code development tools and requirements."
ms.date: 09/05/2025
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

# Visual Studio and the .NET Framework

[!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] code development using the provided SDK for .NET assemblies target .NET Framework. You can use [!INCLUDE[pn-visual-studio-short](../includes/pn-visual-studio-short.md)] to build your managed code applications using .NET Framework version 4.6.2 (or newer versions). For a list of compatible target frameworks, see the **Frameworks** tab of the SDK NuGet package named [Microsoft.CrmSdk.CoreAssemblies](https://www.nuget.org/packages/Microsoft.CrmSdk.CoreAssemblies).

## Client app and service development

You should build any custom client applications using [!INCLUDE [pn-net-framework-462-long](../includes/pn-net-framework-462-long.md)] or newer compatible versions.
Starting with the [!INCLUDE [pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)], only applications using Transport Level Security (TLS) 1.2 or better securrity are permitted to connect. TLS 1.2 isn't the default protocol used by [!INCLUDE [pn-net-framework-452-short](../includes/pn-net-framework-452-short.md)], but it is in  [!INCLUDE [pn-net-framework-462-short](../includes/pn-net-framework-462-short.md)].

Enforcement of this higher standard for security is only applied to [!INCLUDE [pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)] at this time. If your clients are designed to connect to any version or deployment type, you can prepare by recompling the application to use [!INCLUDE [pn-net-framework-462-short](../includes/pn-net-framework-462-short.md)].
More information: [Blog Post: Updates coming to Dynamics 365 Customer Engagement (on-premises) connection security](https://blogs.msdn.microsoft.com/crm/2017/09/28/updates-coming-to-dynamics-365-customer-engagement-connection-security/)

### .NET Core

The SDK APIs available in [Microsoft.CrmSdk.CoreAssembly](https://www.nuget.org/packages/Microsoft.CrmSdk.XrmTooling.CoreAssembly/) and other "Microsoft.CrmSdk" NuGet packages don't support .NET Core code development. However, code development for a .NET Framework or .NET Core build target is available when using the [Microsoft.PowerPlatform.Dataverse.Client](https://www.nuget.org/packages/Microsoft.PowerPlatform.Dataverse.Client) NuGet package, which contains the same namespaces as Microsoft.CrmSdk.CoreAssembly.

> [!TIP]
> When installing a framework on your development computer, be sure to install the developer pack and not just the run-time. Installing the developer pack enables the framework to be chosen in the **New Project** dialog box of [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)] and in the target framework drop-down menu of the project’s properties.

## Plug-in and custom workflow activity development

Event handlers called *plug-ins* and custom workflow activities, used to extend the run-time capabilities of [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)], must only be built to target .NET Framework 4.6.2.

> [!NOTE]
> Official Microsoft [support](/lifecycle/products/microsoft-net-framework) for .NET Framework 4.6.2 ends on January 12, 2027. We intend to introduce Dataverse plug-in support for the .NET Framework 4.8 runtime by June 2026.

More information: [Write plug-ins to extend business processes](write-plugin-extend-business-processes.md)

## See Also

[Support for .NET Framework versions](../developer/supported-extensions.md#SupportNET)<br/>
[Supported Extensions for Dynamics 365 Customer Engagement (on-premises)](../developer/supported-extensions.md)</br/>
[Developer Tools](../developer/developer-tools.md)

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
