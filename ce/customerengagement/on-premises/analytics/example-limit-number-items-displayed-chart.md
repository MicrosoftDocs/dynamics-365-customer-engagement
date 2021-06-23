---
title: "Example: Limit the number of items displayed in a chart (Dynamics 365 for Customer Engagement (on-premises))| MicrosoftDocs"
description: This example illustrates how to limit the number of items displayed in a chart
ms.custom: 
ms.date: 09/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 9e629985-b12b-479b-88a3-4eba254caac2
caps.latest.revision: 10
author: Mattp123
ms.author: matp
manager: amyla
tags: 
  - MigrationHO
search.audienceType: 
  - customizer

---
# Example: Limit the number of items displayed in a chart

Chart reports are limited to 15 data points. The dataset must limit the result set to the top 15 rows for the charted value. Additionally, a 16th "other" data point value is optional. This value represents an aggregation of all other rows in the domain. The 16th value is always sorted to the bottom of the result set. This adds a level of complexity to reports that contain drill-through functionality that is appropriate for some reports.  
  
> [!NOTE]
>  The number of data points and label length may have to be reduced to correctly display the contents of the chart.  
  
## Example  
 The following example demonstrates how to limit a number of data points shown in the table by using the FetchXML query. You have to provide two data sets with one FetchXML query per dataset. The results from the first dataset query are passed through the multi-valued parameters to the second dataset to filter the results of the query. Dataset1 retrieves the top 15 records ordered by revenue and Dataset2 retrieves the “TotalRevenue” aggregating all accounts except the accounts from DataSet1.  
  
```xml  
DataSet1:  
<fetch count="15">  
  <entity name="account" >  
    <attribute name="accountid" />  
    <attribute name="name" />  
    <attribute name="revenue" />  
    <order attribute="revenue" descending="true" />  
  </entity>  
</fetch>  
  
DataSet2:  
<fetch aggregate="true">  
 <entity name="account">  
    <attribute name="revenue" aggregate="sum" alias="TotalRevenue" />  
    <filter>  
       <condition attribute="accountid" operator="not-in" value="@TopAccountIds"/>  
     </filter>  
  </entity>  
</fetch>  
  
Report Parameter:  
  
<ReportParameter Name=" TopAccountIds ">  
      ...  
      <MultiValue>true</MultiValue>  
      <Hidden>true</Hidden>  
      <DefaultValue>  
            <DataSetReference>  
                  <DataSetName>DataSet1</DataSetName>  
                  <ValueField>accountid</ValueField>  
            </DataSetReference>  
      </DefaultValue>  
</ReportParameter>  
  
```  
  
### See also  
 [Sample Reports](../analytics/example-reports.md)   
 [Sample: Display the Top X Values](../analytics/example-display-top-x-values.md)   
 [Reporting and Analytics Guide](../analytics/reporting-analytics-with-dynamics-365.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]