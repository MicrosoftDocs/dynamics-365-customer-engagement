---
title: "View and take action on Dynamics 365 Customer Engagement bulk deletion jobs | MicrosoftDocs"
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
ms.assetid: 8a7e3846-a054-46d6-8a60-898b2c17523d
caps.latest.revision: 24
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# View and take action on bulk deletion jobs

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

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
