---
title: "Visual Studio and the .NET Framework (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Learn about managed code development tools and requirements."
keywords: 
ms.date: 05/29/2020
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
  - Dynamics 365 Customer Engagement (on-premises)
  - Dynamics CRM 2016
  - Dynamics CRM Online
ms.assetid: b2d572f9-6114-4694-a2d1-127cff861a96
author: JimDaly
ms.author: kvivek
manager: kvivek
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 20

search.audienceType: 
  - developer

---

# Visual Studio and the .NET Framework

The .NET SDK assemblies for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] are built on .NET Framework version 4.6.2. 

You can use [!INCLUDE[pn-visual-studio-short](../includes/pn-visual-studio-short.md)] to build your managed code applications using .NET Framework version 4.6.2 or later. 

> [!IMPORTANT]
> You should build any custom client applications using [!INCLUDE [pn-net-framework-462-long](../includes/pn-net-framework-462-long.md)] or later.
> Starting with the [!INCLUDE [pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)], only applications using Transport Level Security (TLS) 1.2 or better security will be allowed to connect. TLS 1.2 is not the default protocol used by [!INCLUDE [pn-net-framework-452-short](../includes/pn-net-framework-452-short.md)], but it is in  [!INCLUDE [pn-net-framework-462-short](../includes/pn-net-framework-462-short.md)].
> 
> Enforcement of this higher standard for security will only be applied to [!INCLUDE [pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)] at this time. If your clients are designed to connect to any version or deployment type you can prepare by re-compling the application to use [!INCLUDE [pn-net-framework-462-short](../includes/pn-net-framework-462-short.md)].
> More information: [Blog Post: Updates coming to Dynamics 365 Customer Engagement (on-premises) connection security](https://blogs.msdn.microsoft.com/crm/2017/09/28/updates-coming-to-dynamics-365-customer-engagement-connection-security/)
> 
> The SDK APIs available in [Microsoft.CrmSdk.XrmTooling.CoreAssembly](https://www.nuget.org/packages/Microsoft.CrmSdk.XrmTooling.CoreAssembly/) and other "CrmSdk" NuGet packages do not support .NET Core code development.
>
> [!TIP]
> When installing [!INCLUDE[pn-net-framework-462-short.md](../includes/pn-net-framework-462-short.md)] on your development computer, be sure to install the developer pack and not just the run-time. This will enable the 4.6.2 framework to be chosen in the **New Project** dialog box of [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)] and in the target framework drop-down menu of the project’s properties.  

You can use a [!INCLUDE[pn_MS_VS_Community](../includes/pn-vs-community.md)] edition for development. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Support for .NET Framework versions](../developer/supported-extensions.md#SupportNET)


For a complete statement of supported and unsupported development, see [Supported Extensions for Dynamics 365 Customer Engagement (on-premises)](../developer/supported-extensions.md).

## See Also

 [Developer Tools](../developer/developer-tools.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]