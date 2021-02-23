---
title: "Export to an Excel static worksheet (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 05/05/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: a3c0bc58-7b21-496b-b63d-852d7301020c
caps.latest.revision: 43
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - enduser

---
# Export to an Excel static worksheet

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Export to an Excel static worksheet](/powerapps/user/export-excel-static-worksheet)

When you want to present Customer Engagement (on-premises) information to an individual who doesn't have access to Dynamics 365 Customer Engagement (on-premises), or you have data that doesn't change often, consider exporting your Customer Engagement (on-premises) data to a [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] static worksheet.  
  
 <!--If you're on [!INCLUDE[pn_crm_online_2015_update_1_shortest](../includes/pn-crm-online-2015-update-1-shortest.md)], y--> You can export up to 100,000 records at a time. And by default, Dynamics 365 Customer Engagement (on-premises) lists up to 50 records per page. select the <strong>Page</strong> arrows at the bottom of the list to view any additional pages.  
  
## Export data to an [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] static worksheet  
 You may have the option to export data to an [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] static worksheet in all record types however, in some cases the format may be legacy, or the data may not be filtered by what you see in Dynamics 365 Customer Engagement (on-premises) view.  
  
1. Open a list of records.

2. On the command bar select, **Export to Excel** > **Static worksheet (Page only)**.  

  By default, an exported worksheet includes the fields that are displayed in the list, using the same field order, sorting, and field widths. To make changes to the columns in an Advanced Find View, select **Edit Columns**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create, edit, or save an Advanced Find search](../basics/save-advanced-find-search.md)  
  
3. Select **Save** and then save the . xlsm file. Make note of the location where you saved the file.  
  
   > [!NOTE]
   >  If you're going to edit the data file later, it's recommended that you save the file before you open it. Otherwise, you may get this error message: **Excel cannot open or save any more documents because there is not enough available memory or disk space**.  
   > 
   >  To fix the issue do this:  
   > 
   > 1. Open [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] and go to **File** > **Options** > **Trust Center** **Settings Center Settings…** > **Protected View**.  
   >    2.  In **Protected View**, uncheck all three items.  
   >    3.  Then select **OK** > **OK**.  
   > 
   >    We still strongly recommend that you save and then open the data file, rather than disabling protected view, which may put your computer at risk.  
  
4. Open [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] and then open the . xlsm file you saved in the previous step.  
  
   By default, an exported worksheet includes the fields that are displayed in the list, using the same field order, sorting, and field widths.  
  
## Tips  
  
- You can email a static exported worksheet to anyone, or store it in a shared file. Anyone who opens the file will see all the data in the file, whether or not they are a Dynamics 365 Customer Engagement (on-premises) user or have privileges to view the data in Dynamics 365 Customer Engagement (on-premises).  
  
- You can't change the columns for a system view, such as **All Active Accounts**. You must either customize the view, which requires the System Administrator or System Customizer security role, or use Advanced Find to create your own view based on the current view.  
  
<!---   If you're not on [!INCLUDE[pn_crm_online_2015_update_1_shortest](../includes/pn-crm-online-2015-update-1-shortest.md)] and you're using the [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)][!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] web app, you must save the file, open the file using the [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] desktop application, and then resave the file to the . xlsx format. You can then reopen the [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] document in [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] Online.  
-->  
- In Dynamics 365 Customer Engagement (on-premises), money values are exported to [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] as numbers. After you have completed the export, to format the data as currency, see the [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] Help topic titled "Display numbers as currency."  
  
- The data and time values that you see in Dynamics 365 Customer Engagement (on-premises) show up as Date only when you export the file to [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] but the cell actually shows both the date and time.  
  
- If you're going to make changes and import the data file back in to Dynamics 365 Customer Engagement (on-premises), remember that secured, calculated, and composite fields (e.g. Full Name) are read-only and can't be imported in to Dynamics 365 Customer Engagement (on-premises). You'll be able to edit these fields in [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] but when you import the data back in to Dynamics 365 Customer Engagement (on-premises) these fields will not be updated. If you want to update these fields such as a contact's name then it's recommend that you use that view to export your data, update them in [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)], and import them back to Dynamics 365 Customer Engagement (on-premises) for changes.  
  
## Community tools 

**Export to Excel** is a tool provided by the XrmToolbox community developed for Dynamics 365 Customer Engagement (on-premises) Customer Engagement. See the [Developer tools](../developer/developer-tools.md) topic for community developed tools.

> [!NOTE]
> The community tools are not a product of [!include[pn_microsoft_dynamics](../includes/pn-microsoft-dynamics.md)] and does not extend support to the community tools. 
> If you have questions pertaining to the tool, please contact the publisher. More Information: [XrmToolBox](https://www.xrmtoolbox.com). 

## Privacy notice  
[!INCLUDE[cc_privacy_export_to_excel](../includes/cc-privacy-export-to-excel.md)]
  
### See also  
 [Edit the default filter of a report](../basics/edit-default-filter-report.md)   
 [Create, edit, or save an Advanced Find search](../basics/save-advanced-find-search.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]