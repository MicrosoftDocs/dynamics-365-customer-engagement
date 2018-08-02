---
title: "Improve report performance by using filters (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 65af0819-705e-4628-ad2f-05df9211c374
caps.latest.revision: 15
author: "Mattp123"
ms.author: "matp"
manager: "amyla"
tags: 
 - "MigrationHO"
---
# Improve report performance by using filters

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Reports that return large data sets can be difficult to use and can cause performance problems. To limit the data that is presented in a report, use data filters.  
  
 In addition to data filtering supported by Reporting Services, [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] supports data pre–filtering. You can use data pre-filtering to:  
  
-   Make reports context-sensitive by narrowing the scope of a report to return more relevant data.  
  
-   Retrieve and display a result set faster because only more relevant data is returned.  
  
-   Allow the report to be filtered using the **Advanced Find** feature.  
  
> [!IMPORTANT]
>  Currently, report queries with hierarchical operators, such as the `Under` operator, can’t be used with report filtering. When you try to run a report that uses a hierarchical operator, the report won’t render.  
  
  
<a name="Fetch-basedPre-filtering"></a>   
## Enabling data pre-filtering in Fetch-based reports  
 Fetch-based reports support only automatic data pre-filtering. A report can have multiple data sets and multiple FetchXML queries. One data set supports one FetchXML query. To enable pre-filtering for the primary or linked entity in a Fetch-based report, you must set the value of the `enableprefiltering` parameter to “1”, and specify a parameter name in the `prefilterparametername` property. The parameter name should start with “CRM_” to specify it as a hidden parameter. As with the [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)]-based report, this parameter specified in the FetchXML query acts as a sub query within the FetchXML query, and the sub query is constructed with the value specified by the user in the **Advanced Find** area while running a report.  
  
 The following example displays how to enable pre-filtering for the primary entity in the FetchXML query.  
  
```xml  
<CommandText  
 <fetch distinct="false" mapping="logical">  
   <entity name="account" enableprefiltering="1" prefilterparametername="CRM_FilteredAccount">  
      <attribute name="name" />  
      <attribute name="accountid" />  
   </entity>  
 </fetch>  
</CommandText>  
<DataSourceName>CRM</DataSourceName>  
```  
  
 Similarly, you can enable pre-filtering for the linked entity. You can also specify a different pre-filtering condition for the linked entity in the FetchXML query by specify a different and unique name for the parameter name in the `prefilterparametername` property.  
  
 If you are manually modifying a Fetch-based report definition without using the Report Wizard in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] web application or [!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)] to enable pre-filtering for primary and linked entities, make sure that you:  
  
1. Similarly, you can enable pre-filtering for the linked entity. You can also specify a different pre-filtering condition for the linked entity in the FetchXML query by specify a different and unique name for the parameter name in the `prefilterparametername` property.  
  
    If you are manually modifying a Fetch-based report definition without using the Report Wizard in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] web application or [!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)] to enable pre-filtering for primary and linked entities, make sure that you:  
  
   ```xml  
   <fetch distinct="false" mapping="logical">  
      <entity name="account" enableprefiltering="1" prefilterparametername="CRM_FilteredAccount">  
   ```  
  
2. Create a corresponding query parameter with the same name as specified for the `prefilterparametername` property. Make sure that the parameter name starts with `CRM_` to specify it as a hidden parameter.  
  
   ```xml  
   <QueryParameters>  
      <QueryParameter Name="CRM_FilteredAccount">  
      <Value>=Parameters!CRM_FilteredAccount.Value</Value>  
   </QueryParameter>  
   ```  
  
3. Create a corresponding report parameter with the same name.  
  
   ```xml  
   <ReportParameters>  
       <ReportParameter Name="CRM_FilteredAccount">  
         <DataType>String</DataType>  
         <Prompt>CRM Filtered Account</Prompt>        
       </ReportParameter>  
     </ReportParameters>  
  
   ```  
  
<a name="PassingFilters"></a>   
## Passing filters in the filter summary  
 A filter summary displays the value of the filter that is used when a report is run. In [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] reports, it is displayed as a text box report item in the report header that contains the filter text value. When the user runs the report, the Report Viewer displays an **Edit Filter** button. When the button is clicked, it enables the user to define a data filter. An example of a filter summary can be found in the User Summary report that is included with [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)].  
  
 To add a filter summary to a report, follow these steps:  
  
1. Create a hidden string parameter called `CRM_FilterText`.  
  
2. Add a text box report item to the report and set its `Value` property as follows:   
   `=Parameters!CRM_FilterText.Value.`  
  
   When the report is run, the value of the `CRM_FilterText` parameter will be set by the system to the text of the current filter.  
  
<a name="DefaultFilters"></a>   
## Default filters  
 When you publish a report, you can set a default filter. For all the reports that were created by using the report wizard, if you do not set a default filter, the filter is automatically set to all records of the entity modified within the last 30 days. For the procedure to define a default report filter, see [Publish Reports](../analytics/publish-reports.md).  
  
### See also  
 [Reporting and Analytics Guide](../analytics/reporting-analytics-with-dynamics-365.md)   
 [Dynamics 365 (online) Reporting Considerations](../analytics/reporting-considerations.md)
