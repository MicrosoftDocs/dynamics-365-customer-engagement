---
title: "Export data to Excel (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 05/05/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 7505920c-fb5b-4794-acdb-110e307f0ffe
caps.latest.revision: 41
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - enduser

---
# Export data to Excel

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Export data to Excel](/powerapps/user/export-data-excel)

Do you need to analyze your data from Dynamics 365 Customer Engagement (on-premises) and convert that data into actionable items that help you drive more sales? You can choose to export static worksheets or dynamic worksheets, which you can import back into Customer Engagement (on-premises). If you need more advanced functions, you can export a dynamic PivotTable, which makes it very easy to organize and summarize data. Also, analyzing large datasets is not a problem because you can export up to 100,000 rows of data.  
  
Export data to a standard [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] file that you can use on any device such as your phone, tablet, or desktop computer. The data is exported in the same format as you see in Customer Engagement (on-premises). Text will remain text, numbers will remain numbers, and dates will remain dates. However, when you export data from Customer Engagement (on-premises) to [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] the some cell format may change. The table below summarizes how you'll see the data in Customer Engagement (on-premises) and how the cell format changes when you export the data to [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)].  
  
## Cell format when data is exported from Customer Engagement (on-premises) to [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)]  
  
| Data format in Customer Engagement (on-premises) |                                            Cell format in [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)]                                             |
|----------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|
|            Text, Ticker Symbol, Phone, Options set, and Look Up            |                                                       Shows as Text and option set becomes drop-down list                                                       |
|                                 Email, URL                                 |                                                                        Shows as General                                                                         |
|                                   Number                                   |                                                             Shows as Number without group separator                                                             |
|                                  Currency                                  |                                                         Shows as Number and does not include "$" symbol                                                         |
|                          Date only, Date and Time                          |                                                                       Shows as Date only                                                                        |
|                       Calculated and Roll up fields                        | Editable in [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] but can't be imported back to Customer Engagement (on-premises) |
|                               Secured fields                               | Editable in [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] but can't be imported back to Customer Engagement (on-premises) |
  
## See which type of export works best for you  
  
|                                                                                                               Task                                                                                                                |                                              Learn more                                               |
|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------|
|    |
|                                                                   Get a snapshot of the data at the current data and time or you want to share it with others.                                                                    |           [Export to an Excel static worksheet](../basics/export-excel-static-worksheet.md)           |
| Get the most update-to-date information and be able to refresh it in [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] and match what you see in Customer Engagement (on-premises) at any time. |          [Export to an Excel dynamic worksheet](../basics/export-excel-dynamic-worksheet.md)          |
|                                                                      View Customer Engagement (on-premises) data in a pivot table.                                                                      |                 [Export to an Excel PivotTable](../basics/export-excel-pivottable.md)                 |

## Other considerations

- When you export data in [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] (.xlsx format) and then add or modify columns, you can't import the data back in to Customer Engagement (on-premises). This is not supported for .xlsx file format.  
  
- If you're using [!INCLUDE[pn_ms_Excel_2010_short](../includes/pn-ms-excel-2010-short.md)], \ you may get this error message when you export data from Accounts area: 
 
      "The file is corrupt and cannot be opened."  
  
   The error message occurs due to a setting in [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)]. To fix the issue, do this:  
  
  1. Open [!INCLUDE[pn_ms_Excel_2010_short](../includes/pn-ms-excel-2010-short.md)]  
  
  2. Go to **File** > **Options**.  
  
  3. Go to **Trust Center** > **Trust center settings**.  
  
  4. Click **Protected view**. Then clear the check boxes for the first two options.  
  
  5. Click **OK** and then close the **Options** dialog box.  
  
## Community tools 

**Export to Excel** is a tool provided by the XrmToolbox community developed for Dynamics 365 Customer Engagement (on-premises) Customer Engagement. See the [Developer tools](../developer/developer-tools.md) topic for community developed tools.

> [!NOTE]
> The community tools are not a product of [!include[pn_microsoft_dynamics](../includes/pn-microsoft-dynamics.md)] and does not extend support to the community tools. 
> If you have questions pertaining to the tool, please contact the publisher. More Information: [XrmToolBox](https://www.xrmtoolbox.com). 
  
## Privacy notice  
[!INCLUDE[cc_privacy_export_to_excel](../includes/cc-privacy-export-to-excel.md)]




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]