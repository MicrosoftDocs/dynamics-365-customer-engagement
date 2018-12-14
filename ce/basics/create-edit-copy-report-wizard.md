---
title: "Create or edit a report using the Report Wizard (Dynamics 365 for Customer Engagement) | MicrosoftDocs"
ms.custom: 
ms.date: 09/15/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 3b79a467-ae11-4c84-891e-9d1c790194b6
caps.latest.revision: 38
author: Mattp123
ms.author: matp
manager: brycho
search.audienceType: 
  - enduser
search.app: 
  - D365CE
---
# Create or edit a report using the Report Wizard

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

All reports that are created using the Report Wizard are Fetch-based reports. Note that all reports generated with the Report Wizard print in landscape mode.
  
1. [!INCLUDE[proc_permissions_system_admin](../includes/proc-permissions-system-admin.md)]  
  
    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)].  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_reports](../includes/proc-reports.md)]  
  
3. To add a new report, click **New**.  
  
4. In the **Report: New Report** dialog box, in the **Report Type** list, select **Report Wizard Report**, and then click **Report Wizard**.  
  
    You can only use the Report Wizard to edit reports that were created with the wizard.  
  
5. Select the starting point for your report.  
  
   1.  To create a new report, select **Start a new report**.  
  
        \- OR -  
  
        To start from a copy or edit an existing report, click **Start from an existing report**, and check the **Overwrite existing report** check box.  
  
   2.  Click **Next**.  
  
6. Enter the name of the report, and specify which record types the report will use.  
  
    This step identifies where the data in the report comes from. You can include data from one or two record types, or data from related records.  
  
   1.  Enter data in the fields:  
  
       - **Report name**. This value will be displayed in the reports area.  
  
       - **Primary record type**. Data from all fields in this record type and related record types will be available when you are defining criteria for which records to include.  
  
       - **Related record type**. If you need to display data from a related record type, select an additional record type here.  
  
       > [!CAUTION]
       >  Avoid selecting data from a related record type that is not required, as it makes the report take longer to load.  
  
   2.  Click **Next**.  
  
7. Define a filter to determine which records are included in your report.  
   ## Organize and lay out your report data
  
For detailed information on laying out your report, see [Organize and lay out your report data](../basics/organize-lay-out-your-report-data.md).  
  
1. Select the basic format of the report.  
  
    - **Table only**. This provides a table grouped and sorted as you specified.  
  
    - **Chart and table**. Displays both a chart and table.  
  
        - **Show table below the chart on same page**. Selecting  the chart does nothing.  
  
        - **Show chart. To view data for a chart region, click the chart region**. Selecting an area in the chart will display a table with details for that section of the chart.  
  
2. Click **Next**.  

## Include a chart in the report  
If the report includes a chart, specify the type of chart, and how the data is displayed in the chart.  

1.  Select the chart type, and then click **Next**.  

        The **Chart preview** area shows how the data will be displayed.  

    -   For vertical and horizontal bar charts and line charts, specify which data to display on each axis:  

        -   In the **Format Column (X) Axis** section, select the field to use for the X axis, and the label that is displayed on the chart for the field.  

        -   In the **Format Value (Y) Axis** section, you can select two fields. For each field, you can specify the label that is displayed on the chart.  

        -   In the **Format Labels and Legends** section, specify whether or not to show the data labels and a legend.  

    -   For pie charts, specify the slices and values for the chart.  

        -   For slices, you must select one of the groupings in your report.  

        -   For values, you must select a numeric column with a summary type.  

2.  Click **Next**.  

## Finish, test and refine the report

After you finish defining the report, return to the Report form, and if required, update the name and description of the report, and determine where the report is displayed.
  
1. Review the summary of the report, click **Next**, and then click **Finish**. 

2. Test the report. On the **reports** tab, in the **Actions** group, click **Run Report**. If the report needs modifications, edit the report.  
  
3. Make the report available to others for use. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Determine who can use a report](determine-who-can-use-report.md)  
 
## Edit a report

To edit an existing Report Wizard report, first select the report. Then, in the **Records** group, click **Edit**. Finally, click **Report Wizard**.  
   
If you need to change data on the **General** or **Administration** tabs for a new report, wait until the report is saved before making the changes. Any changes on these tabs made before a report is saved will be ignored.  
  
### See also  
 [Get started writing reports](../analytics/get-started-writing-reports.md)
