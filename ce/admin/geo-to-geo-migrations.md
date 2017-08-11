---
title: "Geo to geo migrations for Dynamics 365 (online) | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: c5b836a1-8f9d-42bd-8c11-cb81c68b97d3
caps.latest.revision: 17
author: "jimholtz"
ms.author: "jimholtz"
manager: "jackiesm"
---
# Geo to geo migrations
We continue to open new datacenter regions for [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] for business services, and to add datacenters to existing regions.  
  
 The Geo Migration feature for [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] will allow customers to move their instances in a single tenant from one region to another. There are no user-interface changes or version changes as part of this move. In the case of a [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instance residing in an [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] instance in a single tenant, moving the [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instance doesn’t move the [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] instance; they are separate services. Your [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instance will still appear in your tenant alongside the [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] instance.  
  
> [!IMPORTANT]
>  You can now move individual [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instances from one geographical region to another. When you do so, your tenant becomes a multiregional tenant. Regional features are enabled in the [!INCLUDE[pn_dyn_365_admin_center](../includes/pn-dyn-365-admin-center.md)].  
>   
>  To request a regional migration, please contact your account manager or  see [Technical Support](https://www.microsoft.com/en-US/dynamics/crm-customer-center/contact-technical-support.aspx).  
  
## Impact of migrating  
 Moving an instance to a different region changes your tenant to be multiregional - enabling regional features in the [!INCLUDE[pn_dyn_365_admin_center](../includes/pn-dyn-365-admin-center.md)].  
  
 The other significant change is to your organization URL. Each of the [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] regional datacenters has a unique identifier in the URL. When your organization is moved from one regional datacenter to another this identifier will change. For example:  
  
-   South America (LATAM/SAM) = .crm2.dynamics.com  
  
-   Canada (CAN) = .crm3.dynamics.com  
  
-   Europe, Middle East, Africa (EMEA) = .crm4.dynamics.com  
  
-   Asia Pacific (APAC) = *.crm5.dynamics.com  
  
-   Australia (OCE) = *.crm6.dynamics.com  
  
-   Japan (JPN) = *.crm7.dynamics.com  
  
-   India (IND) = *.crm8.dynamics.com  
  
-   United Kingdom (UK) = *.crm11.dynamics.com  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Direct sign in to Dynamics 365 (online)](sign-in-office-365-apps.md#BKMK_directsignin) and [Discover the URL for your organization using the Organization Service](http://msdn.microsoft.com/en-us/29b0777c-f28d-4301-ae5c-a25064bfbcc9)  
  
 For example, if your existing organization URL is https://myorg.crm**5**.dynamics.com and you request it to be moved to Australia, the new organization URL will be https://myorg.crm**6**.dynamics.com.  
  
 You’ll need to update any direct references to your [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] organization URL.  
  
> [!NOTE]
>  Organization URLs must be unique. If your organization name has already been reserved in the destination datacenter, it won’t be available. In the unlikely event this happens, we will work with you to decide how to proceed.  
  
 To see the datacenter regions, go to [Where is my data?](http://o365datacentermap.azurewebsites.net/) and then click **Select Your Region**.  
  
 The following topics have information that could be helpful to understand the move process:  
  
-   [New datacenter regions for Dynamics 365 (online)](../admin/new-datacenter-regions.md)  
  
-   [About Microsoft Cloud Australia](../admin/about-microsoft-cloud-australia.md)  
  
-   [About Microsoft Cloud Canada](about-microsoft-cloud-canada.md)  
  
-   [About Microsoft Cloud Japan](../admin/about-microsoft-cloud-japan.md)  
  
-   [About Microsoft Cloud India](../admin/about-microsoft-cloud-india.md)  
  
## How the move works  
 You’ll be provided with a list of prerequisites and post-requisites for your migration. For more information, download [Geo to geo migration information for CRM Online](http://go.microsoft.com/fwlink/p/?LinkID=619083). The following table describes what [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] does before, during, and after your move.  
  
||Before the move|During the move|After the move|  
|-|---------------------|---------------------|--------------------|  
|**What Microsoft does**|**Notification**<br /><br /> Your support representative or Account Manager will work with you to request a move and scheduling.|**Cut-over**<br /><br /> Cut-over for each service lasts from an hour to 6 hours, depending on the number of users and the amount of data. The cut-over is done during the evening or over a weekend.<br /><br /> There is a step that will require your involvement, which is to re-enter the encryption key in [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)]. This can happen at a time that suits you but the migration process will be on hold until you complete this action.|**Notification and support**<br /><br /> You will be alerted by email or telephone when your instance is migrated to the new datacenter.<br /><br /> After your geo has migrated you can perform the post requisite steps - primarily changing your new URLs with any associated Dynamics 365 plugins or services.|  
  
 We will adhere to the terms of the [Microsoft Online Services Service Level Agreement](http://go.microsoft.com/fwlink/p/?LinkID=523897) for all moves.  
  
### See also  
 [Dynamics 365 (online) terminology](online-terminology.md)   
 [Add and edit multiregional instances](add-edit-multiregional-instances.md)   
 [Manage Microsoft Dynamics 365 (online) instances](manage-online-instances.md)