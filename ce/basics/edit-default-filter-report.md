---
title: "Edit the default filter of a report (Dynamics 365 for Customer Engagement) | MicrosoftDocs"
ms.custom: 
ms.date: 09/15/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: db9fe062-8682-4739-b162-2fb9109977bb
caps.latest.revision: 35
author: Mattp123
ms.author: matp
manager: brycho
search.audienceType: 
  - enduser
search.app: 
  - D365CE
---
# Edit the default filter of a report

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

When a report is a [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] report, is enabled for prefiltering, and has a default filter, you can change the default filter to display the data you expect to see in the report. This filter is used each time any user runs the report.  
  
1. [!INCLUDE[proc_permissions_system_admin](../includes/proc-permissions-system-admin.md)]  
    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)].  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_reports](../includes/proc-reports.md)]  
  
3. Select a report, and on the command bar, click or tap **More Commands**![More Commands button in Appointment Activity](../basics/media/morecommands.gif "More Commands button in Appointment Activity"), and then click or tap **Edit Default Filter**.  
  
    To see all reports, including sub-reports that aren’t visible in the default view, select the **All reports, Including Sub-reports** view.  
  
4. Modify the filter criteria.  
  
    The criteria are grouped by record types that you can use in the filter, such as **Accounts** or **Contacts**.  
  
   ### To edit an existing row
   1. click or tap the query relational operator and select an operator, or click or tap the underlined value and enter a new value.  
  
   2. Click or tap the query relational operator, and select an operator.  
  
   To add a criteria row:  

   1.  Click or tap **Select**, and specify the field to filter on.  

   2.  Click or tap the query relational operator, and select an operator.  

   3.  Click or tap **Enter Value**, and enter a value to filter on. For some values, you can click or tap the **Select or change the values for this field** button ![Ellipsis button](../basics/media/ellipsis-button.gif "Ellipsis button") to open the **Select Values** dialog box and select the value you want.  

   ### To group criteria
   You must select two or more rows for the same record type. For example, **Sales Stage** and **Est. Revenue** are both field values in the **Opportunity** record  type and two rows that specify filter criteria for these fields can be grouped.  However, rows with field values from different record types, such as **Account** and **Opportunity** record types, cannot be grouped.  

   1.  For each row you want to group, in detailed mode, click or tap the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that row, and then click or tap **Select Row**.  

   2.  On the Filter toolbar, select **Group AND** or **Group OR**.  

   3.  To remove a row from a group, click or tap the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that row, and then click or tap **Delete**.  

   4.  To select a group, click or tap the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that group, and then click or tap **Select Group**.  

   5.  To add a criteria clause to a group, click or tap the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that group, click or tap **Add Clause**, and then select the field,  query relational operator, and value.  

   6.  To unselect a group that has been previously selected, click the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that group, and then click or tap **Deselect Group**.  

   7.  To ungroup a group, click or tap the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that group, and then click or tap **Ungroup**.  

   8.  To change a **Group AN**D group to a  Group OR group, or a **Group OR** group to a **Group AND** group, click the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that group, and then click or tap **Change to OR** or **Change to AND**.  

   > [!TIP]
   > - To clear all criteria and start over, on the Filter toolbar, click or tap **Clear**, and then click or tap **Confirm**.  
   >   -   To delete a row, click or tap the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that row, and then click or tap **Delete**.  

   ### Save the filter  
5. Click or tap **Save Default Filter**.  
  
### See also  
 [Create, edit, or copy a report using the Report Wizard](../basics/create-edit-copy-report-wizard.md)   
 [Customize and organize reports](../customize/customize-organize-reports.md)   
 [Get started writing reports](../analytics/get-started-writing-reports.md)
