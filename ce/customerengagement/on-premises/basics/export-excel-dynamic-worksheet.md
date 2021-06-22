---
title: "Export to an Excel dynamic worksheet (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 05/05/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: fd391660-beac-4f58-9499-90c8e807dc97
caps.latest.revision: 53
author: "mduelae"
ms.author: "mkaur"
manager: "kvivek"
search.audienceType: 
  - enduser

---
# Export to an Excel dynamic worksheet


::: moniker range=">= op-9-1"

[!INCLUDE [applies-to-unified-interface](../includes/applies-to-unified-interface.md)] [Export to an Excel dynamic worksheet](/powerapps/user/export-excel-dynamic-worksheet)

Export data to a [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] worksheet so users can have the latest Dynamics 365 Customer Engagement (on-premises) information any time they view the worksheet. Imagine the CEO of your company getting the critical information they need without having to navigate Dynamics 365 Customer Engagement (on-premises) but instead, merely opening the [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] link on their desktop. You can export up to 100,000 records at a time.  
 
  
> [!IMPORTANT]
>  Your operating system region settings (in [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)], **Control Panel** > **Region**) and Dynamics 365 Customer Engagement (on-premises) organization language and locale (**Settings** > **Administration** > **System Settings** > **Formats tab** > **Current Format**) should be the same. If not, refreshing dynamic data with **Refresh from CRM** might cause data changes.  
  
## Export data to an Excel dynamic worksheet  
You can't export data to a dynamic worksheet in [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] for all Dynamics 365 Customer Engagement (on-premises) record types. If you don't see the option, it's not available for that record.  
  
1. Open a list of records.

2. On the command bar select, **Export to Excel** > **Dynamic Worksheet**.  
  
3. Under **Common Tasks**, configure the column settings and then select **Export**.  
  
4. Select **Save** and then save the .xlsx file. Make note of the location where you saved the file.  
  
   > [!NOTE]
   >  If you're going to edit the data file later, it's recommended that you save the file before you open it. Otherwise, you might get this error message: Microsoft **Excel cannot open or save any more documents because there is not enough available memory or disk space**.  
   > 
   >  To fix the issue do this:  
   > 
   > 1. Open Excel and go to **File** > **Options** > **Trust Center** **Settings Center Settings…** > **Protected View**.  
   >    2.  In **Protected View**, uncheck all three items.  
   >    3.  Then select **OK** > **OK**.  
   > 
   >    We still strongly recommend that you save and then open the data file, rather than disabling protected view which may put your computer at risk.  
  
5. Open [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] and then open the .xlsx file you saved in the previous step.  
  
6. If you see the security warning **External Data Connections have been disabled**, select **Enable Content**.  
  
7. To refresh data in the file, on the **Data** tab, select **Refresh All** > **Refresh All**. 

    If a warning message displays specifying that the web query returned no data, select **OK**. The excel file appears blank. To resolve the warning, follow the steps as described in [Data disappears after I refresh the exported dynamic Excel file](https://docs.microsoft.com/powerapps/user/ts-export-to-excel#data-disappears-after-i-refresh-the-exported-dynamic-excel-file). 
  
   > [!NOTE]
   > - To view and refresh dynamic data, [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)] must be installed. If it is already installed and configured, select **Refresh from CRM** to sign in to Dynamics 365 Customer Engagement (on-premises). If you do not want to be prompted again to sign in, select **Save my email address and password** in the Sign-In page.  
   > - If you have a phone numbers that starts with **+** or **–**, for example +1-123-456-7890, when you refresh the dynamic worksheet the phone number field will not display the number correctly.   
   > - To avoid the issue, use a space or parentheses **()**, like this: +1 123-456-7890 or +1 (123)-456-7890  
  
## Tips  
  
- You can email a dynamic [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] file or store it as a shared file if the recipients are in the same domain as you. When recipients open the dynamic file, they'll see data they have permission to view in Dynamics 365 Customer Engagement (on-premises), so the data they see may be different from what you see.  
  
- Some system views, such as Accounts: No Campaign Activities in Last 3 Months, can be exported only to a static [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] worksheet.  
  
- In Dynamics 365 Customer Engagement (on-premises), money values are exported to [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] as numbers. After you have completed the export, to format the data as currency, see the [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)][!INCLUDE[pn_doc_help_long](../includes/pn-doc-help-long.md)] topic titled "Display numbers as currency."  
  
- The data and time values that you see in Dynamics 365 Customer Engagement (on-premises) show up as Date only when you export the file to [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] but the cell actually shows both the date and time.  
  
- If you're going to make changes and import the data file back in to Dynamics 365 Customer Engagement (on-premises), remember that secured, calculated, and composite fields (e.g. Full Name) are read-only and can't be imported in to Dynamics 365 Customer Engagement (on-premises). You'll be able to edit these fields in [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] but when you import the data back in to Dynamics 365 Customer Engagement (on-premises) these fields will not be updated. If you want to update these fields such as a contact's name then it's recommend that you use that view to export your data, update them in Excel, and import them back to Dynamics 365 Customer Engagement (on-premises) for changes.  
  
## Privacy notice  
[!INCLUDE[cc_privacy_export_to_excel](../includes/cc-privacy-export-to-excel.md)]
  
### See also  
 [Export data to Excel](../basics/export-data-excel.md)     



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]

::: moniker-end


::: moniker range="< op-9-1"


[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Export to an Excel dynamic worksheet](/powerapps/user/export-excel-dynamic-worksheet)

Export data to a [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] worksheet so users can have the latest Dynamics 365 Customer Engagement (on-premises) information any time they view the worksheet. Imagine the CEO of your company getting the critical information they need without having to navigate Dynamics 365 Customer Engagement (on-premises) but instead, merely opening the [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] link on their desktop. You can export up to 100,000 records at a time.  
 
  
> [!IMPORTANT]
>  Your operating system region settings (in [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)], **Control Panel** > **Region**) and Dynamics 365 Customer Engagement (on-premises) organization language and locale (**Settings** > **Administration** > **System Settings** > **Formats tab** > **Current Format**) should be the same. If not, refreshing dynamic data with **Refresh from CRM** might cause data changes.  
  
## Export data to an Excel dynamic worksheet  
You can't export data to a dynamic worksheet in [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] for all Dynamics 365 Customer Engagement (on-premises) record types. If you don't see the option, it's not available for that record.  
  
1. Open a list of records.

2. On the command bar select, **Export to Excel** > **Dynamic Worksheet**.  
  
3. Under **Common Tasks**, configure the column settings and then select **Export**.  
  
4. Select **Save** and then save the .xlsx file. Make note of the location where you saved the file.  
  
   > [!NOTE]
   >  If you're going to edit the data file later, it's recommended that you save the file before you open it. Otherwise, you might get this error message: Microsoft **Excel cannot open or save any more documents because there is not enough available memory or disk space**.  
   > 
   >  To fix the issue do this:  
   > 
   > 1. Open Excel and go to **File** > **Options** > **Trust Center** **Settings Center Settings…** > **Protected View**.  
   >    2.  In **Protected View**, uncheck all three items.  
   >    3.  Then select **OK** > **OK**.  
   > 
   >    We still strongly recommend that you save and then open the data file, rather than disabling protected view which may put your computer at risk.  
  
5. Open [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] and then open the .xlsx file you saved in the previous step.  
  
6. If you see the security warning **External Data Connections have been disabled**, select **Enable Content**.  
  
7. To refresh data in the file, on the **Data** tab, select **Refresh All** > **Refresh All**. 

    If a warning message displays specifying that the web query returned no data, select **OK**. The excel file appears blank. To resolve the warning, follow the steps as described in [Data disappears after I refresh the exported dynamic Excel file](/powerapps/user/ts-export-to-excel#data-disappears-after-i-refresh-the-exported-dynamic-excel-file). 
  
   > [!NOTE]
   > - To view and refresh dynamic data, [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)] must be installed. If it is already installed and configured, select **Refresh from CRM** to sign in to Dynamics 365 Customer Engagement (on-premises). If you do not want to be prompted again to sign in, select **Save my email address and password** in the Sign-In page.  
   > - If you have a phone numbers that starts with **+** or **–**, for example +1-123-456-7890, when you refresh the dynamic worksheet the phone number field will not display the number correctly.   
   > - To avoid the issue, use a space or parentheses **()**, like this: +1 123-456-7890 or +1 (123)-456-7890  
  
## Tips  
  
- You can email a dynamic [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] file or store it as a shared file if the recipients are in the same domain as you. When recipients open the dynamic file, they'll see data they have permission to view in Dynamics 365 Customer Engagement (on-premises), so the data they see may be different from what you see.  
  
- Some system views, such as Accounts: No Campaign Activities in Last 3 Months, can be exported only to a static [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] worksheet.  
  
- In Dynamics 365 Customer Engagement (on-premises), money values are exported to [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] as numbers. After you have completed the export, to format the data as currency, see the [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)][!INCLUDE[pn_doc_help_long](../includes/pn-doc-help-long.md)] topic titled "Display numbers as currency."  
  
- The data and time values that you see in Dynamics 365 Customer Engagement (on-premises) show up as Date only when you export the file to [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] but the cell actually shows both the date and time.  
  
- If you're going to make changes and import the data file back in to Dynamics 365 Customer Engagement (on-premises), remember that secured, calculated, and composite fields (e.g. Full Name) are read-only and can't be imported in to Dynamics 365 Customer Engagement (on-premises). You'll be able to edit these fields in [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] but when you import the data back in to Dynamics 365 Customer Engagement (on-premises) these fields will not be updated. If you want to update these fields such as a contact's name then it's recommend that you use that view to export your data, update them in Excel, and import them back to Dynamics 365 Customer Engagement (on-premises) for changes.  
  
## Privacy notice  
[!INCLUDE[cc_privacy_export_to_excel](../includes/cc-privacy-export-to-excel.md)]
  
### See also  
 [Export data to Excel](../basics/export-data-excel.md)     



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]

::: moniker-end
