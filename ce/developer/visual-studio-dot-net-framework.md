---
title: "Visual Studio and the .NET Framework (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Learn about managed code development tools and requirements."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2016"
  - "Dynamics CRM Online"
ms.assetid: b2d572f9-6114-4694-a2d1-127cff861a96
caps.latest.revision: 20
ms.author: "phecke"
manager: "jdaly"
---
# Visual Studio and the .NET Framework

The [!INCLUDE[pn_sdk](../includes/pn-sdk.md)] for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] is built on [!INCLUDE[pn_NET_Framework_452_short](../includes/pn-net-framework-452-short.md)]. You can use [!INCLUDE[pn-visual-studio-short](../includes/pn-visual-studio-short.md)] to build your managed code applications using [!INCLUDE[pn_NET_Framework_452_short](../includes/pn-net-framework-452-short.md)] or later. You can use a [!INCLUDE[pn_MS_VS_Express](../includes/pn-ms-vs-express.md)] edition for development, however, use of extensions isn’t supported in the Express edition so you won’t be able to install the Developer Toolkit in that version of [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)]. Use of the Developer Toolkit is recommended, but not required. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Support for .NET Framework versions](../developer/supported-extensions.md#SupportNET)

> [!TIP]
> When installing [!INCLUDE[pn_NET_Framework_452_short](../includes/pn-net-framework-452-short.md)] on your development computer, be sure to install the developer pack and not just the run-time. This will enable the 4.5.2 framework to be chosen in the **New Project** dialog box of [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)] and in the target framework drop-down menu of the project’s properties.  

There is a known breaking change in the [!INCLUDE[pn_Windows_Identity_Framework_(WIF)](../includes/pn-windows-identity-framework-wif.md)] namespace used by [!INCLUDE[pn_sdk](../includes/pn-sdk.md)] based applications. Existing applications built using the CRM 2013 SDK may need code changes to build against the CRM 2015 SDK. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Guidelines for Migrating an Application Built Using WIF 3.5 to WIF 4.5](https://msdn.microsoft.com/library/jj157089.aspx)  

For a complete statement of supported and unsupported development, see [Supported Extensions for Dynamics 365](../developer/supported-extensions.md).

## See Also

 [Developer Tools](../developer/developer-tools.md)