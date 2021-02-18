---
title: "Best practices for reports  | MicrosoftDocs"
ms.custom: 
ms.date: 09/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 5e78f1bf-9124-4a83-b049-c257e8237ff3
caps.latest.revision: 16
author: Mattp123
ms.author: matp
manager: amyla
tags: 
  - MigrationHO
search.audienceType: 
  - customizer

---
# Best practices for reports

The following best practices can help you produce reports that are easier to write, comply with established standards, and execute with improved efficiency.  
  
## General best practices  
 This section provides best practices for creating custom Fetch-based reports.  
  
### Use an existing report to create custom reports  
 Check whether there is an existing report in your app that is close to the design you are looking for. Download the report definition for that report, and then modify the RDL file instead of creating a new one from scratch. By doing this, you will save development time and reduce report writing errors.  
  
### Use Customer Engagement (on-premises) formats for currency, number, date and time, calendar  
 The `FilteredUserSettings` view contains information about currency format, date and time format, number format, negative number, starting day of the week, calendars, and other formats. Customer Engagement (on-premises) provides the **fn_GetFormatStrings** database function to get the date, time, number, currency, and calendar formats from the `FilteredUserSettings` view.  
  
 Use these resources to correctly format data values in your reports.  
  
### Set the page size  
 Reporting Services does not provide explicit page orientation, such as portrait and landscape modes, or preset page sizes. Standard reports are designed for 8.25 x 11 (portrait) or 11 x 8.25 (landscape) page sizes that work for both US letter and A4 paper.  
  
### Back up your reports  
 Make backup copies of your reports and store them on a computer other than the reporting server.  
  
### Define truncation if needed  
 Text wrapping is the default behavior for a text box report item in Reporting Services. This means that, unless indicated otherwise, all text will wrap at the defined width of any text area and then grow vertically. If truncation is specified, a text box will truncate text at the width of the text box within the specified padding (default is 2pt left and right). Any maximum length truncation beyond this will require custom coding.  
  
 The standard reports are set up with tool tips to show static text or values from data fields when the user hovers the mouse pointer over the report item. If you use truncation, consider setting the `ToolTip` property to the field value so that the full text will appear when the user hovers over the truncated text.  
  
### Best practices when you create reports that include date and time fields  
 When you create reports that use date and time fields, be aware of the following:  
  
- To be consistent with the date and time values in Customer Engagement (on-premises), when you create reports that use a Coordinated Universal Time (UTC)-based field (Time-Zone Independent or Date Only) don’t convert the value to a regional time-zone based (User Local) value.  
  
- If you make a change to the date and time behavior of a field in an entity, you may need to regenerate reports that use that date and time for the report to display the field correctly.  
  
  - Regenerate Report Wizard reports. Edit the report using the Report Wizard with the same parameters to regenerate the report.  
  
  - Regenerate reports based on a managed solution. For managed solutions, instead of editing the report, re-import the solution to regenerate the report.  
  
  - Regenerate custom reports created with [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)]. Update the date and time fields in [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)] as necessary and republish the report. 
  
  For more information about date and time fields, see [Behavior of Date and Time data type](../customize/behavior-format-date-time-field.md).  
  
### See also  
 [Reporting and Analytics Guide](../analytics/reporting-analytics-with-dynamics-365.md)   
 [Improve performance of reports](../analytics/improve-performance-reports.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]