---
title: "System Settings dialog box - Service tab for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "shubhadaj"
ms.assetid: 926c05fe-4499-4f5b-ab0c-39d29589f094
caps.latest.revision: 29
ms.author: "shujoshi"
manager: "sakudes"
---
# System Settings dialog box - Service tab

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

Use the Service tab in System Settings to set preferences for the customer service area, such as service level agreements and entitlements in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  
  
3.  Click the **System Settings** > **Service** tab. 

> [!NOTE]
> In the Customer Service Hub app, go to **Service Management** > **Service Configuration Settings** in the sitemap to access the Service configuration settings.
  
|Settings|Description|  
|--------------|-----------------|  
|**Disable SLAs**||  
|Disable Service Level Agreements(SLAs) on SLA-enabled entity records|SLAs are enabled by default. You can enable or disable them for SLA-enabled entity records in your organization. For example, you might want to disable SLAs during maintenance activities or when you're importing records and you don't want the SLAs to apply to the records. To disable, click **Yes**. To enable, click **No**. **Note:**  When SLAs are disabled, SLA records can still be created or modified. SLAs won’t be applied to  records, however.|  
|**Apply SLA after manual override**||  
|Automatically apply SLA on entity record update after SLA was manually applied **Important:**  For [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] organizations, this feature is available only if your organization has installed [!INCLUDE[pn_crm_online_2016_update](../includes/pn-crm-online-2016-update.md)]. For on-premises Dynamics 365 organizations, this feature is only available if you've updated to CRM 2016. Interested in getting this feature? [Find your Dynamics 365 administrator or support person](../basics/find-administrator-support.md).|This setting determines if an SLA should automatically be applied to a  record when an SLA is manually selected in the record's SLA field. The automatic SLA application can either be through the entitlement applied to the case(for theCase entity) or with the default SLA.<br /><br /> Either way, the manual SLA takes precedence over any other way of SLA application.<br /><br /> When set to **No**, SLAs won’t be applied automatically to records after an SLA is manually applied. **Note:**  For Case entity records, when both entitlement and customer, and manual SLA are changing, the manual SLA is used regardless of this setting.|  
|**Select SLA Pause Status**||  
|Select the SLA enabled entity to choose status values for|Select the SLA-enabled entity you want to choose the pause status for. **Important:**  This feature of enabling other entities for SLA was  introduced in [!INCLUDE[pn_crm_8_1_0_online_subsequent](../includes/pn-crm-8-1-0-online-subsequent.md)] and [!INCLUDE[pn_crm_8_1_0_op_subsequent](../includes/pn-crm-8-1-0-op-subsequent.md)].   Interested in getting this feature? [Find your Dynamics 365 administrator or support person](../basics/find-administrator-support.md)|  
|For the selected entity, choose the status values that SLA calculation should pause for|Select the statuses for which the SLA calculation should be paused. Double-click the statuses in the **Available Values** column. When the user sets a record to one of the pause status values you set here, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] pauses the SLA calculation. When the user changes the status of the case back to a status other than a pause status, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] updates the failure and warning time in the enhanced SLA  KPIs. It also tracks the total time for which a  record is in the pause status. **Important:**  This feature of enabling other entities for SLA was  introduced in [!INCLUDE[pn_crm_8_1_0_online_subsequent](../includes/pn-crm-8-1-0-online-subsequent.md)] and [!INCLUDE[pn_crm_8_1_0_op_subsequent](../includes/pn-crm-8-1-0-op-subsequent.md)].   Interested in getting this feature? [Find your Dynamics 365 administrator or support person](../basics/find-administrator-support.md)|  
|**Automatically apply entitlement**|-   Select whether to automatically apply the default customer entitlement when a case is created.<br />-   Select whether to automatically apply the default customer entitlement when a case is updated and the customer, contact, or product field has changed.|  
  
### See also  
 [Define service level agreements](../customer-service/define-service-level-agreements.md)
