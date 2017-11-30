---
title: "Recover database space by deleting Dynamics 365 Customer Engagement audit logs | MicrosoftDocs"
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
ms.assetid: 99ea6ece-c35a-4f0e-85a4-26622ba9db67
caps.latest.revision: 7
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Recover database space by deleting audit logs

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]
[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

When you enable auditing, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] stores the change history for transactions in the form of audit logs in the database. You can delete the old or unwanted logs to clean up the database space.  
  
> [!CAUTION]
>  When you delete an audit log, you can no longer view the audit history for the period covered by that audit log.  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_auditing](../includes/proc-settings-auditing.md)]  
  
3.  Choose **Audit Log Management**  
  
4.  Select the oldest audit log. Then, on the command bar, choose **Delete Logs**.  
  
5.  In the confirmation message, choose **OK**.  
  
    > [!NOTE]
    >  You can only delete the oldest audit log in the system. To delete more than one audit log, continue to delete the oldest audit log until you have deleted enough logs.  
  
### See also  
 [Audit data and user activity](audit-data-user-activity.md)
