---
title: Analyze Your Data with Power BI
description: This section walks you through the process of exporting your Customer Insights data to analyze it with Power BI.
keywords: dynamics 365; customer insights
Applies_to: Dynamics 365 for Customer Insights
author: jimholtz
ms.author: jimholtz
manager: brycho
ms.date: 07/03/2017
ms.topic: get-started-article
ms.service: customer-insights 
ms.assetid: 9159d651-5bc6-41d2-943a-64e8ecac17e1
---
Analyze your data with Power BI
==========================
[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

>[!NOTE]
>The Dynamics 365 for Customer Insights Power BI connector is a Preview feature.

Combine the analytical power of Customer Insights with data visibility and exploration capabilities of Power BI to build interactive reports and dashboards. This connector is used to extract data from Customer Insights KPIs and profiles to build Power BI reports.

![Power BI with Customer Insights data](../media/PowerBIDashboard.png "Power BI with Customer Insights data") 

Example of Power BI report built from Customer Insights data

##Requirements
- [Power BI Desktop] (https://powerbi.microsoft.com/en-us/documentation/powerbi-desktop-report-view/)  
- Customer Insights hub

##To use Customer Insights data in Power BI

1.  In Power BI, select **Get Data** > **Online Services** > **Dynamics 365 for Customer Insights**.

2.  On the **All Data Sources** blade, select **Add**.

    ![Get data from Customer Insights](../media/PowerBIGetData600.png "Get data from Customer Insights") 

3.  Enter your Customer Insights API endpoint URL and select **OK**.

    >[!NOTE]
    >To find this URL, sign in to your Azure portal, open your Customer Insights hub, and then go to the **Overview** blade. Mouse over the URL and select **Click to copy** to copy the URL.
    ><br>
    ><br>
    >![Api Endpoint URL](../media/PowerBIAPIEndpoint650.png "Api Endpoint URL") 

4.  Sign in with your Customer Insights credentials, and then select **Connect**.

    ![Connect to Customer Insights](../media/PowerBIConnect600.png "Connect to Customer Insights") 

    The KPIs and Profiles from your Customer Insights hub are displayed. 

    ![KPIs and Profiles from Customer Insights](../media/PowerBINavigator600.png "KPIs and Profiles from Customer Insights") 

5.  Select a KPI or Profile to create a query, then select **Edit**.

    ![Select a KPI or Profile](../media/PowerBIDepositAmountKPI600.png "Select a KPI or Profile") 

    The Power BI Query Editor is displayed.

    ![Power BI Query Editor](../media/PowerBIQueryEditor600.png "Power BI Query Editor") 

6.  Proceed to edit your query in the Power BI Query Editor. When done, select **Close & Apply**.

    ![Apply the query changes](../media/PowerBICloseApply75.png "Apply the query changes") 

7.  Select **Relationships** to see your query as a table.

    ![Select Relationships](../media/PowerBIRelationships75.png "Select Relationships") 

8.  Select **Data** to see your data from Customer Insights.

    ![Select Data](../media/PowerBIData75.png "Select Data") 

9.  Select **Report** to start creating data visualizations.

    ![Select Report](../media/PowerBIReport75.png "Select Report") 

10. To build reports, drag fields under **Values**.

##Example Report

The following steps were done to create a report that aggregates the total deposit amounts per month.

|**Report**|**Steps**|
| ----------- | ---------- |
| ![Total sums report](../media/PowerBIReportSums75.png "Total sums report") | 1. Drag **TimeStamp** field under **Values**. <br> 2. Drag **Value** field under **Values**. <br> 3. Remove the **Day** value from **Timestamp** <br> 4. Set **Value** to **Sum**. <br><br> ![Total sums report steps](../media/PowerBITotalSumsSteps75.png "Total sums report steps") |
<!--
| ![Total sums month by account type report](../media/PowerBISumMnthAcctType75.png "Total sums month by account type report") | 1. Drag **Account Type** field under **Values**. <br> 2. Select the **Line Chart** control. <br> 3. Select the Hierarchy control in the report to get to Value by quarter and account type. <br> ![Hierarchy control](../media/PowerBIHierarchyControl75.png "Hierarchy control") <br><br> ![Total sums month by account type report steps](../media/PowerBISumMnthAcctTypeSteps75.png "Total sums month by account type report steps") |
| ![Slice the data by branch Report](../media/PowerBIBranchIDSlicer75.png "Slice the data by branch Report") | 1. Drag **BranchId** field into the report area. <br> 2. Select the **Slicer** control. <br> When you select the Branch ID, the values will change in the visualization.<br> ![Slicer control](../media/PowerBISlicerControl75.png "Slicer control") |
-->
When finished creating visualizations, you can save your report and upload it to your Power BI online account and publish it for others to use. You'll need to register with Microsoft Power BI.


### See also

[Register with Microsoft Power BI] (http://powerbi.com/)  
[Power BI Support: Report View in Power BI Desktop] (https://powerbi.microsoft.com/en-us/documentation/powerbi-desktop-report-view/)  

