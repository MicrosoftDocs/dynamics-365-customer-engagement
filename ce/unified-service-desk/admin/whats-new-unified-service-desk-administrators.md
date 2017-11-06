---
title: "What&#39;s new in Unified Service Desk for Dynamics 365 Customer Engagement for administrators | MicrosoftDocs"
description: "Learn about new features available with Unified Service Desk for Dynamics 365 Customer Engagement." 
ms.custom: ""
ms.date: 11/02/2017
ms.reviewer: ""
ms.service: "usd"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 57f18bf9-1e28-481b-9d78-f2adaf281e16
caps.latest.revision: 44
author: "Mattp123"
ms.author: "matp"
manager: "amyla"
---
# New feature information for administrators
This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for system administrators available in this version.  

<a name="NewIn310"></a>  
## What's new in Unified Service Desk 3.1

 Administrators will be able  to leverage the following enhancements and new capabilities in this release. 

### Support for the latest

Unified Service Desk 3.1 is compatible with the [!INCLUDE [pn-crm-9-0-0-online](../../includes/pn-crm-9-0-0-online.md)].

However, certain features in [!INCLUDE [pn-crm-9-0-0-online](../../includes/pn-crm-9-0-0-online.md)] are not fully supported in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. More information: [Unified Service Desk limitations with Dynamics 365 (online), version 9.0](#limitations)

### Security enhancements: User session and access management

When agents host one or more [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)] pages inside the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client using a hosted control of hosting type [IE Process](../select-a-hosting-method-for-your-controls.md#ie-process), an inactivity or session timeout warning may appear. These warnings are based on the configured inactivity and session timeouts in [!INCLUDE [pn-dyn-365-online](../../includes/pn-crm-online.md)] and agents are signed out after the expiry period. This behavior is similar with that of the [!INCLUDE [pn-dyn-365-online](../../includes/pn-crm-online.md)] web client and after the expiry period agents must sign in to the application again to resume working. System administrators can change the default warning and session timeout values from the System Settings page in [!INCLUDE [pn-dyn-365-online](../../includes/pn-crm-online.md)]. More information: [Security enhancements: User session and access management](../../admin/user-session-management.md)

The inactivity timeout setting does not apply to hosted controls of hosting type [Internal WPF](../select-a-hosting-method-for-your-controls.md#internal-wpf) and the agent will not be signed out due to inactivity. However, the session timeout is still applicable and there will be no warning displayed before automatic sign out occurs due to session expiry. We recommend that you use hosted controls of type IE Process if session timeout is desired. 

> [!NOTE]
> We recommend you keep the session timeout default of 24 hours to avoid frequent agent sign outs when hosted controls of type Internal WPF are used. 

### Security enhancements: TLS requirements

Unified Service Desk clients connecting to the [!INCLUDE [pn-crm-9-0-0-online](../../includes/pn-crm-9-0-0-online.md)] instances will require Transport Layer Security (TLS) 1.2. More information: [Updates coming to Dynamics 365 Customer Engagement connection security](https://blogs.msdn.microsoft.com/crm/2017/09/28/updates-coming-to-dynamics-365-customer-engagement-connection-security/)

<a name="limitations"></a>
### Unified Service Desk limitations with Dynamics 365 (online), version 9.0

These are the limitations:
- **Unified Interface**: Apps built using Unified Interface are not supported with [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. More information: [Unified Interface framework for new apps](/dynamics365/get-started/whats-new/customer-engagement/new-in-july-2017-update#unified-interface-framework-for-new-apps)
- **Interactive Service Hub**: With the [!INCLUDE [pn-crm-9-0-0-online](../../includes/pn-crm-9-0-0-online.md)] release, Interactive Service Hub has been rebuilt as a Unified Interface app, and is called Customer Service Hub. This implies that [support](../interactive-service-hub-page-hosted-control.md) for the Interactive Service Hub in Unified Service Desk is available only if you are running Dynamics 365, version 8.2 or an earlier supported version of Microsoft Dynamics CRM.
- **Relationship Insights**: Although you can view information from the relationship assistant in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client, you cannot interact with the information in the client. More information: [Relationship Insights](../../admin/relationship-insights.md)
- **LinkedIn Sales Navigator for Microsoft Dynamics 365 for Sales**:  This is not supported.
- **Multi-select option sets**: Although multi-select option sets display fine when hosted in Unified Service Desk (using [CRM Page](../crm-page-hosted-control.md) type of hosted control), you cannot change selections in multi-select option sets using the Unified Service Desk APIs.
-  **URL addressability in business apps**:  Business apps (app modules) use the appid value in the URLs to refer to resources displayed in an app. For example: “https://<OrgName>.crm.dynamics.com/main.aspx?appid=b0f40cd2-22a6-e711-a94e-000d3a1a7a9b&pagetype=entitylist&etn=bookableresourcebooking.” Unified Service Desk does not support the usage of appid values in URLs to refer to a resource. More information: [Design custom business apps by using the app designer](../../customize/design-custom-business-apps-using-app-designer.md)

  
<a name="NewIn222"></a>   
## What's new in Unified Service Desk 3.0  
 Administrators will be able  to leverage the following enhancements and new capabilities in this release.  
  
### Error  diagnostics reporting settings moved to Audit & Diagnostics Settings area  
 Previous versions maintained the error diagnostics reporting settings in the Options area of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] solution. With this release, to simplify configuration the error diagnostics reporting settings have been moved to the Audit & Diagnostics Settings area. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Diagnostics](../../unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk.md#BKMK_Diagnostics)  
  
### Support for JAWS screen reader  
 You can now use the JAWS (Job Access With Speech) version 18 for Windows screen reader application for speech output with the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Accessibility in Unified Service Desk](https://go.microsoft.com/fwlink/?linkid=826563)  
  
## See also  
 [What’s New in Unified Service Desk for developers](../../unified-service-desk/what-s-new-in-unified-service-desk.md)
 [Overview of Unified Service Desk](../../unified-service-desk/admin/overview-unified-service-desk.md)   
 [Install and Deploy Unified Service Desk](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)   
  
