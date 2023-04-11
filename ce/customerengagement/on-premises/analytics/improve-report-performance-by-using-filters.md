---
title: "Use data filtering in Dynamics 365 Customer Engagement (on-premises)"
description: "Reports that return large data sets can be difficult to use and cause performance problems. To limit the data that's presented, enable data filters."
ms.custom: 
ms.date: 09/30/2017
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 65af0819-705e-4628-ad2f-05df9211c374
caps.latest.revision: 15
author: Mattp123
ms.author: matp
tags: 
  - MigrationHO
search.audienceType: 
  - customizer

---
# Improve report performance by using filters

Reports that return large data sets can be difficult to use and can cause performance problems. To limit the data that is presented in a report, use data filters.  
  
 In addition to data filtering supported by Reporting Services, Microsoft Dynamics 365 Customer Engagement (on-premises) supports data pre–filtering. You can use data pre-filtering to:  
  
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
  
1. Similarly, you can enable pre-filtering for the linked entity. You can also specify a different pre-filtering condition for the linked entity in the FetchXML query by specify a different and unique name for the parameter name in the `prefilterparametername` property.  
  
   If you are manually modifying a Fetch-based report definition without using the Report Wizard or [!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)] to enable pre-filtering for primary and linked entities, make sure that you:  
  
   ```xml  
   <fetch distinct="false" mapping="logical">  
   <entity name="account" enableprefiltering="1" refilterparametername="CRM_FilteredAccount">  
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

## Enabling data pre-filtering in SQL-based reports (Dynamics 365 on-premises only)

There are two ways that you can enable data pre-filtering on Microsoft Dynamics 365 SQL-based reports: automatic and explicit.

### Automatic pre-filtering

Automatic data pre-filtering is suited for simple queries. To enable automatic data pre-filtering on a report, you can use aliases for entity tables in queries. You do this by using an alias name that starts with CRMAF_.

For example, the following examples show two simple queries, with one modified to enable pre-filtering on the Account entity.

# [No pre-filtering](#tab/without-prefiltering)

Query without pre-filtering.

```sql
   SELECT <column1>, <column2>, <columnN>
   FROM FilteredAccount; 
```

# [Automatic pre-filtering](#tab/auto-prefiltering)

Modified query with automatic pre-filtering enabled.

```sql
   SELECT <column1>, <column2>, <columnN>
   FROM FilteredAccount AS CRMAF_FilteredAccount;
```

---

When you enable automatic data pre-filtering functionality by using the `CRMAF_` prefix, Microsoft Dynamics 365 modifies the query to include a parameter (for example, P1) when it is uploaded to Dynamics 365, as shown in the following examples.

# [Automatic pre-filtering](#tab/auto2-prefiltering)

Query with automatic pre-filtering.

```sql
   SELECT <column1>, <column2>, <columnN>
   FROM FilteredAccount AS CRMAF_FilteredAccount;
```

# [Dynamics 365](#tab/dynamics365-modified)

Query modified by Dynamics 365.

```sql
   SELECT <column1>, <column2>, <columnN>
   FROM (@P1) AS CRMAF_FilteredAccount; 
```

---

Dynamics 365 will pass a query to the P1 parameter depending on how the report is being filtered. In other words, automatic data pre-filtering acts as a subquery within the existing query.

The following examples illustrate how Dynamics 365 passes queries to the parameter (P1) as per different filtering requirements. In these examples, it is assumed that you are running the report from the **Reports** area in Dynamics 365, and are using the data filtering option.

#### Example 1

If you want to view only active accounts, the resulting query would be as follows:

```sql
SELECT <column1>, <column2>, <columnN>
FROM (SELECT FilteredAccount.* FROM FilteredAccount WHERE statecode = 0)
AS CRMAF_FilteredAccount
```

#### Example 2

If you are within a specific account and run the report, the resulting query would be as follows:

```sql
SELECT <column1>, <column2>, <columnN>
FROM (SELECT FilteredAccount.* FROM FilteredAccount WHERE AccountId = '<CurrentAccountId>')
AS CRMAF_FilteredAccount
```

#### Example 3

If you have a list of three selected accounts and you choose the option to run the report against the selected records, the resulting query would be as follows:

```sql
SELECT <column1>, <column2>, <columnN>
FROM  (SELECT FilteredAccount.* FROM FilteredAccount WHERE AccountId in ('<1stAccountId>', '<2ndAccountId>', '<3rdAccountId>') 
AS CRMAF_FilteredAccount
```

When any entity table names are aliased, the Advanced Find user interface is automatically included in the deployed report when it is run from Dynamics 365.

To alias an entity table name in Query Builder, right-click each table in your report, select **Properties**, and then enter the alias value in the form **CRMAF_FilteredEntity**, for example, *CRMAF_FilteredAccount*.

#### Limitation of automatic pre-filtering

When you use the `CRMAF_` prefix to enable automatic pre-filtering, Dynamics 365 adds a parameter in the query. With a more complex query, such as a query that uses UNION statements, this can lead to unexpected results because Dynamics 365 might only add the parameter to the first query.

For example, consider the following query containing UNION statements:


```sql
SELECT <column1>, <column2>, <columnN>
FROM FilteredAccount AS CRMAF_FilteredAccount
WHERE address1_stateorprovince = ‘FL'
UNION
SELECT <column1>, <column2>, <columnN>
FROM FilteredAccount AS CRMAF_FilteredAccount
WHERE address1_stateorprovince = 'CA'
```

When you upload the report, Dynamics 365 may filter only the first query using the parameter. This leads to the filtering not being applied to the second query:

```sql
SELECT <column1>, <column2>, <columnN>
FROM  (@P1) AS CRMAF_FilteredAccount WHERE address1_stateorprovince = 'FL'
UNION
SELECT <column1>, <column2>, <columnN>
FROM FilteredAccount AS CRMAF_FilteredAccount
WHERE address1_stateorprovince = 'CA'
```

In the preceding example, while running the report from the **Reports** area in Dynamics 365 and choosing the filter as annual revenue greater than 1,000,000, Dynamics 365 will pass a query to the P1 parameter as follows:

```sql
SELECT <column1>, <column2>, <columnN>
FROM  (SELECT FilteredAccount.* from FilteredAccount where AnnualRevenue > 1000000) AS CRMAF_FilteredAccount
WHERE address1_stateorprovince = 'FL'
UNION
SELECT <column1>, <column2>, <columnN>
FROM FilteredAccount AS CRMAF_FilteredAccount
WHERE address1_stateorprovince = 'CA'
```

This implies that the query would return only those accounts in Florida with an annual revenue greater than $1,000,000 and all the accounts in California, which is not what you intended. You wanted to view all the accounts in Florida and California with annual revenue greater than $1,000,000.

If you download the report from Dynamics 365 and open it in Microsoft Visual Studio, you will see the original version of the report that you uploaded into Dynamics 365. If you download the report directly from Microsoft SQL Server Reporting Services, you will notice that Dynamics 365 had modified the query but did not place the parameter where you wanted it to exist.

For complex queries like this, you must use explicit pre-filtering.

### Explicit pre-filtering

For complex queries such as queries using UNION statements, you may need to use explicit pre-filtering. Unlike automatic pre-filtering, Dynamics 365 doesn't rewrite the report query by passing values to the parameters during explicit pre-filtering when such a report is uploaded to Dynamics 365. You must explicitly make the required changes to the report by adding the pre-filtering parameter to the report, and then referencing the parameter in the query. You can then execute the query by using dynamic SQL.

When you use dynamic SQL, filtering through Advanced Find is enabled by creating a hidden parameter named `CRM_FilteredEntity`, for example, `CRM_FilteredAccount`, and by using this parameter in a dynamic SQL query expression. This parameter enables filtering on the table data obtained from the specified filtered view.

Taking the same example as discussed earlier to highlight the limitation of automatic pre-filtering, the following table shows a query with automatic pre-filtering modified to use explicit pre-filtering by using dynamic SQL. It is also assumed that while running the report from the **Reports** area in Dynamics 365, the filter has been applied as annual revenue greater than 1,000,000.

# [Automatic pre-filtering](#tab/auto3-prefiltering)

Query with automatic pre-filtering.

```sql
   SELECT <column1>, <column2>, <columnN>
   FROM FilteredAccount AS CRMAF_FilteredAccount
   WHERE address1_stateorprovince = ‘FL'
   UNION
   SELECT <column1>, <column2>, <columnN>
   FROM FilteredAccount AS CRMAF_FilteredAccount
   WHERE address1_stateorprovince = 'CA'
```

# [Explicit pre-filtering](#tab/explicit-prefiltering)

Query modified to use explicit pre-filtering.

```sql
   DECLARE @SQL nvarchar(4000)
   DECLARE @CRM_FilteredAccount nvarchar(2000)
   Set @CRM_FilteredAccount = 'Select FilteredAccount.* FROM FilteredAccount where AnnualRevenue > 1000000'
   SET @SQL = 'SELECT <column1>, <column2>, <columnN>
   FROM ('+@CRM_FilteredAccount+') AS FA where address1_stateorprovince = ''FL''
   UNION
   SELECT <column1>, <column2>, <columnN> 
   FROM ('+@CRM_FilteredAccount+') as CA where address1_stateorprovince  = ''CA'' '
   EXEC (@SQL)
```

---

> [!NOTE]
> Most of the standard Dynamics 365 SQL-based reports use the explicit pre-filtering option.

<a name="PassingFilters"></a>   
## Passing filters in the filter summary

 A filter summary displays the value of the filter that is used when a report is run. In reports, it is displayed as a text box report item in the report header that contains the filter text value. When the user runs the report, the Report Viewer displays an **Edit Filter** button. When the button is clicked, it enables the user to define a data filter. An example of a filter summary can be found in the User Summary report that is included with Customer Engagement (on-premises).  
  
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
 [Dynamics 365 for Customer Engagement (on-premises) Reporting Considerations](../analytics/reporting-considerations.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
