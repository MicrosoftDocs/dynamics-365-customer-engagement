---
title: "View and edit bulk delete jobs in Dynamics 365 Customer Engagement (on-premises)"
description: "View the status of, pause, postpone, resume, cancel, or modify a system job that you created using Bulk Record Deletion."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 8a7e3846-a054-46d6-8a60-898b2c17523d
caps.latest.revision: 24
author: Mattp123
ms.author: matp
search.audienceType: 
  - admin
---
# View and take action on bulk deletion jobs

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

You can view the status of, pause, postpone, and resume a system job that you created using **Bulk Record Deletion**.  
  
1. [!INCLUDE[proc_settings_datamanagement](../includes/proc-settings-datamanagement.md)]  
  
2. Choose **Bulk Record Deletion**.  
  
3. In the **Bulk Record Deletion** window, you can perform the actions described in the following table.  
  
   |To|Do this|  
   |--------|-------------|  
   |View status|Look in the **Status Reason** column.|  
   |View detailed status, including success and failure information|Select the bulk-deletion job.|  
   |View queries submitted for deletion|Select the bulk-deletion job, and then under **Information**, choose **Properties**.|  
   |Review the errors|Select the bulk-deletion job, and then under **Related**, choose **Failures**.|  
   |Pause a bulk-deletion job|1.  Select the bulk-deletion job, and then on the Actions menu, choose **Pause**.<br />2.  When the confirmation message appears, choose **OK**. **Note:**  Bulk deletion jobs of fewer than 1,000 records cannot be paused.|  
   |Postpone a bulk-deletion job|1.  Select the bulk-deletion job, and then on the Actions menu, choose **Postpone**.<br />2.  When the confirmation message appears, choose **OK**.|  
   |Resume a bulk-deletion job|1.  Select the bulk-deletion job, and then on the Actions menu, choose **Resume**.<br />2.  When the confirmation message appears, choose **OK**.|  
   |Cancel a bulk-deletion job|1.  Select the bulk-deletion job, and then on the Actions menu, choose **Cancel**.<br />2.  When the confirmation message appears, choose **OK**.|  
   |Modify recurrence of a bulk-delete job|1.  Select the bulk-deletion job, and then on the Actions menu, choose **Modify Recurrence**.<br />2.  If you select the **Run this job after every** check box, specify the interval after which you want the bulk-deletion job to run, and then choose **OK**.<br /><br /> If you select the **Run this job after every** check box when you create a bulk-deletion job, the job becomes recurring and is moved to the **Recurring Bulk Deletion System Jobs** view. You can only change the recurrence for these recurring bulk-deletion jobs.|  
  
### See also  
 [Manage your data (for admins)](../admin/manage-your-data.md)   
 [Delete bulk records](delete-bulk-records.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
