---
title: "Publish reports (Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
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
ms.assetid: 4d2af46d-1b57-4c30-871e-de2694e6b48f
caps.latest.revision: 15
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
# Publish reports

[!INCLUDE [cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE [cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]

To make reports available to users, publish the reports in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps.  
  
## Publish a report in Dynamics 365 for Customer Engagement apps by using the web application  
  
1. Create a new report or modify a report by using [!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create Custom Reports Using Business Intelligence Development Studio](../analytics/create-a-new-report-using-sql-server-data-tools.md)  
  
2. Sign in to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps, and then go to **Sales** > **Reports**.  
  
3. On the command bar, click **New**.  
  
4. In the **Report:New Report** dialog box, in the **Report Type** list, select **Existing File**, click **Browse**, and then specify the location of the .rdl file in the **File Location** box.  
  
5. Emter appropriate data in the **Details** section of the **Report:New Report** dialog box.  
  
6. Click **Save and Close**.  
  
    You can test the report by selecting it from the Available Reports list. To add the report to context-sensitive lists and forms in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps, follow the steps in [Determine where the report will appear](../analytics/publish-reports.md#BKMK_reportappear).  
  
   > [!TIP]
   >  To update the report or to update the information that is displayed in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps, such as the description, in the Available Reports list, select the report, and then click **Edit** on the command bar.  
  
<a name="BKMK_reportappear"></a>   
## Determine where the report will appear  
  
1. Select the report in the Reports view, and then click **Edit** on the command bar.  
  
2. In the **Report** dialog box, specify values in the **Categorization** section according to the following descriptions:  
  
   - **Categories**: Categorizes the report by its intended purpose. For example, a sales report can be included in context-sensitive lists and forms in the Sales area of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps.  
  
   - **Related Record Types**: Associates the report to specific entities, such as accounts or contacts.  
  
   - **Display In**: Allows the report to be displayed in context-sensitive forms and lists. You can restrict where the report is displayed. If you intend to publish a hidden report, clear the **Display In** check box.  
  
3. Click **Save and Close**.  
  
   By default, a report is uploaded as a user-owned report. To make the report visible to the whole organization, you can do either of the following when editing a report:  
  
-   In the **Report** dialog box, click the **Administration** tab, and then in the **Viewable By** field, select **Individual**.  
  
-   In the **Report** dialog box, on the **Actions** menu, select **Publish Report for External Use**.  
  
## Define a default filter for the report  
 You can define a default filter for a report so that the filter criteria are used every time the report is run.  
  
1.  Select a report in the Reports grid, and on the More Actions (…) menu, select **Edit Default Filter**.  
  
2.  In the **Report Viewer** dialog box, define the default filter criteria that will be used every time the report runs, and then select **Save Default Filter**.  
  
### See also  
 [Reporting and Analytics Guide](../analytics/reporting-analytics-with-dynamics-365.md)   
 [Report considerations and best practices](../analytics/report-considerations-and-best-practices.md)
