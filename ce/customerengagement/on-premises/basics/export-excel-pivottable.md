---
title: "Export to an Excel PivotTable (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
description: How to export to an Excel PivotTable.
ms.date: 05/05/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 5b798287-5c58-47da-a893-f00394d0ae94
caps.latest.revision: 46
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - enduser

---
# Export to an Excel PivotTable

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Export to an Excel PivotTable](/powerapps/user/export-excel-pivottable)

You can export Dynamics 365 Customer Engagement (on-premises) data to a [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] PivotTable to see patterns and trends in data. An [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] PivotTable is a great way to summarize, analyze, explore, and present your Customer Engagement (on-premises) data. You can export up to 100,000 records at a time.  
  
## Prerequisites  
  
- On a default Dynamics 365 Customer Engagement (on-premises) installation, before you export data to an [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] PivotTable, make sure that your [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] allows remote connections.  
  
   ### Allow remote connections to SQL Server
  
  1. Start [!INCLUDE[pn_ms_SQL_Management_Studio_long](../includes/pn-ms-sql-management-studio-long.md)].  
  
  2. Connect to the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] instance.  
  
  3. Right-click the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] instance name, select **Properties**, select **Connections**, and then select the **Allow remote connections to this server** check box.  
  
- [!INCLUDE[pn_Windows_Firewall](../includes/pn-windows-firewall.md)] allows remote [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] connections. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [How to: Configure a Windows Firewall for Database Engine Access](/sql/database-engine/configure-windows/configure-a-windows-firewall-for-database-engine-access).  
  
## Export to an [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] PivotTable  
 The option to export data to an [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] PivotTable isn't available in all Customer Engagement (on-premises) record types. If you don't see the option, it's not available for that record.  
  
1. Open a list of records. 
  
2. On the command bar, select **Export to Excel** > **Dynamic PivotTable**.  
  
3. In the **Select PivotTable Columns** list, clear the check boxes for the fields as needed, and then select **Export**.  
  
    By default, the **PivotTable Field List** includes only fields that are displayed in the **Select PivotTable Columns** list.  
  
4. Select **Save** and then save the .xlsx file. Make note of the location where you saved the file.  
  
   > [!NOTE]
   >  If you're going to edit the data file later, it's recommended that you save the file before you open it. Otherwise, you may get this error message: **[!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] cannot open or save any more documents because there is not enough available memory or disk space**.  
   > 
   >  To fix the issue do this:  
   > 
   > 1. Open [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] and go to **File** > **Options** > **Trust Center**  
   >    2.  Select **Trust Center Settings**, and then select **Protected View**.  
   >    3.  Under **Protected View**, clear the check boxes for all three items.  
   >    4.  Select **OK**, and then **OK**.  
   > 
   >    We still strongly recommend that you save and then open the data file, rather than disabling protected view, which may put your computer at risk.  
  
5. Open [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] and then open the .xlsx file you saved in the previous step.  
  
6. If you see the security warning **External Data Connections have been disabled**, select **Enable Content**.  
  
7. To refresh data in the file, on the **Data** tab select **Refresh from CRM**.  
  
   > [!NOTE]
   >  To view and refresh dynamic data, [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)] must be installed. If it is already installed and configured, select **Refresh from CRM** to sign in to Dynamics 365 Customer Engagement (on-premises).  If you do not want to be prompted again to sign in, select **Save my email address and password** in the Sign-In page.  
  
8. Drag the fields from the PivotTable Field List to the PivotTable. For more information, see [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] Help.  
  
## Tips  
  
- If you export a list to a dynamic worksheet or PivotTable that you think will be useful to other Dynamics 365 Customer Engagement (on-premises) users, you can add the list as a report, and then share it with others or make it available to all Dynamics 365 Customer Engagement (on-premises) users.  
  
   If the recipients are in the same domain as you, and are Dynamics 365 Customer Engagement (on-premises) users, you can email a dynamic [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] file, or store it as a shared file. When recipients open the dynamic file, they will see data they have permission to view in Dynamics 365 Customer Engagement (on-premises), so the data they see may be different from what you see.  
  
- In Dynamics 365 Customer Engagement (on-premises), money values are exported to [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] as numbers. After you have completed the export, to format the data as currency, see the [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)][!INCLUDE[pn_doc_help_long](../includes/pn-doc-help-long.md)] topic titled "Display numbers as currency."  
  
- The data and time values that you see in Dynamics 365 Customer Engagement (on-premises) show up as "Date" only when you export the file to [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] but the cell actually shows both the date and time.  
  
- If you're going to make changes and import the data file back in to Dynamics 365 Customer Engagement (on-premises), remember that secured, calculated, and composite fields (such as Full Name) are read-only and can't be imported in to Dynamics 365 Customer Engagement (on-premises). You'll be able to edit these fields in Excel but when you import the data back in to Dynamics 365 Customer Engagement (on-premises) these fields won't be updated. If you want to update these fields such as a contact's name, it's recommend that you use that view to export your data, update them in [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)], and import them back to Dynamics 365 Customer Engagement (on-premises) for changes.  
  
- Some system views, such as Accounts: No Campaign Activities in Last 3 Months, can be exported only to a static [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] worksheet.  
  
- Your operating system region settings (in Windows, **Control Panel** > **Region**) and Dynamics 365 Customer Engagement (on-premises) region settings (**Settings** (![Settings button on the nav bar](../basics/media/settings-gear-icon.png "Settings button on the nav bar")) > **Options** > **Languages**) should be the same. If not, refreshing dynamic data with **Refresh from CRM** might cause data changes.  
  
## Privacy notice  
[!INCLUDE[cc_privacy_export_to_excel](../includes/cc-privacy-export-to-excel.md)]
  
### See also  
 [Export data to Excel](../basics/export-data-excel.md)   



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
