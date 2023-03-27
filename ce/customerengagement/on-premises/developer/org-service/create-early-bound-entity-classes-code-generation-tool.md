---
title: "Create early-bound entity classes with the Code Generation tool (CrmSvcUtil.exe) (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: Learn how to create early bound entity classes with the code generation tool, CrmSvcUtil.exe, for Dynamics 365 Customer Engagement (on-premises).
keywords: 
ms.date: 02/14/2023
ms.custom: on-premise
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
author: JimDaly
ms.author: jdaly
manager: KumarVivek
ms.reviewer: pehecke
search.audienceType: 
  - developer
---

# Create early-bound entity classes with the Code Generation tool

**CrmSvcUtil.exe** is a command-line code generation tool for use with [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. This tool generates early-bound [!INCLUDE[pn_NET_Framework](../../includes/pn-net-framework.md)] classes that represent the entity data model used by [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].

The code generation tool (CrmSvcUtil.exe) is distributed as part of the [Microsoft.CrmSdk.CoreTools](https://www.nuget.org/packages/Microsoft.CrmSdk.CoreTools) NuGet package. For information about downloading the code generation tool (CrmSvcUtil.exe), see [Dataverse development tools](/power-apps/developer/data-platform/download-tools-nuget).

For documentation on the tool see [Generate early-bound classes for the Organization service](/power-apps/developer/data-platform/org-service/generate-early-bound-classes).

What follows below is additional information on running the tool that apply only to on-premises deployments.

## Usage examples

The following examples show how to use of the code generation tool from the command line. Note that user name and password are optional parameters. If your credentials for the target [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] server are stored in the [!INCLUDE[pn_ms_Windows_short](../../includes/pn-ms-windows-short.md)] credential vault, you do not have to provide them to run the code generation tool.

### Claims authentication – Active Directory

The following sample shows how to run the code generation tool by using claims authentication in [!INCLUDE[pn_Active_Directory](../../includes/pn-active-directory.md)]. Note the use of https because this sample server is using Transport Layer Security (TLS) or Secure Sockets Layer (SSL).  

```ms-dos  
CrmSvcUtil.exe /url:https://myport:555/MyOrg/XRMServices/2011/Organization.svc /out:GeneratedCode.cs /username:administrator /password:mypassword
```

### Claims authentication - IFD

The following sample shows how to run the code generation tool using claims authentication.  

```ms-dos
CrmSvcUtil.exe /url:https://myorg.crm.com:555/XRMServices/2011/Organization.svc /out:GeneratedCode.cs /username:administrator /password:mypassword
```

### See Also

 [Developer Tools for Dynamics 365 Customer Engagement (on-premises)](../developer-tools.md)  
 [Create an extension for the Code Generation tool](/powerapps/developer/data-platform/org-service/extend-code-generation-tool)  
 [Late-bound and early-bound programming](/powerapps/developer/common-data-service/org-service/early-bound-programming)

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]