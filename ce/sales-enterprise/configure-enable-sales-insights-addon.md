---
title: "Configure and enable Sales insights add-on for Dynamics 365 Customer Engagement | MicrosoftDocs"
description: "Configure and enable Sales insights add-on"
keywords: "sales insights addon, insights addon, relationship analytics, predective lead scoring, lead scoring"
ms.date: 05/08/2018
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 93676b52-d168-497d-957f-ae2c8627645a
author: udaykirang
ms.author: udag
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 1
topic-status: Drafting
---

# Preview feature: Install and configure the Sales insights add-on

Applies to Dynamics 365 (online), version 9.0.2

<!--remove comment tags when the predictive lead scoring is going live.-->

The Sales insights add-on contains a Relationship analytics <!--and predictive lead scoring -->feature. <!--These--> This feature isn't available by default. To use this feature, you need to install the Sales insights add-on. <br>
> [!NOTE]
> To install this feature, you must be a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] administrator.

To understand how Relationship analytics is used<!--and predictive lead scoring works-->, see [Relationship analytics](../sales-enterprise/relationship-analytics.md).<br>
To know about Sales insights add-on related **General Data Protection Regulation (GDPR)**, see [Embedded Intelligence and GDPR](../sales-enterprise/embedded-intelligence-gdpr.md).  


To install and configure Relationship analytics<!-- and lead scoring-->:
1.  Install the Sales insights add-on.
2.	Configure Relationship analytics.
3.  (Optional) Uninstall the Sales insights add-on.

## Install the Sales insights add-on 
1.	Go to **Settings** > **Intelligence Configuration**.<br>
     ![Embedded intelligence home screen](../sales-enterprise/media/install-sales-insights-addon.png "Embedded intelligence home screen")  
     <br>

    > [!NOTE]
    > If you're using embedded intelligence for the first time, enable the features. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [How to enable embedded intelligence](#How-to-enable-embedded-intelligence).


2.  On the **Sales insights add-on** tile, select **Install**. <br>
    ![Sales insights addon tile](../sales-enterprise/media/install-sales-insights-addon-tile.png "Sales insights addon tile")  
     <br>
3.	On the **Sales Insights** installation page, carefully read and select the terms and conditions, and then select **Continue**. <br>
    The installation takes a few minutes to complete, and then the status appears in the status bar.<br>
    ![Accept sales insights addon terms and conditions](../sales-enterprise/media/sales-insights-addon-terms-conditions.png "Accept sales insights addon terms and conditions") <br>
Now you're ready to configure Relationship analytics<!-- and Predictive Lead Scoring-->.

## Configure the Sales insights add-on

After you install the Sales insights add-on, perform the following steps to configure Relationship analytics <!-- and predictive lead scoring --> according to the requirements of your organization.

1.	On the **Sales insights add-on** installation page, select **Go to Configuration**.

    > [!NOTE]
    > You can also select **Configuration** on the **Relationship analytics** <!-- or Predective lead scoring--> tile, which is on the embedded intelligence **Overview** tab. This option is available only after you install the Sales insights add-on.    
    ![Relationship analytics configuration](../sales-enterprise/media/relationship-analytics-configuration.png "Relationship analytics configuration") <br>
     <!--Have to change the screen once Predective lead scoring is available-->
    The **Relationship analytics** configuration page opens.
2.  Read and accept the Relationship analytics terms and conditions, and then select **Begin Setup**. <br>
    ![Accept terms and conditions for Relationship analytics](../sales-enterprise/media/relationship-analytics-terms-conditions.png "Accept terms and conditions for Relationship analytics") <br>
3.	To configure<!-- predictive lead scoring and--> Relationship analytics, perform the following steps:<br>
    a. On the **Relationship analytics** page, configure the parameters as described in the following table.

    |**Parameter**|**Description**|  
    |---------------------|----------------------------------------------|  
    |Data Sources|**CRM Activities:** If enabled, all historical data from Dynamics 365 is ingested for computation in Relationship analytics.<br>**Exchange Data:** If enabled, 30 days of data from Exchange is ingested for KPI and health computation. Exchange connector ingests three days of data per day until the last 30 days of data is complete.|  
    |Relationship Health Score|Businesses place different emphasis on the type of communication used with customers. You can modify the importance of activities of different types as they contribute to the relationship health score.|  
    |Communications Frequency|Businesses have varying sales cycles and different expected levels of communications with customers. A longer expected communications frequency reduces the expectation of more recent frequent communications in the health score. A shorter expected communications frequency increases the expectation of more recent frequent communications in the health score.|<br>
       
    ![Relationship analytics configuration settings page](../sales-enterprise/media/relationship-analytics-configuration-settings.png "Relationship analytics configuration settings page") <br>
    b. Select **Save**.<br>
       Relationship analytics is configured and ready to use in your organization.
<br>

## (Optional) Uninstall the Sales insights add-on

If you don't want to use the Sales insights add-on for your organization, you can uninstall it. To uninstall this feature:
1.	Go to **Settings** > **Customization** > **Solutions**.
    A list of solutions that are installed in your organization is displayed.
2. Select **SalesInsightsAddOn**, and then select **Delete**.<br>
   ![Sales insights add-on delete](../sales-enterprise/media/sales-insights-addon-uninstall.png "Sales insights add-on delete") <br>
3. A confirmation message is displayed. Select **OK**.<br>
   The Sales insights add-on feature is uninstalled from your organization.

## Troubleshooting   

**I am unable to connect to Exchange server while enabling Exchange Data in Relationship analytics**
As an administrator, you must provide privillages to connect to exchange server in Admin center:

1.  Go to **Admin** center.
    
    ![Admin center](../sales-enterprise/media/sales-insights-addon-admincenter.png "Admin center")

3.  Select **Settings** > **Services & add-ins** > **Dynamics Customer Insights Preview**.

    ![Select customer insights preview option](../sales-enterprise/media/sales-insights-addon-admincenter-customer-insights-preview.png "Select customer insights preview option")

4.  Configure the Dynamics Customer Insights Preview to **on** and select **Save**.

    ![Enable and save customer insights preview option](../sales-enterprise/media/sales-insights-addon-admincenter-customer-insights-preview-settings.png "Enable and save customer insights preview option")
    
    Now you can connect to exchange server to collect data.

### See also

[Get insights on opportunities, activities, and leads of customers](../sales-enterprise/sales-insights-addon.md)

[Opt out of relationship analytics (GDPR)](../sales-enterprise/optout-relationship-analytics-gdpr.md)