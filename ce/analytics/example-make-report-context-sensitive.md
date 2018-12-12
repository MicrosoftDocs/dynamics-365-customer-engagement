---
title: "Example: Make a report context-sensitive (Dynamics 365 for Customer Engagement apps)| MicrosoftDocs"
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
ms.assetid: ca807b45-a280-40d4-94d5-ed6ef619a144
caps.latest.revision: 12
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
# Example: Make a report context-sensitive

[!INCLUDE [cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE [cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]

The following steps describe how to set up a context-sensitive report in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps.  
  
 For example, if a report displays all activities for a particular account and you want to show this report on the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps **Account** form, you must include **Activities** and **Accounts** in the **Related Record Types** categorization and specify **Forms for related record types** in the **Display** in field of the Report: New form.  
  
## Create and configure a context-sensitive report  
  
1. Create a report that contains fields from a Filtered\<entity> database view and establish one or more SQL JOINs with other related filtered views as required.  
  
2. If you have a Fetch-based report, you can use the following FetchXML query.  
  
   ```xml  
   <fetch>  
     <entity name="activitypointer" enableprefiltering="1" >  
       <attribute name="activitytypecode" />  
       <attribute name="regardingobjectid" />  
       <attribute name="subject" alias="subject" />  
       <link-entity name="account" from="accountid" to="regardingobjectid" link-type='inner' alias="accountLink">  
         <attribute name="name" alias="name" />  
       </link-entity>  
   </entity>  
   </fetch>  
   ```  
  
3. When you upload the report to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps through the **Report: New** form, select all entities in the **Related Record Types** categorization that filtered views are referred to in the report's SQL code.  
  
4. In the **Display In** field, select **Forms for related record types** or **Lists for related record types**. Selecting Lists for related record types lets you run a report from the entity list grid. Selecting **Forms for related record types** lets you run a report from the entity form.  
  
### See also  
 [Sample Reports](../analytics/example-reports.md)   
 [Reporting and Analytics Guide](../analytics/reporting-analytics-with-dynamics-365.md)
