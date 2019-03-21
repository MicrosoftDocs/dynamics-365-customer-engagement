---
title: "Add report navigation (Dynamics 365 for Customer Engagement) | MicrosoftDocs"
ms.custom: 
ms.date: 09/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: a12434b2-dfb4-44c8-93fe-640084360d9c
caps.latest.revision: 14
author: Mattp123
ms.author: matp
manager: amyla
tags: 
  - MigrationHO
search.audienceType: 
  - customizer
search.app: 
  - D365CE
---
# Add report navigation

[!INCLUDE [cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE [cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]

Report navigation enables a dynamic and interactive reporting experience. By using various types of actions, reports let the user navigate to detailed reports, [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps records, or other websites.  
  
> [!NOTE]
>  For more information about report navigation, see [Drillthrough, Drilldown, Subreports, and Nested Data Regions (Report Builder and SSRS)](https://technet.microsoft.com/library/dd207141.aspx) in the [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] documentation. This topic describes report navigation that is specific to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps reports.  
  
## Dynamic drill through to Dynamics 365 for Customer Engagement apps 
 You can drill through a report to navigate to a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps web form. A drill-through report is implemented in the following steps:  
  
1. An image or value item (such as a text box) is added to a report. The `Value` property of this item contains code that builds a URL by using the base address of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps plus parameters that refer to a specific record.  
  
2. When the user selects the report item, a new browser window is opened by using the constructed URL passed as the target web address.  
  
3. [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps loads the information for the specified entity into a web form that is displayed in the browser window.  
  
### To set up a drill-through report in Dynamics 365 for Customer Engagement apps 
  
1. Create a hidden parameter of type string in the report that has the name CRM_URL. For more information about adding parameters, see [Use Parameters in Reports](../analytics/use-parameters-in-reports.md). When the report is run, this parameter is automatically set to the web address of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps.  
  
2. Add a report item, such as a **Textbox**.  
  
3. Right-click the drill-through report item and select **Properties** from the shortcut menu.  
  
4. Click **Advanced**.  
  
5. In the **Navigation** tab, click **Jump to URL** and enter an expression in the following format:  
  
   ```sql  
   = Parameters!CRM_URL.Value & "?ID={"& GUID &"}&LogicalName=entity logical name"  
   ```  
  
    The entity GUID and entity logical name have to be added to the URL to be able to drill through. For example:  
  
   ```sql  
   = Parameters!CRM_URL.Value & "?ID={"&Fields!Opportunityid.Value.ToString()&"}&LogicalName=opportunity"  
   ```  
  
6. Click **OK**.  
  
   In this example code, the value of a dataset field that contains the GUID of an `Opportunity` object is converted to a string and used as an ID parameter in the URL. A parameter that contains the LogicalName value for an opportunity entity is also appended.  
  
   The GUID of a record can be obtained from the appropriate filtered view, for example, `FilteredOpportunity`.  
  
### See also  
 [Reporting and Analytics Guide](../analytics/reporting-analytics-with-dynamics-365.md)   
 [Categorize and Display Reports in Different Languages](../analytics/categorize-display-reports-different-languages.md)
