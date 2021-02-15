---
title: "Use parameters in reports (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 09/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: bfacd711-3e5d-4dd7-a758-0faadda7e5a6
caps.latest.revision: 18
author: Mattp123
ms.author: matp
manager: amyla
tags: 
  - MigrationHO
search.audienceType: 
  - customizer

---
# Use parameters in reports

You use parameters in reports to control the data retrieved by prompting the user for a value or a set of values when the user runs the report. The dataset query retrieves only the data that is requested by the user. You can also add hidden and special parameters in the reports that do not prompt the user for input, but can be used for operations such as data filtering and dynamic drill-through.  

> [!NOTE]
>  The maximum length of the parameter values that are passed in from Microsoft Dynamics 365 Customer Engagement (on-premises) is 2,000 characters. For example, if you run a report and create a data filter through the **Advanced Find** user interface, the resulting filter expression that is passed to a filter parameter cannot exceed 2,000 characters. There is no maximum limit on the number of parameters that you can specify. However, you might have to limit the length of the string on the URL line and number of parameters to meet the requirements of a particular browser.  

<a name="BKMK_Adding"></a>   
## Adding parameters  
 You can add parameters to a report to define a report’s individual parameters, pass information through a query, or provide access to user settings, such as `CRM_CurrencySymbol` and `CRM_CurrencyPositivePattern` parameters.  

 The [\<ReportParameter>](https://technet.microsoft.com/library/ms153649(v=sql.90).aspx) is an element in the report definition (RDL) file that is used to describe an individual parameter in the report. The [\<QueryParameter>](https://technet.microsoft.com/library/ms155385(v=sql.90).aspx) contains information about an individual parameter that is passed to the data source as part of a query. The following XML code taken from the Account Summary report's RDL file demonstrates how to use the `ReportParameter` and `QueryParameter` parameters.  

```xml  
<ReportParameter Name="CRM_FilteredAccount">  
  <DataType>String</DataType>  
    <Nullable>true</Nullable>  
    <DefaultValue>  
      <Values>  
         <Value>select * from FilteredAccount</Value>  
      </Values>  
    </DefaultValue>  
    <AllowBlank>true</AllowBlank>  
    <Prompt>CRM_FilteredAccount</Prompt>  
</ReportParameter>  
```  

```xml  
<Query>  
   <rd:UseGenericDesigner>true</rd:UseGenericDesigner>  
   <CommandText>declare @sql as nVarchar(max)  
      set @sql = '  
      SELECT top 10 CAST(accountid as nvarchar(100)) as AccountID,  
      name, '''' as None  
      FROM (' + @FilteredAccount + ') as fa'  
      exec(@sql)  
   </CommandText>  
   <QueryParameters>  
      <QueryParameter Name="@FilteredAccount">  
         <Value>=Parameters!FilteredAccount.Value</Value>  
      </QueryParameter>  
   </QueryParameters>  
   <DataSourceName>CRM</DataSourceName>  
</Query>  
```  

 The following examples show how to use the `QueryParameter` and `ReportParameter` parameters in a `Fetch` based report.  

```xml  
<ReportParameter Name="FilteredAccount">  
      <DataType>String</DataType>  
      <Prompt>Filtered Account</Prompt>  
            <DefaultValue>  
                  <Values>  
                        <Value>  
                              <fetch version="1.0" output-format="xml-platform" mapping="logical" distinct="false">  
                              <entity name="account">  
                              <all-attributes/>  
                              </entity>  
                              </fetch>  
                        </Value>  
                  </Values>  
            </DefaultValue>  
    </ReportParameter>  
```  

```xml  
<Query>  
        <DataSourceName>DataSource1</DataSourceName>  
        <CommandText>  
                  <fetch>   
                  <entity name="account" enableprefiltering="true" prefilterparametername="FilteredAccount">  
                  <attribute name="accountid" />  
                  <attribute name="name" />  
                  </entity>  
                  </fetch>  
            </CommandText>  
        <QueryParameters>  
          <QueryParameter Name="FilteredAccount">  
            <Value>=Parameters!FilteredAccount.Value</Value>  
          </QueryParameter>  
        </QueryParameters>  
        <rd:UseGenericDesigner>true</rd:UseGenericDesigner>  
      </Query>  
```  

<a name="BKMK_Hidden"></a>   
## Hidden parameters  
 The Report Designer in [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] has built-in support for hidden parameters. In addition, you can hide parameters by adding a CRM_ prefix to the parameter name in a report. By default, the parameters with a CRM_ prefix are hidden when the report is published. When you run the report, you aren’t prompted to enter parameter values for the hidden parameters.  

### Special parameters  
 The following table shows the special hidden parameters that you can use in your reports.  


|      Parameter       |                                                                                                                             Description                                                                                                                              |
|----------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|   `CRM_FilterText`   | Contains the value of the filter text that a report user interactively creates in the Report Viewer when the user runs a report. The parameter is in a filter summary text box that is located in the report header. The initial value is set to the default filter. |
|      `CRM_URL`       |                              Set to the URL of the app. Use this parameter when drilling through.                              |
| `CRM_FilteredEntity` |                                                                                         Use in a query expression to enable data pre-filtering (through **Advanced Find**).                                                                                          |

 You must create all parameters in a report before you can refer to them. The values of these special parameters are filled in by Customer Engagement (on-premises) when you run the report.  

### Additional format parameters  
 The following table contains additional parameters that you can use in the reports. Among them are parameters that provide access to the user Number settings information. You can use these values to format and display the numeric values. These parameters are similar to values specified in the [NumberFormatInfo Class](https://msdn.microsoft.com/library/system.globalization.numberformatinfo.aspx). Use these parameters in custom reports to format the data according to the user settings.  


|           Parameter            |                                                   Description                                                   |
|--------------------------------|-----------------------------------------------------------------------------------------------------------------|
|         `CRM_FullName`         |                        The full name of the user on whose behalf the report is running.                         |
|       `CRM_UserTimeZone`       |                           User’s time zone name, for example, Pacific Standard Time.                            |
|       `CRM_UILanguageId`       |                                       Current locale (LCID) of the user.                                        |
|    `CRM_YearStartWeekCode`     |     The first week of the year that’s used in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps.      |
|     `CRM_WeekStartDayCode`     |     The first day of the week that is used in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].      |
|   `CRM_FiscalCalendarStart`    | The start date for the fiscal year that is used in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. |
|     `CRM_FiscalPeriodType`     |                Specifies how the fiscal year is divided—Quarterly, Monthly, Annually and so on.                 |
|  `CRM_FiscalYearDisplayCode`   |    Specifies whether the fiscal year name is displayed based on when the fiscal year starts or when it ends.    |
| `CRM_FiscalYearPeriodConnect`  |             Specifies how the fiscal year and fiscal period are connected when displayed together.              |
|     `CRM_FiscalYearFormat`     |                          Specifies how the name of the fiscal year will be displayed.                           |
|    `CRM_FiscalPeriodFormat`    |                               Specifies how the fiscal period will be displayed.                                |
|  `CRM_FiscalYearPrefixFormat`  |                 Specifies whether a prefix is attached to the fiscal year when it is displayed.                 |
|  `CRM_FiscalYearSuffixFormat`  |                 Specifies whether a suffix is attached to the fiscal year when it is displayed.                 |
| `CRM_CurrencyDecimalPrecision` |                                         The currency decimal precision.                                         |
|      `CRM_CurrencySymbol`      |                                       The organization’s currency symbol.                                       |
| `CRM_CurrencyPositivePattern`  |                                The format pattern for positive currency values.                                 |
| `CRM_CurrencyNegativePattern`  |                                The format pattern for negative currency values.                                 |
|   `CRM_NumberDecimalDigits`    |                             The number of decimal places to use in numeric values.                              |
|  `CRM_NumberDecimalSeperator`  |                        The string that is used as a decimal separator in numeric values.                        |
|  `CRM_NumberNegativePattern`   |                                 The format pattern for negative numeric values.                                 |
|     `CRM_NumberGroupSizes`     |                The number of digits in each group to the left of the decimal in numeric values.                 |
|   `CRM_NumberGroupSeperator`   |            The string that separates groups of digits to the left of the decimal in numeric values.             |
|      `CRM_DateSeparator`       |                The string that separates the components of a date, such as year, month, and day.                |
|      `CRM_TimeSeparator`       |              The string that separates the components of time, such as hour, minutes, and seconds.              |
|       `CRM_AMDesignator`       |              The string that separates the components of time, such as hour, minutes, and seconds               |
|       `CRM_PMDesignator`       |                             The designator for hours that are "post meridiem" (PM).                             |
|     `CRM_ShortDatePattern`     |            The format pattern for a short date value that is associated with the "d" format pattern.            |
|     `CRM_LongDatePattern`      |            The format pattern for a long date value that is associated with the "D" format pattern.             |
|     `CRM_ShortTimePattern`     |            The format pattern for a short time value that is associated with the "t" format pattern.            |
|     `CRM_MonthDayPattern`      |      The format pattern for month and day values that are associated with the "m" and "M" format patterns.      |

### See also  
 [Reporting and Analytics Guide](../analytics/reporting-analytics-with-dynamics-365.md)   
 [Publish reports](../analytics/publish-reports.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]