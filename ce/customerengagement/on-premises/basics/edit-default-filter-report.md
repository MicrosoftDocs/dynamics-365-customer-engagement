---
title: "Edit the default filter of a report (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 05/05/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: db9fe062-8682-4739-b162-2fb9109977bb
caps.latest.revision: 35
author: Mattp123
ms.author: matp
manager: brycho
search.audienceType: 
  - enduser

---
# Edit the default filter of a report

::: moniker range=">= op-9-1"

[!INCLUDE [applies-to-unified-interface](../includes/applies-to-unified-interface.md)] [Edit the default filter of a report](/powerapps/user/edit-report-filter)

When a report is a [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] report, is enabled for prefiltering, and has a default filter, you can change the default filter to display the data you expect to see in the report. This filter is used each time any user runs the report.  
  
1. [!INCLUDE[proc_reports](../includes/proc-reports.md)]  
  
2. Select a report, and on the command bar, select **Edit Default Filter**.   
  
3. Modify the filter criteria.  
  
    The criteria are grouped by record types that you can use in the filter, such as **Accounts** or **Contacts**.  
  
   ### To edit an existing row
   1. Select the query relational operator and select an operator, or select the underlined value and enter a new value.  
  
   2. Select the query relational operator, and select an operator.  
  
   To add a criteria row:  

   1. Choose **Select**, and specify the field to filter on.  

   2. Select the query relational operator, and select an operator.  

   3. Select **Enter Value**, and enter a value to filter on. For some values, you can select the **Select or change the values for this field** button ![Ellipsis button](../basics/media/ellipsis-button.gif "Ellipsis button") to open the **Select Values** dialog box and select the value you want.  

   ### To group criteria
   You must select two or more rows for the same record type. For example, **Sales Stage** and **Est. Revenue** are both field values in the **Opportunity** record  type and two rows that specify filter criteria for these fields can be grouped.  However, rows with field values from different record types, such as **Account** and **Opportunity** record types, cannot be grouped.  

   1.  For each row you want to group, in detailed mode, select the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that row, and then select **Select Row**.  

   2.  On the Filter toolbar, select **Group AND** or **Group OR**.  

   3.  To remove a row from a group, select the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that row, and then select **Delete**.  

   4.  To select a group, select the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that group, and then select **Select Group**.  

   5.  To add a criteria clause to a group, select the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that group, select **Add Clause**, and then select the field,  query relational operator, and value.  

   6.  To unselect a group that has been previously selected, click the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that group, and then select **Deselect Group**.  

   7.  To ungroup a group, select the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that group, and then select **Ungroup**.  

   8.  To change a **Group AN**D group to a  Group OR group, or a **Group OR** group to a **Group AND** group, click the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that group, and then select **Change to OR** or **Change to AND**.  

   > [!TIP]
   > - To clear all criteria and start over, on the Filter toolbar, select **Clear**, and then select **Confirm**.  
   >   -   To delete a row, select the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that row, and then select **Delete**.  

    
4.  To save the filter click **Save Default Filter**.  
  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]


::: moniker-end

::: moniker range="< op-9-1"


[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Edit the default filter of a report](/powerapps/user/edit-report-filter)

When a report is a [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] report, is enabled for prefiltering, and has a default filter, you can change the default filter to display the data you expect to see in the report. This filter is used each time any user runs the report.  
  
1. [!INCLUDE[proc_reports](../includes/proc-reports.md)]  
  
2. Select a report, and on the command bar, select **Edit Default Filter**.   
  
3. Modify the filter criteria.  
  
    The criteria are grouped by record types that you can use in the filter, such as **Accounts** or **Contacts**.  
  
   ### To edit an existing row
   1. Select the query relational operator and select an operator, or select the underlined value and enter a new value.  
  
   2. Select the query relational operator, and select an operator.  
  
   To add a criteria row:  

   1. Choose **Select**, and specify the field to filter on.  

   2. Select the query relational operator, and select an operator.  

   3. Select **Enter Value**, and enter a value to filter on. For some values, you can select the **Select or change the values for this field** button ![Ellipsis button](../basics/media/ellipsis-button.gif "Ellipsis button") to open the **Select Values** dialog box and select the value you want.  

   ### To group criteria
   You must select two or more rows for the same record type. For example, **Sales Stage** and **Est. Revenue** are both field values in the **Opportunity** record  type and two rows that specify filter criteria for these fields can be grouped.  However, rows with field values from different record types, such as **Account** and **Opportunity** record types, cannot be grouped.  

   1.  For each row you want to group, in detailed mode, select the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that row, and then select **Select Row**.  

   2.  On the Filter toolbar, select **Group AND** or **Group OR**.  

   3.  To remove a row from a group, select the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that row, and then select **Delete**.  

   4.  To select a group, select the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that group, and then select **Select Group**.  

   5.  To add a criteria clause to a group, select the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that group, select **Add Clause**, and then select the field,  query relational operator, and value.  

   6.  To unselect a group that has been previously selected, click the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that group, and then select **Deselect Group**.  

   7.  To ungroup a group, select the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that group, and then select **Ungroup**.  

   8.  To change a **Group AN**D group to a  Group OR group, or a **Group OR** group to a **Group AND** group, click the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that group, and then select **Change to OR** or **Change to AND**.  

   > [!TIP]
   > - To clear all criteria and start over, on the Filter toolbar, select **Clear**, and then select **Confirm**.  
   >   -   To delete a row, select the **Options menu** button ![arrow&#95;down&#95;black](../basics/media/arrow-down-black.gif "arrow_down_black") for that row, and then select **Delete**.  

    
4.  To save the filter click **Save Default Filter**.  
  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]

::: moniker-end
