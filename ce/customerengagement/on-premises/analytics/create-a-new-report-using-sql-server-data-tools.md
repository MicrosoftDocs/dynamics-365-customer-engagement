---
title: "Create a new report with SQL Server Data Tools in Dynamics 365 Customer Engagement (on-premises)"
description: "SQL Server Data Tools let you create or edit reports in Visual Studio. This page walks you through the steps to create a custom Fetch-based report."
ms.custom: 
ms.date: 12/08/2023
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: b029dc84-c368-4fb2-a689-bdcecb0aea92
caps.latest.revision: 22
author: Mattp123
ms.author: matp
contributors:
  - markha52
tags: 
  - MigrationHO
search.audienceType: 
  - customizer

---
# Create a new report using SQL Server Data Tools

[!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)] is a report authoring environment that lets you create or edit [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] reports in [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)]. The end result is a report definition .rdl file that contains the report definition that you can publish to view reports.  
  
 You can also author reports by using a common text editor. To reduce the effort to create a custom report, modify an existing .rdl file that provides most of the desired functionality. For more information about the format of the XML elements in an .rdl file, see [Report Definition Language Reference](/sql/reporting-services/reports/report-definition-language-ssrs). The modified report XML can be verified by using the specified XML schema. [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] will also verify the report definition and reject a report if the definition is invalid when you try to upload the report.  
  
> [!NOTE]
>  If the .rdl file contains a FetchXML query, the query in the RDL is validated by [!INCLUDE[pn_crm_fetch_extension](../includes/pn-crm-fetch-extension.md)], which internally validates it against the FetchXML schema.
  
<a name="FetchBased"></a>   
## Create a custom Fetch-based report  
 To create a custom Fetch-based report:  
  
1. Make sure that you have a supported version of [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)], [!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)], [!INCLUDE[pn_crm_fetch_extension](../includes/pn-crm-fetch-extension.md)], and the necessary privileges. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Report writing environment using SQL Server Data Tools](../analytics/report-writing-environment-using-sql-server-data-tools.md)  
  
2. Open [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)], and then create a report server project.  
  
3. In Solution Explorer, right-click the **Reports** folder, and then select **Add New Report**.  
  
4. Select **Next**.  
  
5. On the **Select the Data Source** page, select **New Data Source**, and then specify the following details:  
  
   - **Name**: Type a name for the data source.  
  
   - **Type**: Select **Microsoft Dynamics 365 Fetch**.  
  
   - **Connection String**: Specify the connection string. The connection string must be specified in the following format:  
  
        *ServerURL*;*OrganizationName*;*HomeRealmURL*  
  
        In this connection string, only *ServerURL* is mandatory. If *OrganizationName* isn't specified, the first organization that the user running this query belongs to is used. *HomeRealmURL* is the Home Realm URL of the Identity Provider used by your organization and is needed when your organization uses Federation for identity management. Contact your network administrator to determine the Home Realm URL.  
  
        Select **Credentials** to specify the credentials to connect to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps or [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps, and then select **Next**.  
  
6. On the **Design the Query** page, type the FetchXML query in the **Query** box. To get this query, you can do one of the following:  
  
   - Get the FetchXML from an Advanced Find query. To do this, open a Customer Engagement (on-premises) app, select **Advanced Find**, create the query that you want, and then on the **Advanced Find** tab, select **Download Fetch XML**. Copy the FetchXML into the **Query** box of the Dataset Properties in [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)].  
  
   - Manually enter the FetchXML query. This example shows how to create a report that displays all accounts with 5,000 or more employees.  
  
     ```  
     <fetch version="1.0" output-format="xml-platform" mapping="logical" distinct="false">  
       <entity name="account">  
         <attribute name="name" />      
         <attribute name="numberofemployees" />  
         <attribute name="accountnumber" />  
         <order attribute="name" descending="false" />  
         <filter type="and">  
           <condition attribute="numberofemployees" operator="gt" value="5000" />  
         </filter>  
       </entity>  
     </fetch>  
     ```  
  
   <!-- [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Build queries with FetchXML](../developer/build-queries-fetchxml.md)  -->
  
    Select **Next**.  
  
7. Verify the fields that will be included in the report, and then select **Next**.
    - The Report Authoring Extension adds extra fields depending on the data type. Numbers, dates, lookups and optionsets have an extra _fieldName_**Value** field. For example, if the FetchXML includes the *createdon* attribute, there are two fields available: *createdon* and *createdonValue*.
      - *fieldName* (example: *createdon*)
        - This field is a string formatted according to the user's format settings. It's intended for display only. Converting the value to its original data type might result in an error. For example, an expression such as `=CDate(Fields!createdon.Value)` might fail or give an incorrect date if the date format doesn't match the locale settings on the report server.
        - For optionset fields the value is the display text of the optionset value.
        - For lookup fields the value is the primary name field of the linked record.
      - *fieldName***Value** (example: *createdonValue*)
        - This field is the raw unformatted value of the field according to the data type. The fields can be adjusted and formatted for user-specific display using the [hidden CRM_ format parameters](../analytics/use-parameters-in-reports.md).
        - For datetime fields, it's the UTC value.
        - For number or currency fields, it's the unformatted numeric value.
        - For optionset fields it's the option number value.
        - For lookup fields it's the Guid of the lookup field.

8. Select a style to apply to the report, and then select **Next**.  
  
9. Verify the fields that will be included in the report and enter a name for the report, such as *Accounts With More Than 5,000 Employees*. Select **Finish**.  
  
10. If you’d like to see how the report appears when it’s run, select the **Preview** tab.  
  
    This generates an .rdl file with the specified report name. You can use this file to publish your custom report in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps using the Report Wizard. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Publish reports](../analytics/publish-reports.md)  
  
### See also

 [Report Writing Environment](../analytics/report-writing-environment-using-sql-server-data-tools.md)   <br />

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
