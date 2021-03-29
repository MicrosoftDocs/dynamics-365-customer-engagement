---
title: "Create, edit, or save an Advanced Find search (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 05/05/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 45e83f30-ab4c-4ef5-86c4-a0a8f2a21561
caps.latest.revision: 32
author: mkaur
ms.author: mduelae
manager: kvivek
search.audienceType: 
  - enduser

---
# Create, edit, or save an Advanced Find search


::: moniker range=">= op-9-1"


[!INCLUDE [applies-to-unified-interface](../includes/applies-to-unified-interface.md)] [Create, edit, or save an Advanced Find search](/powerapps/user/advanced-find)

Find the records you want in Dynamics 365 Customer Engagement (on-premises) by using the Advanced Find command. You can also use Advanced Find to prepare data for export to [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] so that you analyze, summarize, or aggregate data, or create PivotTables to view your data from different perspectives.  

With the Customer Engagement (on-premises), you can use the advanced find option to build a "Not In" query records using **Does not contain data** option.
  
1. [!INCLUDE[proc_advanced_find](../includes/proc-advanced-find.md)]  
  
2. Specify what to search for.  
  
   1.  In the **Look for** list, select a record type.  
  
   2.  Select **Select** to define search criteria: field (for example, Account Name or City), the query relational operator (Part of an expression (for example "is equal to" or "contains") that defines how a specified attribute should be compared with a value.), and the values to locate (for example, "Seattle" or "Email").  
  
        You can select fields from the current record type, or from related records. For example, an account might have many related contact records.  
  
        At the bottom of the **Select** list, the **Related** section shows related record types. For example, most record types have a related Notes record type. To select fields from a related record type, select field, and a new **Select** link appears.  
         
        If you're using Dynamics 365 Customer Engagement (on-premises), can use advanced find to build a "Does not contain data" query. For example, you can query for all cases that do not contain a task. To do this launch advanced find and in the query, choose look for **Cases** and **Tasks (Regarding)** and chooses **Does not contain data**. 
         
        ![Advanced find does not contain query](media/advancedfind.png "Advanced find does not contain query")
  
3. Specify the columns to include in the search results.  
  
   1.  Select **Edit Columns**, and then select **Add Columns**.  
  
   2.  Select the record type that includes the columns you want to add.  
  
   3.  Select the columns you want to add, and then select **OK**.  
  
4. Specify the sort order.  
  
   1.  Select **Edit Columns**.  
  
   2.  Select **Configure Sorting**.  
  
   3.  Specify the column to sort on, specify the sort order, and then select **OK**.  
  
   4.  Select **OK**.  
  
5. Select **Results**.  
  




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]



::: moniker-end

::: moniker range="< op-9-1"


[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Create, edit, or save an Advanced Find search](/powerapps/user/advanced-find)

Find the records you want in Dynamics 365 Customer Engagement (on-premises) by using the Advanced Find command. You can also use Advanced Find to prepare data for export to [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] so that you analyze, summarize, or aggregate data, or create PivotTables to view your data from different perspectives.  

With the Customer Engagement (on-premises), you can use the advanced find option to build a "Not In" query records using **Does not contain data** option.
  
1. [!INCLUDE[proc_advanced_find](../includes/proc-advanced-find.md)]  
  
2. Specify what to search for.  
  
   1.  In the **Look for** list, select a record type.  
  
   2.  Select **Select** to define search criteria: field (for example, Account Name or City), the query relational operator (Part of an expression (for example "is equal to" or "contains") that defines how a specified attribute should be compared with a value.), and the values to locate (for example, "Seattle" or "Email").  
  
        You can select fields from the current record type, or from related records. For example, an account might have many related contact records.  
  
        At the bottom of the **Select** list, the **Related** section shows related record types. For example, most record types have a related Notes record type. To select fields from a related record type, select field, and a new **Select** link appears.  
         
        If you're using Dynamics 365 Customer Engagement (on-premises), can use advanced find to build a "Does not contain data" query. For example, you can query for all cases that do not contain a task. To do this launch advanced find and in the query, choose look for **Cases** and **Tasks (Regarding)** and chooses **Does not contain data**. 
         
        ![Advanced find does not contain query](media/advancedfind.png "Advanced find does not contain query")
  
3. Specify the columns to include in the search results.  
  
   1.  Select **Edit Columns**, and then select **Add Columns**.  
  
   2.  Select the record type that includes the columns you want to add.  
  
   3.  Select the columns you want to add, and then select **OK**.  
  
4. Specify the sort order.  
  
   1.  Select **Edit Columns**.  
  
   2.  Select **Configure Sorting**.  
  
   3.  Specify the column to sort on, specify the sort order, and then select **OK**.  
  
   4.  Select **OK**.  
  
5. Select **Results**.  
  




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]


::: moniker-end
